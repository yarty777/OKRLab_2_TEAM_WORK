using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using OKRLR_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//mongodb+srv://yaroslav0908l_db_user:<db_password>@formia.awxcqul.mongodb.net/?appName=ForMiA
namespace OKRLR_2
{
    public class Expense
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("custoner_id")]
        public string CustomerID { get; set; } = "000000000000000000000001";
        [BsonElement("Category")]
        public string Category { get; set; }
        [BsonElement("Suma")]
        public string Suma { get; set; }
        [BsonElement("Date")]
        public string Date { get; set; }
        [BsonElement("Comentar")]
        public string Comentar { get; set; }

        public Expense()
        {
            CustomerID = "000000000000000000000001";
            Category = "Products";
            Suma = "0";
            Date = "01.01.2025";
            Comentar = "---";
        }
        public Expense(string cu,string ca, string s, string d, string co)
        {
            CustomerID = cu;
            Category = ca;
            Suma = s;
            Date = d;
            Comentar = co;
        }
    }
}
public class MongoService
{
    private readonly IMongoDatabase _database;

    public MongoService()
    {
        var connectionString = "mongodb+srv://yaroslav0908l_db_user:yar0908%40%23@formia.awxcqul.mongodb.net/?appName=ForMiA";
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase("ForOKR"); // назва бази даних
    }

    private IMongoCollection<Expense> GetCollection()
    {
        return _database.GetCollection<Expense>("Expenses"); // назва колекції
    }

    // Запис даних
    public void InsertData(string category, string suma, string date, string comentar)
    {
        var collection = GetCollection();
        var newExpense = new Expense
        {
            CustomerID = AppSession.CurrentUserId, // завжди один і той самий користувач
            Category = category,
            Suma = suma,
            Date = date,
            Comentar = comentar
        };
        collection.InsertOne(newExpense);
    }

    // Читання всіх даних
    public List<Expense> GetAllData()
    {
        var collection = GetCollection();
        return collection.Find(_ => true).ToList();
    }

    // Читання вибірково за умовою (наприклад, всі, де Age > 20)
    public List<Expense> GetCurrentUserData()
    {
        var collection = GetCollection();
        return collection.Find(d => d.CustomerID == AppSession.CurrentUserId).ToList();
    }

}
public static class AppSession
{
    public static string CurrentUserId { get; set; } = "000000000000000000000001";
}


using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using MongoDB.Driver;
namespace OKRLR_2
{
    public partial class Form1 : Form
    {
        private MongoService mongoService;
        public Form1()
        {
            InitializeComponent();
            mongoService = new MongoService();
        }
        string filePath = Path.Combine(Application.StartupPath, "expenses.txt");
        private void LoadData()
        {
            var data = mongoService.GetCurrentUserData();
            dataGridView1.DataSource = data;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e) // я так поняв ми потім сюдою будем вводити наші витрати
        {
            Form2 addForm = new Form2(mongoService);
            addForm.ShowDialog();

        }
        private int MonthNumber(string month)
        {
            switch (month)
            {
                case "January": return 1;
                case "February": return 2;
                case "March": return 3;
                case "April": return 4;
                case "May": return 5;
                case "June": return 6;
                case "July": return 7;
                case "August": return 8;
                case "September": return 9;
                case "October": return 10;
                case "November": return 11;
                case "December": return 12;
                default: return 0;
            }
        }
        // кнопки
        private void buttonFindExpensive_Click(object sender, EventArgs e)
        {
            string selectedMonth = comboBoxMonth.Text;
            string selectedCategory = comboBoxCategory.Text;

            if (string.IsNullOrEmpty(selectedMonth) && string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("Виберіть місяць або категорію!");
                return;
            }

            // Зчитування витрат з файлу
            List<Expense> expenses = ReadExpensesFromFile();

            List<Expense> filtered = new List<Expense>();

            // Фільтруємо вручну
            for (int i = 0; i < expenses.Count; i++)
            {
                bool monthMatch = true;
                bool categoryMatch = true;

                if (selectedMonth != "")
                {
                    int month = MonthNumber(selectedMonth);
                    DateTime expenseDate = DateTime.Parse(expenses[i].Date);
                    int expenseMonth = expenseDate.Month;
                    if (month != expenseMonth)
                    {
                        monthMatch = false;
                    }
                }

                if (selectedCategory != "")
                {
                    if (expenses[i].Category != selectedCategory)
                    {
                        categoryMatch = false;
                    }
                }

                if (monthMatch && categoryMatch)
                {
                    filtered.Add(expenses[i]);
                }
            }

            // Обчислення суми
            double total = 0;
            for (int i = 0; i < filtered.Count; i++)
            {
                total += double.Parse(filtered[i].Suma);
            }

            // Оновлення таблиці
            dataGridView1.Rows.Clear();
            for (int i = 0; i < filtered.Count; i++)
            {
                dataGridView1.Rows.Add(
                    filtered[i].Category,
                    filtered[i].Suma,
                    filtered[i].Date,
                    filtered[i].Comentar
                );
            }

            MessageBox.Show("Загальні витрати: " + total.ToString("F2") + " грн", "Результат");
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Немає даних для редагування!");
                return;
            }

            List<Expense> list = new List<Expense>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                Expense exp = new Expense();
                exp.Category = dataGridView1.Rows[i].Cells[0].Value.ToString();
                exp.Suma = dataGridView1.Rows[i].Cells[1].Value.ToString();
                exp.Date = dataGridView1.Rows[i].Cells[2].Value.ToString();
                exp.Comentar = dataGridView1.Rows[i].Cells[3].Value.ToString();

                list.Add(exp);
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть рядок для видалення!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;
        }
    }
}

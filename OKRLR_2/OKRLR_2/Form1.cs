using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using MongoDB.Driver;
using System.Text;
namespace OKRLR_2
{
    public partial class Form1 : Form
    {
        private MongoService mongoService;
        public Form1()
        {
            InitializeComponent();
            mongoService = new MongoService();
            LoadData();
        }
        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            var data = mongoService.GetCurrentUserData();
            foreach (var expense in data)
            {
                dataGridView1.Rows.Add(
                    expense.Category,
                    expense.Suma,
                    expense.Date,
                    expense.Comentar
                );
            }
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
            LoadData();
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

            try
            {
                var allExpenses = mongoService.GetCurrentUserData(); // отримуємо дані користувача

                // фільтрація
                var filtered = allExpenses.AsEnumerable();

                if (!string.IsNullOrEmpty(selectedMonth))
                {
                    filtered = filtered.Where(e => e.Date.Split('.')[1] == selectedMonth);
                }

                if (!string.IsNullOrEmpty(selectedCategory))
                {
                    filtered = filtered.Where(e => e.Category == selectedCategory);
                }
                dataGridView1.Rows.Clear();
                foreach (var expense in filtered)
                {
                    dataGridView1.Rows.Add(
                        expense.Category,
                        expense.Suma,
                        expense.Date,
                        expense.Comentar
                    );
                }

                if (!filtered.Any())
                {
                    MessageBox.Show("Витрат за обраними параметрами не знайдено.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при пошуку: " + ex.Message);
            }
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
        private void увійтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();              
           
        }
        private void заєструватисяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register form2 = new Register();
            form2.Show();

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
        private void buttonStats_Click(object sender, EventArgs e)
        {
            try
            {
                var data = mongoService.GetCurrentUserData();
                if (data == null || data.Count == 0)
                {
                    MessageBox.Show("Немає даних для аналізу!");
                    return;
                }

                // Групуємо витрати по місяцях
                var monthly = new Dictionary<int, double>();

                foreach (var exp in data)
                {
                    if (DateTime.TryParse(exp.Date, out DateTime date) &&
                        double.TryParse(exp.Suma, out double amount))
                    {
                        int month = date.Month;
                        if (!monthly.ContainsKey(month))
                            monthly[month] = 0;
                        monthly[month] += amount;
                    }
                }

                string[] monthNames = {
            "Січень","Лютий","Березень","Квітень","Травень","Червень",
            "Липень","Серпень","Вересень","Жовтень","Листопад","Грудень"
        };

                double total = 0;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("📊 Витрати за 2025 рік:\n");

                for (int i = 1; i <= 12; i++)
                {
                    double sum = monthly.ContainsKey(i) ? monthly[i] : 0;
                    sb.AppendLine($"{monthNames[i - 1]}: {sum:F2} ₴");
                    total += sum;
                }

                double avg = total / 12;
                sb.AppendLine($"\nЗагальна сума: {total:F2} ₴");
                sb.AppendLine($"Середні витрати на місяць: {avg:F2} ₴");

                MessageBox.Show(sb.ToString(), "Статистика витрат");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час обчислення статистики: " + ex.Message);
            }
        }

    }
}

using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using MongoDB.Driver;
namespace OKRLR_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filePath = Path.Combine(Application.StartupPath, "expenses.txt");
        
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
            Form2 addForm = new Form2();
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

            SaveExpensesToFile(list);

            MessageBox.Show("Зміни збережено у файл!");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть рядок для видалення!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            // Зчитуємо всі записи
            List<Expense> expenses = ReadExpensesFromFile();

            if (index >= 0 && index < expenses.Count)
            {
                expenses.RemoveAt(index);
                SaveExpensesToFile(expenses);

                dataGridView1.Rows.RemoveAt(index);

                MessageBox.Show("Запис успішно видалено!");
            }
        }
        // методи
        private List<Expense> ReadExpensesFromFile()
        {
            List<Expense> list = new List<Expense>();

            if (!File.Exists(filePath))
                return list;

            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                if (parts.Length >= 4)
                {
                    Expense exp = new Expense();
                    exp.Category = parts[0];
                    exp.Suma = double.Parse(parts[1]);
                    exp.Date = parts[2];
                    exp.Comentar = parts[3];
                    list.Add(exp);
                }
            }

            return list;
        }
        private void SaveExpensesToFile(List<Expense> list)
        {
            string[] lines = new string[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                lines[i] = list[i].Category + " " +
                           list[i].Suma.ToString() + " " +
                           list[i].Date + " " +
                           list[i].Comentar;
            }

            File.WriteAllLines(filePath, lines);
        }

    }
}

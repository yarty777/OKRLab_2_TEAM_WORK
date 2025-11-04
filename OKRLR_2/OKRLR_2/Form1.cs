using MongoDB.Driver;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            var expenses = mongoService.GetCurrentUserData();

            foreach (var exp in expenses)
            {
                dataGridView1.Rows.Add(
                    exp.Id,           
                    exp.Category,
                    exp.Suma,
                    exp.Date,
                    exp.Comentar
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

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть рядок для редагування!");
                return;
            }

            var row = dataGridView1.SelectedRows[0];

            string id = row.Cells["ColumnId"].Value?.ToString();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Не знайдено Id запису!");
                return;
            }

            string category = row.Cells["ColumnCategory"].Value?.ToString() ?? "";
            string suma = row.Cells["ColumnSum"].Value?.ToString() ?? "";
            string date = row.Cells["ColumnDate"].Value?.ToString() ?? "";
            string comment = row.Cells["ColumnComment"].Value?.ToString() ?? "";

            // Редагування через InputBox
            category = Microsoft.VisualBasic.Interaction.InputBox("Категорія:", "Редагування", category);
            suma = Microsoft.VisualBasic.Interaction.InputBox("Сума:", "Редагування", suma);
            date = Microsoft.VisualBasic.Interaction.InputBox("Дата:", "Редагування", date);
            comment = Microsoft.VisualBasic.Interaction.InputBox("Коментар:", "Редагування", comment);

            var updatedExpense = new Expense
            {
                Id = id,
                CustomerID = AppSession.CurrentUserId,
                Category = category,
                Suma = suma,
                Date = date,
                Comentar = comment
            };

            try
            {
                mongoService.UpdateExpense(updatedExpense);
                MessageBox.Show("Дані успішно оновлені!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при оновленні: " + ex.Message);
            }
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть рядок для видалення!");
                return;
            }

            var row = dataGridView1.SelectedRows[0];
            string id = row.Cells["ColumnId"].Value?.ToString();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Не знайдено Id запису!");
                return;
            }

            if (MessageBox.Show("Ви впевнені, що хочете видалити цей запис?",
                "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    mongoService.DeleteExpense(id);
                    MessageBox.Show("Запис успішно видалено!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при видаленні: " + ex.Message);
                }
            }
        }
    }
}

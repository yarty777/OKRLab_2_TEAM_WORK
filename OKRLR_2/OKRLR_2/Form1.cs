<<<<<<< HEAD
using MongoDB.Driver;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
=======
Ôªøusing System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using MongoDB.Driver;
using System.Text;
>>>>>>> danja
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
        private void addToolStripMenuItem_Click(object sender, EventArgs e) // —è —Ç–∞–∫ –ø–æ–Ω—è–≤ –º–∏ –ø–æ—Ç—ñ–º —Å—é–¥–æ—é –±—É–¥–µ–º –≤–≤–æ–¥–∏—Ç–∏ –Ω–∞—à—ñ –≤–∏—Ç—Ä–∞—Ç–∏
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
        // –∫–Ω–æ–ø–∫–∏
        private void buttonFindExpensive_Click(object sender, EventArgs e)
        {
            string selectedMonth = comboBoxMonth.Text;
            string selectedCategory = comboBoxCategory.Text;

            if (string.IsNullOrEmpty(selectedMonth) && string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("–í–∏–±–µ—Ä—ñ—Ç—å –º—ñ—Å—è—Ü—å –∞–±–æ –∫–∞—Ç–µ–≥–æ—Ä—ñ—é!");
                return;
            }

            try
            {
                var allExpenses = mongoService.GetCurrentUserData(); // –æ—Ç—Ä–∏–º—É—î–º–æ –¥–∞–Ω—ñ –∫–æ—Ä–∏—Å—Ç—É–≤–∞—á–∞

                // —Ñ—ñ–ª—å—Ç—Ä–∞—Ü—ñ—è
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
                    MessageBox.Show("–í–∏—Ç—Ä–∞—Ç –∑–∞ –æ–±—Ä–∞–Ω–∏–º–∏ –ø–∞—Ä–∞–º–µ—Ç—Ä–∞–º–∏ –Ω–µ –∑–Ω–∞–π–¥–µ–Ω–æ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("–ü–æ–º–∏–ª–∫–∞ –ø—Ä–∏ –ø–æ—à—É–∫—É: " + ex.Message);
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("–ù–µ–º–∞—î –¥–∞–Ω–∏—Ö –¥–ª—è —Ä–µ–¥–∞–≥—É–≤–∞–Ω–Ω—è!");
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
        private void —É–≤—ñ–π—Ç–∏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();

        }
        private void –∑–∞—î—Å—Ç—Ä—É–≤–∞—Ç–∏—Å—èToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register form2 = new Register();
            form2.Show();

        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("–í–∏–±–µ—Ä—ñ—Ç—å —Ä—è–¥–æ–∫ –¥–ª—è –≤–∏–¥–∞–ª–µ–Ω–Ω—è!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;
        }
<<<<<<< HEAD

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("¬Ë·Â≥Ú¸ ˇ‰ÓÍ ‰Îˇ Â‰‡„Û‚‡ÌÌˇ!");
                return;
            }

            var row = dataGridView1.SelectedRows[0];

            string id = row.Cells["ColumnId"].Value?.ToString();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ÕÂ ÁÌ‡È‰ÂÌÓ Id Á‡ÔËÒÛ!");
                return;
            }

            string category = row.Cells["ColumnCategory"].Value?.ToString() ?? "";
            string suma = row.Cells["ColumnSum"].Value?.ToString() ?? "";
            string date = row.Cells["ColumnDate"].Value?.ToString() ?? "";
            string comment = row.Cells["ColumnComment"].Value?.ToString() ?? "";

            // –Â‰‡„Û‚‡ÌÌˇ ˜ÂÂÁ InputBox
            category = Microsoft.VisualBasic.Interaction.InputBox(" ‡ÚÂ„Ó≥ˇ:", "–Â‰‡„Û‚‡ÌÌˇ", category);
            suma = Microsoft.VisualBasic.Interaction.InputBox("—ÛÏ‡:", "–Â‰‡„Û‚‡ÌÌˇ", suma);
            date = Microsoft.VisualBasic.Interaction.InputBox("ƒ‡Ú‡:", "–Â‰‡„Û‚‡ÌÌˇ", date);
            comment = Microsoft.VisualBasic.Interaction.InputBox(" ÓÏÂÌÚ‡:", "–Â‰‡„Û‚‡ÌÌˇ", comment);

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
                MessageBox.Show("ƒ‡Ì≥ ÛÒÔ≥¯ÌÓ ÓÌÓ‚ÎÂÌ≥!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("œÓÏËÎÍ‡ ÔË ÓÌÓ‚ÎÂÌÌ≥: " + ex.Message);
            }
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("¬Ë·Â≥Ú¸ ˇ‰ÓÍ ‰Îˇ ‚Ë‰‡ÎÂÌÌˇ!");
                return;
            }

            var row = dataGridView1.SelectedRows[0];
            string id = row.Cells["ColumnId"].Value?.ToString();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ÕÂ ÁÌ‡È‰ÂÌÓ Id Á‡ÔËÒÛ!");
                return;
            }

            if (MessageBox.Show("¬Ë ‚ÔÂ‚ÌÂÌ≥, ˘Ó ıÓ˜ÂÚÂ ‚Ë‰‡ÎËÚË ˆÂÈ Á‡ÔËÒ?",
                "œ≥‰Ú‚Â‰ÊÂÌÌˇ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    mongoService.DeleteExpense(id);
                    MessageBox.Show("«‡ÔËÒ ÛÒÔ≥¯ÌÓ ‚Ë‰‡ÎÂÌÓ!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("œÓÏËÎÍ‡ ÔË ‚Ë‰‡ÎÂÌÌ≥: " + ex.Message);
                }
            }
        }
=======
        private void buttonStats_Click(object sender, EventArgs e)
        {
            try
            {
                var data = mongoService.GetCurrentUserData();
                if (data == null || data.Count == 0)
                {
                    MessageBox.Show("–ù–µ–º–∞—î –¥–∞–Ω–∏—Ö –¥–ª—è –∞–Ω–∞–ª—ñ–∑—É!");
                    return;
                }

                // –ì—Ä—É–ø—É—î–º–æ –≤–∏—Ç—Ä–∞—Ç–∏ –ø–æ –º—ñ—Å—è—Ü—è—Ö
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
            "–°—ñ—á–µ–Ω—å","–õ—é—Ç–∏–π","–ë–µ—Ä–µ–∑–µ–Ω—å","–ö–≤—ñ—Ç–µ–Ω—å","–¢—Ä–∞–≤–µ–Ω—å","–ß–µ—Ä–≤–µ–Ω—å",
            "–õ–∏–ø–µ–Ω—å","–°–µ—Ä–ø–µ–Ω—å","–í–µ—Ä–µ—Å–µ–Ω—å","–ñ–æ–≤—Ç–µ–Ω—å","–õ–∏—Å—Ç–æ–ø–∞–¥","–ì—Ä—É–¥–µ–Ω—å"
        };

                double total = 0;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("üìä –í–∏—Ç—Ä–∞—Ç–∏ –∑–∞ 2025 —Ä—ñ–∫:\n");

                for (int i = 1; i <= 12; i++)
                {
                    double sum = monthly.ContainsKey(i) ? monthly[i] : 0;
                    sb.AppendLine($"{monthNames[i - 1]}: {sum:F2} ‚Ç¥");
                    total += sum;
                }

                double avg = total / 12;
                sb.AppendLine($"\n–ó–∞–≥–∞–ª—å–Ω–∞ —Å—É–º–∞: {total:F2} ‚Ç¥");
                sb.AppendLine($"–°–µ—Ä–µ–¥–Ω—ñ –≤–∏—Ç—Ä–∞—Ç–∏ –Ω–∞ –º—ñ—Å—è—Ü—å: {avg:F2} ‚Ç¥");

                MessageBox.Show(sb.ToString(), "–°—Ç–∞—Ç–∏—Å—Ç–∏–∫–∞ –≤–∏—Ç—Ä–∞—Ç");
            }
            catch (Exception ex)
            {
                MessageBox.Show("–ü–æ–º–∏–ª–∫–∞ –ø—ñ–¥ —á–∞—Å –æ–±—á–∏—Å–ª–µ–Ω–Ω—è —Å—Ç–∞—Ç–∏—Å—Ç–∏–∫–∏: " + ex.Message);
            }
        }

>>>>>>> danja
    }
}

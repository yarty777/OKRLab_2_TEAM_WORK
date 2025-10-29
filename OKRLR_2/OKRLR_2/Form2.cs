using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OKRLR_2
{
    public partial class Form2 : Form
    {
        private MongoService mongoService;
        public Form2(MongoService service)
        {
            InitializeComponent();
            mongoService = service;
        }
        private int CategoryNumber(string category)
        {
            switch (category)
            {
                case "Products": return 1;
                case "Household chemicals": return 2;
                case "Taxes": return 3;
                case "Travel": return 4;
                case "Fuel": return 5;
                case "Devices": return 6;
                default: return 0;
            }
        }
        private void buttonsave_Click(object sender, EventArgs e)
        {
            //зроби тут щоб зберігалося можеш скористатися try catch щоб не було багато помилок
            if (comboBoxCategory.Text == "" || textBoxSum.Text == "" ||
         comboBoxDate.Text == "" || textBoxComentar.Text == "")
            {
                MessageBox.Show("Заповніть усі поля!");
                return;
            }
            if (!double.TryParse(textBoxSum.Text, out double suma))
            {
                MessageBox.Show("Оклад повинен бути числом!");
                return;
            }
            if (suma < 0)
            {
                MessageBox.Show("Оклад не може бути меншим за 0!");
                return;
            }
            try
            {
                // Викликаємо сервіс для запису в MongoDB
                mongoService.InsertData(
                    comboBoxCategory.Text,
                    suma.ToString(),
                    comboBoxDate.Text,
                    textBoxComentar.Text
                );

                MessageBox.Show("Дані успішно збережено!");
                // Очистка полів форми після збереження
                comboBoxCategory.SelectedIndex = -1;
                textBoxSum.Clear();
                comboBoxDate.SelectedIndex = -1;
                textBoxComentar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні: " + ex.Message);
            }
        }
    }
}

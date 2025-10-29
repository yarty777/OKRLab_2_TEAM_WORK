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

        private void buttonsave_Click(object sender, EventArgs e)
        {
            //зроби тут щоб зберігалося можеш скористатися try catch щоб не було багато помилок
            
            
            
            
            
           
        }
    }
}

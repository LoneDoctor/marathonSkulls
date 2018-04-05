using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Maraphon_Skills
{
    public partial class Form2 : Form
    {
        public string mail;
        public Form2()
        {
            SqlConnection database;
            SqlDataReader sqlread;
        
            InitializeComponent();
            /*
             * Так при заходе на свой акк передаем значение Email на невидмый объет для сравнение Email(ов) в пердставление 
             * сравнивает их и выводим если находит одинаковые значения 
             * перевод из секунд в часы, минуты и секунды
             * var ts = TimeSpan.FroSeconds(Время);
             * string time = ("{0}д. {1}ч. {2}м. {3}с.", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
             */
            database = new SqlConnection(@"Data Source=LENOVO-PC\MSSQLSERVER01; Initial Catalog = ws; Integrated Security = True");
            database.Open();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

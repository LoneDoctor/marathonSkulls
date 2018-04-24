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
    public partial class organization_list : Form
    {
        DateTime date = new DateTime(2018, 10, 30);
        public organization_list()
        {
            
            InitializeComponent();
            panel_1_sar.BackColor = Color.FromArgb(81, 81, 81);
            panel_2_sar.BackColor = Color.FromArgb(81, 81, 81);
            SqlConnection database;
            SqlDataReader sqlread;
            int z = 0;
            database = new SqlConnection(@"Data Source=LENOVO-PC\MSSQLSERVER01; Initial Catalog = ws; Integrated Security = True");
            database.Open();
            SqlCommand data = new SqlCommand("Select * from Charity", database);
            sqlread = data.ExecuteReader();
            while (sqlread.Read())
            {
                dataGridView_list_organization.Rows.Add();
                dataGridView_list_organization.Rows[z].Cells[0].Value = Image.FromFile(Application.StartupPath + @"\Изображения\" + sqlread["CharityLogo"]);
                dataGridView_list_organization.Rows[z].Cells[1].Value = sqlread["CharityName"].ToString();
                dataGridView_list_organization.Rows[z].Cells[2].Value = sqlread["CharityDescription"].ToString();
                z++;
            }
        }
        /// <summary>
        /// Возвращение на стартовое окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void return_to_start_Click(object sender, EventArgs e)
        {
            this.Close();
            more_information mi = new more_information();
            mi.Show();
        }
        /// <summary>
        /// подключение БД, вывод в таблицу информации об организациях в таблицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void organization_list_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_list_organization_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_to_start.Text = "";
            DateTime date_now = new DateTime();
            date_now = DateTime.Now;
            time_to_start.Text = (date - date_now).Days + " дней " + (date - date_now).Hours + " часов " + (date - date_now).Minutes + " минут " + " до старта марафона!";

        }
    }
}

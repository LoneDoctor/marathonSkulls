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
            panel_1_sar.BackColor = Color.FromArgb(81, 81, 81);
            panel_2_sar.BackColor = Color.FromArgb(81, 81, 81);     
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsDataSet.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter.Fill(this.wsDataSet.Charity);
            SqlConnection database;
            database = new SqlConnection(@"Data Source=LENOVO-PC\MSSQLSERVER01; Initial Catalog = ws; Integrated Security = True");
            database.Open();
            SqlDataAdapter data = new SqlDataAdapter("Select * from Charity", database);
            wsDataSet ds = new wsDataSet();
            data.Fill(ds, "Charity");
            dataGridView_list_organization.DataSource = ds;
            dataGridView_list_organization.DataMember = "Charity";
            for (int j = 0; j < dataGridView_list_organization.RowCount - 1; j++)
            {
                string a = Application.StartupPath + @"\Изображения\" + dataGridView_list_organization[4, j].Value;

                Bitmap img = new Bitmap(a);
              //  dataGridView_list_organization[0, j].Value = img;

                dataGridView_list_organization.Columns[0].Width = 60;
                dataGridView_list_organization.Rows[j].Height = 60;
                database.Close();
            }
            dataGridView_list_organization.Columns[4].Visible = false;
            dataGridView_list_organization.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView_list_organization.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView_list_organization.Columns[1].Visible = false;

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

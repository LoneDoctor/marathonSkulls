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
    
    public partial class My_Result : Form
    {
        int date = DateTime.Now.Year;
        string date_now;
        SqlConnection database;
        public My_Result()
        {
            database = new SqlConnection(@"Data Source=LENOVO-PC\MSSQLSERVER01; Initial Catalog = ws; Integrated Security = True");
            database.Open();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void My_Result_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Runner]", database);
            SqlDataReader sqlread = null;
            while (sqlread.Read()) // Чтение данных по запросу
            {
                if (sqlread["Email"].ToString() == "dennis.tyson@tyasa.com")
                {
                    date_now = sqlread["Email"].ToString();
                    date_now.Remove(3);
                    date = date - Convert.ToInt32(date_now);
                    label_age_group.Text = date.ToString();

                    if (Convert.ToInt32(label_age_group) <= 29)
                    { label_age_group.Text = "18-29"; }
                    else
                    if (Convert.ToInt32(label_age_group) <= 39)
                    { label_age_group.Text = "29-39"; }
                    else
                     if (Convert.ToInt32(label_age_group) <= 49)
                    { label_age_group.Text = "39-49"; }
                    else
                    if (Convert.ToInt32(label_age_group) <= 59)
                    { label_age_group.Text = "49-59"; }
                    else
                    if (Convert.ToInt32(label_age_group) <= 69)
                    { label_age_group.Text = "59-69"; }
                    else
                    if (Convert.ToInt32(label_age_group) <= 79)
                    { label_age_group.Text = "69-79"; }

                    label5.Text = sqlread["Gender"].ToString();
                   
                }
            } 
        }

        private void label_age_group_Click(object sender, EventArgs e)
        {

        }
    }
}

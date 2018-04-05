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
    public partial class registration_to_marathon : Form
    {
        int a, b;
        string message;
        SqlConnection database;
        SqlDataReader sqlread;
        public registration_to_marathon()
        {
            
           
            InitializeComponent();
            database = new SqlConnection(@"Data Source=LENOVO-PC\MSSQLSERVER01; Initial Catalog = ws; Integrated Security = True");
            database.Open();
        }

        private void registration_to_marathon_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsDataSet.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter.Fill(this.wsDataSet.Charity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsDataSet.Sponsorship". При необходимости она может быть перемещена или удалена.
            this.sponsorshipTableAdapter.Fill(this.wsDataSet.Sponsorship);

        }

        private void checkBox_halfMarathon_Click(object sender, EventArgs e)
        {
            a = 75;
            summ_pay.Text = "";
            summ_pay.Text = "$" + (a + b).ToString();
        }

        private void checkBox_shortDistance_Click(object sender, EventArgs e)
        {
            a = 20;
            summ_pay.Text = "";
            summ_pay.Text = "$" + (a + b).ToString();
        }

        private void radioButton_A_Click(object sender, EventArgs e)
        {
           b = 0;
            summ_pay.Text = "";
            summ_pay.Text = "$" + (a + b).ToString();
        }

        private void radioButton_B_CheckedChanged(object sender, EventArgs e)
        {
            b = 20;
            summ_pay.Text = "";
            summ_pay.Text = "$" + (a + b).ToString();
        }

        private void radioButton_C_CheckedChanged(object sender, EventArgs e)
        {
            b = 45;
            summ_pay.Text = "";
            summ_pay.Text = "$" + (a + b).ToString();
        }

        private void comboBox_vznos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command3 = new SqlCommand("SELECT * FROM [Charity]", database); //Ввод запроса
            sqlread = command3.ExecuteReader();
            while (sqlread.Read())
            {
                if (comboBox_vznos.Text == sqlread["CharityName"].ToString())
                {
                    label_name_fond.Text = sqlread["CharityName"].ToString();
                    fond_name.Text = sqlread["CharityName"].ToString();
                    fond_information.Text = sqlread["CharityDescription"].ToString();
                    fond_label.ImageLocation = Application.StartupPath + @"\Изображения\" + sqlread["CharityLogo"].ToString();

                }

            }
            sqlread.Close();
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (checkBox_full_marathon.Checked == false && checkBox_halfMarathon.Checked == false && checkBox_shortDistance.Checked == false)
            { message = "Вы не выбрали ни один из типов марафона"; }
            if (summ_for_pay.Text == "00")
            { message += "Вы не заплатитили нам"; }
            if (message != "")
            {
                this.Close();
                confirmation_of_marathon com = new confirmation_of_marathon();
                com.Show();
            }
            else
            {
                MessageBox.Show(message);
                message = "";
            }
        }

        private void open_info_about_fond_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void return_to_main_window_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void return_to_start_Click(object sender, EventArgs e)
        {

        }

        private void summ_for_pay_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(summ_for_pay.Text) < 0)
            {
                summ_for_pay.Text = "0";
            }
        }

        private void checkBox_full_marathon_Click(object sender, EventArgs e)
        {
            a = 145;
            summ_pay.Text = "";
            summ_pay.Text = "$" + (a + b).ToString();
        }
    }
}

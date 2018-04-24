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
using System.Text.RegularExpressions;

namespace Maraphon_Skills
{
    public partial class registration : Form
    {
        SqlConnection database;
        string fileText;
        DateTime date = new DateTime(2018, 10, 30);
        public registration()
        {
            database = new SqlConnection(@"Data Source=LENOVO-PC\MSSQLSERVER01;Initial Catalog=ws;Integrated Security=True");
            database.Open();
            InitializeComponent();

            openFileDialog1.Filter = "Image files (*.*)|*.*";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_to_start.Text = "";
            DateTime date_now = new DateTime();
            date_now = DateTime.Now;
            time_to_start.Text = (date - date_now).Days + " дней " + (date - date_now).Hours + " часов " + (date - date_now).Minutes + " минут " + " до старта марафона!";

        }

        private void registration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsDataSet1.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.wsDataSet1.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsDataSet1.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.wsDataSet1.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsDataSet.Gender". При необходимости она может быть перемещена или удалена.
            panel_1_sar.BackColor = Color.FromArgb(81, 81, 81);
            panel_2_sar.BackColor = Color.FromArgb(81, 81, 81);
        }


        private void return_to_start_Click(object sender, EventArgs e)
        {
            this.Close();
            Start_m sm = new Start_m();
            sm.Show();
        }

        private void Open_choise_photo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            fileText = System.IO.File.ReadAllText(filename);
            textBox_name_photo.Text = fileText;
            pictureBox_runner_photo.ImageLocation = filename;
        }

        private void textbox_email_Click(object sender, EventArgs e)
        {
            if (textbox_email.Text == "E-Mail")
            {
                textbox_email.Text = "";
                textbox_email.ForeColor = Color.Black;
            }
        }

        private void textBox_password_Click(object sender, EventArgs e)
        {
            if (textBox_password.Text == "Пароль")
            {
                textBox_password.Text = "";
                textBox_password.ForeColor = Color.Black;
            }
        }

        private void textBox_repeatPassword_Click(object sender, EventArgs e)
        {
            if (textBox_repeatPassword.Text == "Повторите пароль:")
            {
                textBox_repeatPassword.Text = "";
                textBox_repeatPassword.ForeColor = Color.Black;
            }
        }

        private void textBox_name_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "Имя")
            {
                textBox_name.Text = "";
                textBox_name.ForeColor = Color.Black;
            }
        }

        private void textBox_SecondName_Click(object sender, EventArgs e)
        {
            if (textBox_SecondName.Text == "Фамилия")
            {
                textBox_SecondName.Text = "";
                textBox_SecondName.ForeColor = Color.Black;
            }
        }

        private void registrat_Click(object sender, EventArgs e)
        {
            string pattern = @"\b[A-Za-z0-9_%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,6}\b";
            if (!Regex.IsMatch(textbox_email.Text, pattern, RegexOptions.IgnoreCase))
                MessageBox.Show("перепроверьте имейл");

            if (!(Regex.IsMatch(textBox_password.Text, "[A-Z]") && Regex.IsMatch(textBox_password.Text, "[a-z]") && Regex.IsMatch(textBox_password.Text, "[0-9]")
                && Regex.IsMatch(textBox_password.Text, "[!,@,#,$,%]") && textBox_password.TextLength >= 6 && textbox_email.Text == ""))
                MessageBox.Show("Перепроверь данные!");
            else
            {
                MessageBox.Show("anjksd");

                pictureBox_runner_photo.Image.Save(@"C:\Users\lenovo\Desktop\программа марафон\Photos/" + textbox_email.Text + ".png");

                SqlCommand com2 = new SqlCommand(@"INSERT INTO [dbo].[User] (Email, Password, FirstName, LastName, RoleId)
                Values ('" + textbox_email.Text + "', '" + textBox_password.Text + "', '" + textBox_name.Text + "', '" + textBox_SecondName.Text + "', 'R')", database);
                com2.ExecuteNonQuery();

                SqlCommand com1 = new SqlCommand(@"INSERT INTO Runner (Email, Gender, DateOfBirth, CountryCode, photo_runner) 
                Values ('" + textbox_email.Text + "', '" + comboBox_Gender.Text + "', '" + dateOfBirth.Value + "', '" + comboBox_Country.SelectedValue + "', '" + textbox_email.Text + ".png" + "')", database);
                com1.ExecuteNonQuery();
            }
        }
    }
}


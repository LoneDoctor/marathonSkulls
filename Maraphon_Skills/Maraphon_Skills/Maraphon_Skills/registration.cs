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
    public partial class registration : Form
    {
        SqlConnection database;
        int a, b, c, d, q;
        string fileText;
        DateTime date = new DateTime(2018, 10, 30);
        public registration()
        {
            InitializeComponent();
            database = new SqlConnection(@"Data Source=LENOVO-PC\MSSQLSERVER01; Initial Catalog = ws; Integrated Security = True");
            database.Open();
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
            if (textBox_repeatPassword.Text == "Повторите пароль")
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
            if (textbox_email.Text != "E-Mail" && textBox_password.Text != "Пароль" && textBox_repeatPassword.Text != "Повторите пароль:" && textBox_name.Text != "Имя" && textBox_SecondName.Text != "Фамилия" && textBox_name_photo.Text != "")
            {
               
                    if (textBox_password.Text.Length > 6)
                    {
                        char[] str = new char[textBox_password.Text.Length];
                        for (int i = 0; i < textBox_password.Text.Length; i++)
                        {
                            str[i] = textBox_password.Text[i];
                            if (Char.IsDigit(textBox_password.Text[i]))
                            {
                                a = 1;
                            }
                            if ((Char.IsUpper(textBox_password.Text[i])))
                            {
                                b = 1;
                            }
                            if ((Char.IsLower(textBox_password.Text[i])))
                            {
                                c = 1;
                            }
                           if (textBox_password.Text == textBox_repeatPassword.Text)
                           {
                            q = 1;
                           }

                            if ((str[i] == '?') || (str[i] == '!') || (str[i] == '@') || (str[i] == '$'))
                            {
                                d = 1;
                                if (a == 0)
                                { textBox1.Text = textBox1.Text + "\n не хватает цифр"; }
                                if (b == 0)
                                { textBox1.Text = textBox1.Text + "\n не хватает заглавной буквы"; }
                                if (c == 0)
                                { textBox1.Text = textBox1.Text + "\n не хватает строчной буквы"; }
                                if (d == 0)
                                { textBox1.Text = textBox1.Text + " \n не хватает специальных символов: ?, !,@, $"; }
                                if (q == 0)
                                { textBox1.Text = textBox1.Text + "\n пароли не совпадают "; };
                                if (a + b + c + d + q != 5)
                                { MessageBox.Show(textBox1.Text);
                                    textBox1.Text = "";
                                }
                                if (a + b + c + d + q == 5)
                                {
                               
                                    SqlDataReader sqlData = null;
                                    SqlCommand command = new SqlCommand("SELECT * FROM [User]", database);
                                    sqlData = command.ExecuteReader(); //Компиляция
                                    while (sqlData.Read()) // Чтение данных по запросу
                                    {
                                    sqlData.Close();
                                    SqlCommand command1 = new SqlCommand("INSERT INTO user (Email, Password, FirstName, LastName, RoleId) VALUES (@email, @passw, @firstname, @secondName, @role)", database);
                                        command1.Parameters.AddWithValue("email", textbox_email.Text);
                                        command1.Parameters.AddWithValue("passw", textBox_password.Text);
                                        command1.Parameters.AddWithValue("firstname", textBox_name.Text);
                                        command1.Parameters.AddWithValue("secondName", textBox_SecondName.Text);
                                        command1.Parameters.AddWithValue("role", "R");
                                        command1.ExecuteNonQuery();
                                    
                                }
                         
                              //   SqlDataReader sqlData = null;
                                SqlCommand command21 = new SqlCommand("SELECT * FROM [Runner]", database);
                                    sqlData = command21.ExecuteReader(); //Компиляция
                                    while (sqlData.Read()) // Чтение данных по запросу
                                    {
                                    sqlData.Close();
                                    SqlCommand command2 = new SqlCommand("INSERT INTO Runner (Email,Gender,DateOfBirth, CountryCode,photo_runner) VALUES (@email, @gender, @DOB, @countryCo, @photo)", database);
                                        command2.Parameters.AddWithValue("email", textbox_email.Text);
                                        command2.Parameters.AddWithValue("gender", comboBox_Gender.Text);
                                        command2.Parameters.AddWithValue("DOB", dateOfBirth.Value);
                                        command2.Parameters.AddWithValue("countryCo", comboBox_Country.SelectedValue);
                                        command2.Parameters.AddWithValue("photo", fileText);
                                        command2.ExecuteNonQuery();
                                   
                                }
                                }
                            }
                        }
                    }
                   
              

                
                if (textbox_email.Text == "E-Mail")
                { textbox_email.BackColor = Color.Red; }
                if (textBox_password.Text == "Пароль")
                { textBox_password.BackColor = Color.Red; }
                if (textBox_repeatPassword.Text == "Повторите пароль:")
                { textBox_repeatPassword.BackColor = Color.Red; }
                if (textBox_name.Text == "Имя")
                { textBox_name.BackColor = Color.Red; }
                if (textBox_SecondName.Text == "Фамилия")
                { textBox_SecondName.BackColor = Color.Red; }
            }
            else
                MessageBox.Show("Вы не заполнили все нужные поля.");
        }
    }
}

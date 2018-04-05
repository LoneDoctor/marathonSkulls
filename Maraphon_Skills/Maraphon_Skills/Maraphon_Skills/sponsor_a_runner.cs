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
    public partial class sponsor_a_runner : Form
    {
        //thanks_for_spons tfs = new thanks_for_spons();
        SqlConnection database;
        SqlDataReader sqlread;
        int summ;
        DateTime date = new DateTime(2018, 10, 30);
        public sponsor_a_runner()
        {
            InitializeComponent();
            database = new SqlConnection(@"Data Source=LENOVO-PC\MSSQLSERVER01; Initial Catalog = ws; Integrated Security = True");
            database.Open();

        }
        /// <summary>
        /// Загрузка формы, при которой мы выводим обратный отсчет до старта таймера и вносим в комбобокс информацию о бегуне. Задаем пользовательский оттенок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sponsor_a_runner_Load(object sender, EventArgs e)
        {
            time_to_start.Text = "";
            DateTime date_now = new DateTime();
            date_now = DateTime.Now;
            time_to_start.Text = (date - date_now).Days + " дней " + (date - date_now).Hours + " часов " + (date - date_now).Minutes + " минут " + " до старта марафона!";
            sqlread = null;

            try
            {
                SqlCommand command = new SqlCommand("SELECT dbo.[User].FirstName, dbo.[User].LastName, dbo.RegistrationEvent.BibNumber, dbo.Country.CountryName FROM dbo.Registration INNER JOIN dbo.Charity ON dbo.Registration.CharityId = dbo.Charity.CharityId INNER JOIN dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN dbo.Marathon INNER JOIN dbo.Country ON dbo.Marathon.CountryCode = dbo.Country.CountryCode ON dbo.Runner.CountryCode = dbo.Country.CountryCode INNER JOIN dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN dbo.Role ON dbo.[User].RoleId = dbo.Role.RoleId", database);
                sqlread = command.ExecuteReader();
                while (sqlread.Read())
                {
                   comboBox_runner.Items.Add(sqlread["FirstName"].ToString() + " " + sqlread["LastName"].ToString() + " - "   + sqlread["BibNumber"].ToString() + " (" + sqlread["CountryName"].ToString() + ")");
                }
                sqlread.Close();
            }
            catch { }
            /* 
             sqlread = command.ExecuteReader();

             while (sqlread.Read())
             {

                     comboBox_runner.Items.Add(sqlread);

             }
             sqlread.Close();

             panel_1_sar.BackColor = Color.FromArgb(81, 81, 81);
             panel_2_sar.BackColor = Color.FromArgb(81, 81, 81);
             */
        }
        /// <summary>
        /// Обратный отсчет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_date_Tick(object sender, EventArgs e)
        {
            time_to_start.Text = "";
            DateTime date_now = new DateTime();
            date_now = DateTime.Now;
            time_to_start.Text = (date - date_now).Days + " дней " + (date - date_now).Hours + " часов " + (date - date_now).Minutes + " минут " + " до старта марафона!";
        }
        /// <summary>
        /// Возвращение на начальное окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void return_to_start_Click(object sender, EventArgs e)
        {
            this.Close();
            Start_m sm = new Start_m();
            sm.Show();
        }

        /// <summary>
        /// Кнопка для отображения информации об организации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox_runner.Text != "")
            {
                panel1.Visible = true;
                panel1.BringToFront();
            }
        }

        /// <summary>
        /// Кнопка для закрытия информации об организации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        /// <summary>
        /// Кнопка "Заплатить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pay_Click(object sender, EventArgs e)
        {

            DateTime date_now = new DateTime();
            date_now = DateTime.Now;
            if (textBox_name.Text != "" && comboBox_runner.Text != "" && textBox_card.Text != "" && textBox_number.Text != "" && date_card_calendar.Value >= date_now && textBox_CVC.Text != "" && Convert.ToInt32(summ_for_pay.Text ) > 0)
            {
                this.Hide();
                thanks_for_spons tfs = new thanks_for_spons(this);
                tfs.Show();
            }
            else
                MessageBox.Show("Вы не заполнили все нужные поля или сумма меньше или равна нулю!");
        }
        /// <summary>
        /// Кнопка "Отмена"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void no_pay_Click(object sender, EventArgs e)
        {
            this.Close();
            Start_m sm = new Start_m();
            sm.Show();
        }
        /// <summary>
        /// кнопка "Убавить" к сумме взноса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void press_less_Click(object sender, EventArgs e)
        {
            summ = Convert.ToInt32(summ_for_pay.Text);
            summ -= 10;
            summ_for_pay.Text = summ.ToString();
            summ_pay.Text = "$" +  summ_for_pay.Text;
            if (Convert.ToInt32(summ_for_pay.Text) <= 0)
            {
                summ = 0;
                summ_for_pay.Text = summ.ToString();
            }
        }
        /// <summary>
        /// кнопка "Прибавить" к сумме взноса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void press_more_Click(object sender, EventArgs e)
        {
            summ = Convert.ToInt32(summ_for_pay.Text);
            summ += 10;
            summ_for_pay.Text = summ.ToString();
            summ_pay.Text = "$" + summ_for_pay.Text;
        }
        /// <summary>
        /// корректировка отображаемой в окне суммы и защита от пустого ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void summ_for_pay_TextChanged(object sender, EventArgs e)
        {
            summ_pay.Text = "$" + summ_for_pay.Text;
            if ( summ_for_pay.Text == "")
            {
                summ_pay.Text = "$00";
            }
        }
        /// <summary>
        /// Вывод данных об организации в зависимости от выбора бегуна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_runner_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [user]", database);

            sqlread = command.ExecuteReader();

            while (sqlread.Read())
            {
                if (comboBox_runner.SelectedItem.ToString() == sqlread["FirstName"].ToString() + " " + sqlread["LastName"].ToString())
                { textBox1.Text = sqlread["Email"].ToString(); }

            }
            sqlread.Close();

            SqlCommand command1 = new SqlCommand("SELECT * FROM [Runner]", database); //Ввод запроса
            sqlread = command1.ExecuteReader();
            while (sqlread.Read())
            {
                if (textBox1.Text == sqlread["Email"].ToString())
                {
                    textBox1.Text = sqlread["RunnerId"].ToString();
                }

            }
            sqlread.Close();

            SqlCommand command2 = new SqlCommand("SELECT * FROM [Registration]", database); //Ввод запроса
            sqlread = command2.ExecuteReader();
            while (sqlread.Read())
            {
                if (textBox1.Text == sqlread["RunnerId"].ToString())
                {
                    textBox1.Text = sqlread["CharityId"].ToString();
                }

            }
            sqlread.Close();
           
            SqlCommand command3 = new SqlCommand("SELECT * FROM [Charity]", database); //Ввод запроса
            sqlread = command3  .ExecuteReader();
            while (sqlread.Read())
            {
                if (textBox1.Text == sqlread["CharityId"].ToString())
                {
                    label_name_fond.Text = sqlread["CharityName"].ToString();
                    fond_name.Text = sqlread["CharityName"].ToString();
                    fond_information.Text = sqlread["CharityDescription"].ToString();
                    fond_label.ImageLocation = @"C:\Users\lenovo\Desktop\программа марафон\Maraphon_Skills\Изображения\marathon-skills-2016-charity-data\" + sqlread["CharityLogo"].ToString();
               
                }

            }
            sqlread.Close();
        }
        /// <summary>
        /// защита ввода от пробелов для имени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            textBox_name.Text = textBox_name.Text.Replace(" ", "");
        }
        /// <summary>
        /// защита ввода от ненужных символов для имени благотворителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if ((s < 'А') || (s > 'я'))
            { e.Handled = true; }

            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        /// <summary>
        /// защита ввода от ненужных символов для карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_card_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if ((s < 'А') || (s > 'я'))
            { e.Handled = true; }

            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        /// <summary>
        /// защита ввода от пробелов для номера карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_number_TextChanged(object sender, EventArgs e)
        {
            textBox_number.Text = textBox_number.Text.Replace(" ", "");
        }
        /// <summary>
        /// защита ввода от пробелов для CVC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_CVC_TextChanged(object sender, EventArgs e)
        {
            textBox_CVC.Text = textBox_CVC.Text.Replace(" ", "");
        }
        /// <summary>
        /// защита ввода от ненужных символов для номера карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if ((s < '0') || (s > '9'))
            { e.Handled = true; }

            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        /// <summary>
        /// защита ввода от ненужных символов для CVC 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_CVC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if ((s < '0') || (s > '9'))
            { e.Handled = true; }

            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        /// <summary>
        /// защита ввода от пробелов для номера карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_card_TextChanged(object sender, EventArgs e)
        {
            textBox_card.Text = textBox_card.Text.Replace(" ", "");
        }
        /// <summary>
        /// защита ввода от ненужных символов для суммы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void summ_for_pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if ((s < '0') || (s > '9'))
            { e.Handled = true; }

            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

/// <summary>
/// сброс начальных символов
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void textBox_name_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "Ваше имя")
            {
                textBox_name.Text = "";
                textBox_name.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// сброс начальных символов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_card_Click(object sender, EventArgs e)
        {
            if (textBox_card.Text == "Владелец карты")
            {
                textBox_card.Text = "";
                textBox_card.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// сброс начальных символов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_number_Click(object sender, EventArgs e)
        {
            if (textBox_number.Text == "Номер карты")
            {
                textBox_number.Text = "";
                textBox_number.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// сброс начальных символов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_CVC_Click(object sender, EventArgs e)
        {
            if (textBox_CVC.Text == "CVC")
            {
                textBox_CVC.Text = "";
                textBox_CVC.ForeColor = Color.Black;
            }
        }

     
    }
}


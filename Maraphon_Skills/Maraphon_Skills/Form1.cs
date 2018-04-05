using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maraphon_Skills
{
    
    public partial class Start_m : Form
    {
    
        DateTime date = new DateTime(2018,10,30);
        public Start_m()
            
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Загрузка формы,при которой происходит задание нужных, несистемных оттенков
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(this.Width, this.Height);
            panel_1_start.BackColor = Color.FromArgb(81,81,81);
            panel_2_start.BackColor = Color.FromArgb(81, 81, 81);
            Location_date_now.BackColor = Color.FromArgb(81, 81, 81);

            Location_date_now.Text = DateTime.Now.ToString("dd");
            time_to_start.Text = "";
            DateTime date_now = new DateTime();
            date_now = DateTime.Now;
            time_to_start.Text = (date - date_now).Days + " дней " + (date - date_now).Hours + " часов " + (date - date_now).Minutes + " минут " + " до старта марафона!";
        }
        /// <summary>
        /// Обратный отсчет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = new DateTime(2018, 10, 30);
            time_to_start.Text = "";
            DateTime date_now = new DateTime();
            date_now = DateTime.Now;
            time_to_start.Text =   (date - date_now).Days + " дней " +  (date - date_now).Hours + " часов " + (date - date_now).Minutes+ " минут " + " до старта марафона!";
        }
        /// <summary>
        /// Кнопка для перехода на страницу "Я хочу стать спонсором"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_wanna_sponsor_Click(object sender, EventArgs e)
        {
            this.Hide();
            sponsor_a_runner sar = new sponsor_a_runner();
            sar.Show();
        }
        /// <summary>
        /// Кнопка для перехода на страницу с информацией
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_wanna_now_Click(object sender, EventArgs e)
        {
            this.Hide();
            more_information mi = new more_information();
            mi.Show();
        }
        /// <summary>
        /// Кнопка для авторизации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_Click(object sender, EventArgs e)
        {
            autorization a = new autorization();
            this.Hide();
            a.Show();
        }
        /// <summary>
        /// Открывает окно выбора нового и старого бегунов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_wanna_runner_Click(object sender, EventArgs e)
        {
            this.Hide();
            Runner_choise rch = new Runner_choise();
            rch.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registration_to_marathon rtm = new registration_to_marathon();
            rtm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            info inf = new info();
            inf.Show();
        }
    }
}

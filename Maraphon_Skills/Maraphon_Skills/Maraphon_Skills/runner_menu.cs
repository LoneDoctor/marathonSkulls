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
    public partial class runner_menu : Form
    {
        public string mail;
        public runner_menu()
        {
            InitializeComponent();
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
        /// отображение информации о контактах
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contacts_Click(object sender, EventArgs e)
        {
            contact_panel.Visible = true;
            contact_panel.BringToFront();
        }
        /// <summary>
        /// Закрытие информации о контактах
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_contacts_Click(object sender, EventArgs e)
        {
            contact_panel.Visible = false;
        }
        /// <summary>
        /// выход из аккаунта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Start_m sm = new Start_m();
            sm.Show();
        }
        /// <summary>
        /// выход из аккаунта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Start_m sm = new Start_m();
            sm.Show();
        }

        private void my_results_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.mail = mail;
        }
    }
}

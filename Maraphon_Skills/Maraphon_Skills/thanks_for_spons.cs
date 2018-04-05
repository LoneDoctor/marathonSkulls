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
    public partial class thanks_for_spons : Form
    {
        public thanks_for_spons(sponsor_a_runner sar)
        {
            InitializeComponent();
            label_name_runner.Text = sar.comboBox_runner.Text;
            fond_name.Text = sar.label_name_fond.Text;
            pay_summ.Text = sar.summ_pay.Text;
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
        /// Возвращение на стартовое окно
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
        /// Возвращение на стартовое окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void return_to_main_window_Click(object sender, EventArgs e)
        {
            this.Close();
            Start_m sm = new Start_m();
            sm.Show();
        }
        /// <summary>
        /// Загрузка формы,при которой происходит задание нужных, несистемных оттенков
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thanks_for_spons_Load(object sender, EventArgs e)
        {
            thanks_for_money.ForeColor = Color.FromArgb(81, 81, 81);
            thanks_1.ForeColor = Color.FromArgb(81, 81, 81);
            thanks_2.ForeColor = Color.FromArgb(81, 81, 81);
            panel_1_sar.BackColor = Color.FromArgb(81, 81, 81);
            panel_2_sar.BackColor = Color.FromArgb(81, 81, 81);
        }
        }
    }


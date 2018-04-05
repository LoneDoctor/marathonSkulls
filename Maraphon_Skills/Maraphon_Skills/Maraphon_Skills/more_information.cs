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
    public partial class more_information : Form
    {
        public more_information()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Переход к информации об организациях
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void list_organization_Click(object sender, EventArgs e)
        {
            this.Close();
            organization_list ol = new organization_list();
            ol.Show();
        }
        /// <summary>
        /// Возвращение к начальному окну
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void return_to_start_Click(object sender, EventArgs e)
        {
            this.Close();
            Start_m sm = new Start_m();
            sm.Show();
        }
    }
}

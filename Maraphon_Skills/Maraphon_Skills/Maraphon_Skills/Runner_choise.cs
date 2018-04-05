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
    public partial class Runner_choise : Form
    {
        public Runner_choise()
        {
            InitializeComponent();
        }

        private void I_wanna_stay_runner_Click(object sender, EventArgs e)
        {
            this.Close();
            registration rg = new registration();
            rg.Show();
        }
    }
}

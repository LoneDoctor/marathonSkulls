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
    public partial class upload_volunters : Form
    {
        public upload_volunters()
        {
          
            InitializeComponent();
            openFileDialog1.Filter = "All files (*.CSV)|*.csv";
        }

        private void button_observe_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
        }
    }
}

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
    public partial class rewriting_profile : Form
    {

        public rewriting_profile(string data)
        {

            InitializeComponent();
            this.data = data;
        }
        string data;
        private void rewriting_profile_Load(object sender, EventArgs e)
        {

        }
    }
}

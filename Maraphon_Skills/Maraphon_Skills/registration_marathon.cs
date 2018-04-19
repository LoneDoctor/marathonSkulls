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
    public partial class registration_marathon : Form
    {
        public registration_marathon()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registration_marathon_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsDataSet.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter.Fill(this.wsDataSet.Charity);

        }
    }
}

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
    public partial class management_volounteres : Form
    {
        public management_volounteres()
        {
            InitializeComponent();
        }

        private void management_volounteres_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsDataSet.Volunteer". При необходимости она может быть перемещена или удалена.
            this.volunteerTableAdapter.Fill(this.wsDataSet.Volunteer);
            label_number_vol.Text = (Convert.ToInt32( dataGridView_volounteres.RowCount)-1).ToString();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            label_number_vol.Text = (Convert.ToInt32(dataGridView_volounteres.RowCount) - 1).ToString();
        }

        private void comboBox_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
           dataGridView_volounteres.Sort(dataGridView_volounteres.Columns[1], ListSortDirection.Ascending);
        }
    }
}

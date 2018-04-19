using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Maraphon_Skills
{
    public partial class interactiveMap : Form
    {
        Excel.Application Exc = new Excel.Application();
        public interactiveMap()
           
        {
            InitializeComponent();
        }

        private void interactiveMap_Load(object sender, EventArgs e)
        {
       
        }

        private void pictureBox_checkpoint1_Click(object sender, EventArgs e)
        {
            panel_information_checkpoint.Visible = true;
            label_landmark.Text = "Avenida Rudge";
            label_service_1.Text = "- Drinks";
            label_service_2.Text = "- Energy bars";
      
        }

        private void pictureBox_map_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_checkpoint2_Click(object sender, EventArgs e)
        {
            panel_information_checkpoint.Visible = true;
            label_landmark.Text = "Theatro Municipal";
            label_service_1.Text = "- Drinks";
            label_service_2.Text = "- Energy bars";
            label_service_3.Text = "- Toilets";
            label_service_4.Text = "- Information";
            label_service_5.Text = "- Medical";
        }

        private void pictureBox_checkpoint3_Click(object sender, EventArgs e)
        {
            panel_information_checkpoint.Visible = true;
            label_landmark.Text = "Parque do Ibirapuera";
            label_service_1.Text = "- Drinks";
            label_service_2.Text = "- Energy bars";
            label_service_3.Text = "- Toilets";
        }

        private void pictureBox_checkpoint4_Click(object sender, EventArgs e)
        {
            panel_information_checkpoint.Visible = true;
            label_landmark.Text = "Theatro Municipal";
            label_service_1.Text = "- Drinks";
            label_service_2.Text = "- Energy bars";
            label_service_3.Text = "- Toilets";
            label_service_4.Text = "- Medical";
        }

        private void pictureBox_checkpoint5_Click(object sender, EventArgs e)
        {
            panel_information_checkpoint.Visible = true;
            label_landmark.Text = "Theatro Municipal";
            label_service_1.Text = "- Drinks";
            label_service_2.Text = "- Energy bars";
            label_service_3.Text = "- Toilets";
            label_service_4.Text = "- Information";
        }

        private void pictureBox_checkpoint6_Click(object sender, EventArgs e)
        {
            panel_information_checkpoint.Visible = true;
            label_landmark.Text = "Rua Lisboa";
            label_service_1.Text = "- Drinks";
            label_service_2.Text = "- Energy bars";
            label_service_3.Text = "- Toilets";
           

        }

        private void pictureBox_checkpoint7_Click(object sender, EventArgs e)
        {
            panel_information_checkpoint.Visible = true;
            label_landmark.Text = "Cemitério da Consolação";
            label_service_1.Text = "- Drinks";
            label_service_2.Text = "- Energy bars";
            label_service_3.Text = "- Toilets";
            label_service_4.Text = "- Information";
            label_service_5.Text = "- Medical";
        }

        private void pictureBox_checkpoint8_Click(object sender, EventArgs e)
        {
            panel_information_checkpoint.Visible = true;
            label_landmark.Text = "Cemitério da Consolação";
            label_service_1.Text = "- Drinks";
            label_service_2.Text = "- Energy bars";
            label_service_3.Text = "- Toilets";
            label_service_4.Text = "- Information";
            label_service_5.Text = "- Medical";
        }
    }
}

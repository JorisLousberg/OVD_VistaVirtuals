using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVD_VistaVirtuals
{
    public partial class VistaVirtuals : Form
    {
        public string opleiding;

        public VistaVirtuals()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_veva_Click(object sender, EventArgs e)
        {
            PNL_Scenario_Screen.Visible = true;
            PNL_Scenario_Screen.BringToFront();
            PNL_Study_Screen.Visible = false;

            opleiding = "VEVA";

           /* MessageBox.Show("click here");
            this.Close();*/
        }

        private void btn_HTV_Click(object sender, EventArgs e)
        {
            PNL_Scenario_Screen.Visible = true;
            PNL_Scenario_Screen.BringToFront();
            PNL_Study_Screen.Visible = false;

            opleiding = "HTV";

        }

        private void btn_PB_Click(object sender, EventArgs e)
        {
            PNL_Scenario_Screen.Visible = true;
            PNL_Scenario_Screen.BringToFront();
            PNL_Study_Screen.Visible = false;

            opleiding = "PB";

        }

        private void btn_terug_Click(object sender, EventArgs e)
        {
            PNL_Scenario_Screen.Visible = true;
            PNL_Scenario_Screen.BringToFront();
            PNL_Start_Screen.Visible = false;

        }

    }
}

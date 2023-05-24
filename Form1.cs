﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            PNL_Start_Screen.BringToFront();
            MessageBox.Show("Test Start");
            
            var frh = new Admin();
            frh.Location = this.Location;
            frh.StartPosition = FormStartPosition.Manual;
            frh.FormClosing += delegate { this.Show(); };
            frh.Show();
            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_start_exe_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\joris\OneDrive\Documenten\TrashMasterz\demo V4\trash-Masterz.exe");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            PNL_Study_Screen.BringToFront();
            PNL_Study_Screen.Visible = true;
            PNL_Start_Screen.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U word doorverwezen naar een externe pagina. Wilt u doorgaan?");
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.youtube.com/watch?v=GtL1huin9EE&t=1s");
            Process.Start(sInfo);
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

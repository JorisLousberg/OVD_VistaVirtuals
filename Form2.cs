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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        //   SqlConnection conn = new SqlConnection("server=localhost;database=ovd;uid=root;password=");

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String pass;
            pass = textBox2.Text;

            if (pass == "admin")
               
            { 
                PNL_ScenarioOverVieuw.Visible = true;
                PNL_authorisation.BringToFront();
                PNL_ScenarioOverVieuw.Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong password");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}





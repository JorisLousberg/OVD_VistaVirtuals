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
        string filePath;
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

        private void BTN_start_exe_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\joris\OneDrive\Documenten\TrashMasterz\demo V4\trash-Masterz.exe");
        }
    }
}
//EEEEEEEEEEEEEEEEEEE
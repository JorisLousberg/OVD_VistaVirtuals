using System;
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

        public string opleiding; //stores the picked study for the scenario screen
        int PB_Count;
        int HTV_Count;
        int VEVA_Count;


        public string[] datalist;

        public List<List<string>> datalistdata { get; set; }

        int genlist;
        int genid;



        public VistaVirtuals()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PNL_Start_Screen.BringToFront();
            //MessageBox.Show("Test Start");
            
            var frh = new Admin();
            frh.Location = this.Location;
            frh.StartPosition = FormStartPosition.Manual;
            frh.FormClosing += delegate { this.Show(); };
            frh.Show();
            this.Hide();
            ReadingFile();
            PNL_Study_Screen.Visible = false;
            PNL_Study_Screen.SendToBack();
            PNL_Scenario_Screen.Visible = false;
            PNL_Scenario_Screen.SendToBack();

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
            GenerateButtons();
            /* MessageBox.Show("click here");
             this.Close();*/
        }

        private void btn_HTV_Click(object sender, EventArgs e)
        {
            PNL_Scenario_Screen.Visible = true;
            PNL_Scenario_Screen.BringToFront();
            PNL_Study_Screen.Visible = false;

            opleiding = "HTV";
            GenerateButtons();
        }

        private void btn_PB_Click(object sender, EventArgs e)
        {
            PNL_Scenario_Screen.Visible = true;
            PNL_Scenario_Screen.BringToFront();
            PNL_Study_Screen.Visible = false;

            opleiding = "PB";
            GenerateButtons();

        }

        private void btn_terug_Click(object sender, EventArgs e)
        {
            PNL_Scenario_Screen.Visible = false;
            PNL_Scenario_Screen.SendToBack();
            PNL_Start_Screen.Visible = true;

        }

        private void BTN_TestVar_Click(object sender, EventArgs e)
        {
           //MessageBox.Show(opleiding);
            SetGenData();
            
        }

        private void ReadingFile()
        {
            Console.WriteLine("0-fetching file...");
            string FileName = (@"C:\Users\joris\source\repos\OVD_VistaVirtuals\Scenario_data_SCV\Scenario_data.csv");

            Console.WriteLine("0-reading file...");
            CsvProcessorLib.CsvProcessor.FileName = FileName;
            datalist = CsvProcessorLib.CsvProcessor.ReadFile();
            MakeList();
        }

        private void MakeList()
        {
            List<List<string>> datalists = new List<List<string>>();
            int aantalelements2 = datalist.Length;
            genlist = aantalelements2;
            for (int i = 0; i < aantalelements2; i++)
            {
                List<string> splitlist2 = datalist[i].Split(',').ToList();
                datalists.Add(splitlist2);
            }
            //Console.WriteLine(aantalelements2);
            datalistdata = datalists;
            SetGenData();
        }

        private void SetGenData()
        {
            int j = 0;
            while (j < genlist)
            {
                
                    /*Console.WriteLine("------------------------");                   
                    Console.WriteLine(datalistdata[j][0]);
                    Console.WriteLine(datalistdata[j][1]);
                    Console.WriteLine("------------------------");*/
                if (datalistdata[j][1] == "PB")
                {
                    PB_Count++;
                Console.WriteLine("PB has been detected " + PB_Count + "amount of times!");
                }
                if (datalistdata[j][1] == "HTV")
                {
                    HTV_Count++;
                    Console.WriteLine("HTV has been detected " + HTV_Count + "amount of times!");
                }
                if (datalistdata[j][1] == "VEVA")
                {
                    VEVA_Count++;
                    Console.WriteLine("VEVA has been detected " + VEVA_Count + "amount of times!");
                }
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("PB has been counted " + PB_Count + " times!");
                Console.WriteLine("HTV has been counted " + HTV_Count + " times!");
                Console.WriteLine("VEVA has been counted " + VEVA_Count + " times!");
                j++;
                
            }
            

        }
        PictureBox[,] PictureBoxes = new PictureBox[10, 10];
        private void GenerateButtons()
        {
            opleiding = "HTV";
            //ammount of buttons per line
            int Pwidth = 4;
            //number of lines
            int Pheight = 1;
            switch (opleiding)
            {
                case "VEVA":
                    Pwidth = VEVA_Count;
                    break;
                case "HTV":
                    Pwidth = HTV_Count;
                    break;
                case "PB":
                    Pwidth = PB_Count;
                    break;
            }
            int num;
            for (int i = 0; i < Pwidth; i++)
            {
                num = i + 1;
                for (int j = 0; j < Pheight; j++)
                {
                    genid = genid + 1;

                    PictureBoxes[i,j] = new PictureBox();
                    PictureBoxes[i, j].Name = "block";
                    PictureBoxes[i, j].Size = new Size(60, 100);
                    PictureBoxes[i, j].BackColor = Color.Black;
                    PictureBoxes[i, j].BackgroundImageLayout = ImageLayout.Zoom;
                    PictureBoxes[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    PictureBoxes[i, j].Image = null;
                    PictureBoxes[i, j].Cursor = Cursors.Hand;
                    PictureBoxes[i, j].Location = new Point(i * 62, j * 62);
                    Console.WriteLine("|-block" + genid.ToString() + " has been generated");
                    //define button click event
                    PictureBoxes[i,j].Click += new EventHandler(activate_block);

                    //add button in to the panel
                    PNL_scenariobuttons.Controls.Add(PictureBoxes[i,j]);
                }
                Console.WriteLine("O- column" + num.ToString() + " has been completed");
            }
        }

        public void activate_block(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\joris\OneDrive\Documenten\TrashMasterz\demo V4\trash-Masterz.exe");
        }
    }
}

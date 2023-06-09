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

        public string[] datalist;
        int RowCount;

        public int ColumnCount = 1;

        public List<List<string>> datalistdata { get; set; }

        int genlist;
        int genid;

        public Admin()
        {
            InitializeComponent();
        }

        //   SqlConnection conn = new SqlConnection("server=localhost;database=ovd;uid=root;password=");

        private void Admin_Load(object sender, EventArgs e)
        {
            Reader();
            PNL_authorisation.BringToFront();
            PNL_authorisation.Visible = true;
            PNL_ScenarioOverVieuw.SendToBack();
            PNL_ScenarioOverVieuw.Visible = false;
        }

        private void PNL_ScenarioOverview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reader()
        {
            string FileName = (@"C:\Users\31614\source\repos\OVD_VistaVirtuals\Scenario_data.csv");
            CsvProcessorLib.CsvProcessor.FileName = FileName;
            datalist = CsvProcessorLib.CsvProcessor.ReadFile();
            makeList();
        }

        private void makeList()
        {
            List<List<string>> datalists = new List<List<string>>();
            int aantalelements = datalist.Length;
            genlist = aantalelements;
            for (int i = 0; i < aantalelements; i++)
            {
                List<string> splitlist = datalist[i].Split(',').ToList();
                datalists.Add(splitlist);
            }
            datalistdata = datalists;
            SetGenData();

            Console.WriteLine("List Complete");

            GenerateOverview();
        }

        private void SetGenData()
        {
            int j = 1;
            while (j < genlist)
            {
                RowCount = Int32.Parse(datalistdata[j][0]);
                j++;
            }
            //.Show(genlist.ToString());
        }

        Label[,] Labels = new Label[250, 250];
        private void GenerateOverview()
        {
            int width = 4;
            int height = RowCount;
            int num;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {

                    genid += 1;

                    Labels[i, j] = new Label();
                    Labels[i, j].Name = "Overzicht_Label" + datalistdata[0][ColumnCount];
                    Labels[i, j].Text = datalistdata[genid][ColumnCount];
                    Labels[i, j].Size = new Size(100, 50);
                    Labels[i, j].Location = new Point(i * 105, j * 55);

                    Console.WriteLine(genid);

                    PNL_Overview.Controls.Add(Labels[i, j]);

                    if (genid >= RowCount)
                    {
                        genid = 0;
                        ColumnCount += 1;
                    }
                }
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            String pass;
            pass = textBox1.Text;

            Console.WriteLine(pass);
            if (pass == "admin")
            {
                PNL_ScenarioOverVieuw.Visible = true;
                PNL_authorisation.SendToBack();
                PNL_authorisation.Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong password");
            }
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }
    }
}






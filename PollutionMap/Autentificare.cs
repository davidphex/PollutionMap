using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollutionMap
{
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
        }

        private void IncarcareDate()
        {
            string[] cuv = new string[10];
            string s;
            if (this.hartiTableAdapter.GetData().Rows.Count == 0)
            {
                StreamReader sr = new StreamReader("harti.txt");
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    cuv = s.Split('#');
                    this.hartiTableAdapter.InsertHarti(cuv[0], cuv[1]);
                }
                sr.Close();
            }
            if (this.masurareTableAdapter.GetData().Rows.Count == 0)
            {
                StreamReader sr = new StreamReader("masurari.txt");
                while (!sr.EndOfStream) { 
                    s = sr.ReadLine();
                    cuv = s.Split('#');
                    int id = 0;
                    switch(cuv[0])
                    {
                        case "Harta Bucuresti":
                            id = 1;
                            break;
                        case "Harta Cluj-Napoca":
                            id = 2;
                            break;
                        case "Harta Constanta":
                            id = 3;
                            break;
                        case "Harta Iasi":
                            id = 4;
                            break;
                        case "Harta Sibiu":
                            id = 5;
                            break;
                    }


                    this.masurareTableAdapter.InsertMasurare(
                        id,
                        Convert.ToInt32(cuv[1]),
                        Convert.ToInt32(cuv[2]),
                        float.Parse(cuv[3]),
                        DateTime.ParseExact(cuv[4],"dd/MM/yyyy HH:mm", null)
                    );
                }
                sr.Close();
            }
        }
        private void Autentificare_Load(object sender, EventArgs e)
        {
            IncarcareDate();
            // TODO: This line of code loads data into the 'poluareDataSet.Masurare' table. You can move, or remove it, as needed.
            this.masurareTableAdapter.Fill(this.poluareDataSet.Masurare);
            // TODO: This line of code loads data into the 'poluareDataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.poluareDataSet.Utilizatori);
            // TODO: This line of code loads data into the 'poluareDataSet.Harti' table. You can move, or remove it, as needed.
            this.hartiTableAdapter.Fill(this.poluareDataSet.Harti);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

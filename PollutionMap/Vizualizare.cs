using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollutionMap
{
    public partial class Vizualizare : Form
    {
        private string s = ""; //retine valoarea din alege harta
        private string s1 = ""; //retine valoarea din filtru
        private int idHarta=0,filtru = 0;
        private string path = "Harti//";

        private DateTime ds; //data din datetimepicker

    
        private Graphics g1 = null, g2 = null; //obiectele grafice pt desenare
        private int[] pozX = new int[100];// vector pt coord x ale punctelor
        private int[] pozY = new int[100]; // vector pt coord y ale punctelor
        private int n = 0; // nr de  puncte

        double[] vm = new double[100]; //valori masurate coresp. punctelor
             
        public Vizualizare()
        {
            InitializeComponent();
        }

        private void Vizualizare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poluareDataSet.Harti' table. You can move, or remove it, as needed.
            this.hartiTableAdapter.Fill(this.poluareDataSet.Harti);
            this.masurareTableAdapter.Fill(this.poluareDataSet.Masurare);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            ds = DateTime.Now;
            g1 = this.pictureBox1.CreateGraphics();

            AfisareHarta();

        }

        private void AfisareHarta()
        {
            switch (s)
            {
                case "Harta Bucuresti":
                    pictureBox1.Image = Image.FromFile(path+"harta_bucuresti.png");
                    idHarta = 1;
                    break;
                case "Harta Cluj-Napoca":
                    pictureBox1.Image = Image.FromFile(path+"harta_cluj.png");
                    idHarta = 2;
                    break;
                case "Harta Constanta":
                    pictureBox1.Image = Image.FromFile(path+"harta_constanta.png");
                    idHarta = 3;
                    break;
                case "Harta Iasi":
                    pictureBox1.Image = Image.FromFile(path+"harta_iasi.png");
                    idHarta = 4;
                    break;
                case "Harta Sibiu":
                    pictureBox1.Image = Image.FromFile(path+"harta_sibiu.png");
                    idHarta = 5;
                    break;
                case "":
                    pictureBox1.Image = Image.FromFile(path + "default_harta.png");
                    idHarta = 0;
                    break;
            }
        }

        private void desenare(Graphics g, Brush b, int px, int py, double valmas)
        {
            if((idHarta>=1&&idHarta<=5)&&(filtru >=1 && filtru <= 4))
            {
                Rectangle re;
                re = new Rectangle(px - 10, py - 10, 20, 20);
                g.FillEllipse(b, re);
                g.DrawString(
                    Convert.ToString(valmas),
                    new Font(new FontFamily("Arial"),12),
                    Brushes.Black,
                    px-10,
                    py-10
                );
            }
        }

        private void AfisareValori(Graphics g)
        {
            DateTime dm;
            int id = 0;
            if((idHarta>=1 && idHarta<=5)&&(filtru>=1 && filtru <= 4))
            {
                n = 0;
                foreach (DataRow r in poluareDataSet.Masurare)
                {
                    dm = Convert.ToDateTime(Convert.ToDateTime(r["DataMasurare"]));

                    id = Convert.ToInt32(r["IdHarta"]);
                    if (dm.Date == ds.Date && id == idHarta)
                    {
                        n++;
                        pozX[n] = Convert.ToInt32(r["PozitieX"]);
                        pozY[n] = Convert.ToInt32(r["PozitieY"]);
                        vm[n] = Convert.ToDouble(r["ValoareMasurare"]);

                        if (filtru <= 2 && vm[n] < 20)
                            desenare(g, Brushes.LightGreen, pozX[n], pozY[n], vm[n]);
                        else if ((filtru == 3 || filtru == 1) && (vm[n] >= 20 && vm[n] <= 40))
                            desenare(g, Brushes.Yellow, pozX[n], pozY[n], vm[n]);
                        else if ((filtru == 4 || filtru == 1) && vm[n] > 40)
                            desenare(g, Brushes.IndianRed, pozX[n], pozY[n], vm[n]);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperatiiAfisare();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filtru = 1;
            s1 = comboBox2.Text = "Niciun filtru";
            OperatiiAfisare();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ds = dateTimePicker1.Value;
            ds = Convert.ToDateTime(ds);
            OperatiiAfisare();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            s1 = comboBox2.Text;
            switch (s1)
            {
                case "Niciun filtru":
                    filtru = 1;
                    break;
                case @"Valoarea < 20":
                    filtru = 2;
                    break;
                case @"20 <= Valoarea <= 40":
                    filtru = 3;
                    break;
                case @"Valoarea > 40":
                    filtru = 4;
                    break;
            }
            OperatiiAfisare();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OperatiiAfisare()
        {
            AfisareHarta();
            if(idHarta>=1 && idHarta <= 5)
            {
                this.Refresh();
                AfisareValori(g1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = comboBox1.Text;
            filtru = 1;
            s1 = comboBox2.Text = "Niciun filtru";
            OperatiiAfisare();
            //AfisareHarta();
        }
    }
}

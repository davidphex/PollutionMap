using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

        private double[] vm = new double[100]; //valori masurate coresp. punctelor

        private int xc, yc, xmouse, ymouse; //coord punctului si coord mouseului

        private double valm; //valoarea care va fi inserata
        
        private double valpc=0,valmax1=0,valmax2=0; //valoarea punctului selectat, primele 2 valori maxime
        private int xmax1, ymax1, xmax2, ymax2; //coordonatele punctelor avand valoare maxima
        private double d1, d2, d3, lungimeTraseu = 0; // distantele intre punctul curent si punctele de valori maxime
        //si distanta intre cele doua maxime si la final in d1 si d2 vom retine distantele maxime
             
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
            g2 = this.pictureBox2.CreateGraphics();

            AfisareHarta(pictureBox1);
            AfisareHarta(pictureBox2);

        }

        private bool ExistaUnPunctPeHarta(int x, int y)
        {
            for (int i=1; i<=n; i++)
            {
                if (Math.Abs(x - pozX[i]) <= 20 && Math.Abs(y - pozY[i]) <= 20)
                {
                    xc = pozX[i];
                    yc = pozY[i];
                    valpc = vm[i];
                    return true;
                }
            }
            return false;
        }

        private void DesenareLinie(int x1, int y1, int x2, int y2)
        {
            g2.DrawLine(new Pen(Color.Red, 3), x1, y1, x2, y2);
        }

        private void DeterminareDistante()
        {
            d1 = Math.Sqrt(Math.Pow(xc - xmax1, 2) + Math.Pow(yc - ymax1, 2));
            d2 = Math.Sqrt(Math.Pow(xc - xmax2, 2) + Math.Pow(yc - ymax2, 2));
            d3 = Math.Sqrt(Math.Pow(xmax1 - xmax2, 2) + Math.Pow(ymax1 - ymax2, 2));

            if(d1<=d3 && d2 <= d3)
            {
                lungimeTraseu = d1 + d2;
                DesenareLinie(xmax1, ymax1, xc, yc);
                DesenareLinie(xc, yc, xmax2, ymax2);
                MessageBox.Show(
                    "(" + Convert.ToString(xmax1) + "," + Convert.ToString(ymax1) + ")\n" +
                    "(" + Convert.ToString(xc) + "," + Convert.ToString(yc) + ")\n" +
                    "(" + Convert.ToString(xmax2) + "," + Convert.ToString(ymax2) + ")\n" +
                    "Lungimea traseului minim este:" + 
                        Convert.ToString(d1)+ "+" +Convert.ToString(d2)+ "=" +Convert.ToString(lungimeTraseu)
                );
            } else if(d1<=d2 && d3<=d2)
            {
                lungimeTraseu = d1 + d3;
                DesenareLinie(xc, yc, xmax1, ymax1);
                DesenareLinie(xmax1, ymax1, xmax2, ymax2);

                MessageBox.Show(
                    "(" + Convert.ToString(xc) + "," + Convert.ToString(yc) + ")\n" +
                    "(" + Convert.ToString(xmax1) + "," + Convert.ToString(ymax1) + ")\n" +
                    "(" + Convert.ToString(xmax2) + "," + Convert.ToString(ymax2) + ")\n" +
                    "Lungimea traseului minim este:" +
                        Convert.ToString(d1) + "+" + Convert.ToString(d3) + "=" + Convert.ToString(lungimeTraseu)
                );
            } else if(d2<=d1 && d3 <= d1)
            {
                lungimeTraseu = d2 + d3;
                DesenareLinie(xc, yc, xmax2, ymax2);
                DesenareLinie(xmax2, ymax2, xmax1, xmax2);
                MessageBox.Show(
                    "(" + Convert.ToString(xc) + "," + Convert.ToString(yc) + ")\n" +
                    "(" + Convert.ToString(xmax1) + "," + Convert.ToString(ymax1) + ")\n" +
                    "(" + Convert.ToString(xmax2) + "," + Convert.ToString(ymax2) + ")\n" +
                    "Lungimea traseului minim este:" +
                        Convert.ToString(d2) + "+" + Convert.ToString(d3) + "=" + Convert.ToString(lungimeTraseu)
                );
            }
        }

        private void AfisareHarta(PictureBox pictureBox)
        {
            switch (s)
            {
                case "Harta Bucuresti":
                    pictureBox.Image = Image.FromFile(path+"harta_bucuresti.png");
                    idHarta = 1;
                    break;
                case "Harta Cluj-Napoca":
                    pictureBox.Image = Image.FromFile(path+"harta_cluj.png");
                    idHarta = 2;
                    break;
                case "Harta Constanta":
                    pictureBox.Image = Image.FromFile(path+"harta_constanta.png");
                    idHarta = 3;
                    break;
                case "Harta Iasi":
                    pictureBox.Image = Image.FromFile(path+"harta_iasi.png");
                    idHarta = 4;
                    break;
                case "Harta Sibiu":
                    pictureBox.Image = Image.FromFile(path+"harta_sibiu.png");
                    idHarta = 5;
                    break;
                case "":
                    pictureBox.Image = Image.FromFile(path + "default_harta.png");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            xmouse = e.X;
            ymouse = e.Y;

            if (ExistaUnPunctPeHarta(xmouse, ymouse) == true)
            {
                if (valpc <= 40)
                {
                    MessageBox.Show(
                        "Selectati un punct de pe harta corespunzator \n" +
                        "unei masuri existente in baza de date!(valoare > 40)"
                    );
                }
                else
                {
                    DeterminareDistante();
                }
            }
            else MessageBox.Show("Selectati un punct de pe harta!");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                AfisareHarta(pictureBox2);
                if(idHarta>=1 && idHarta <= 5)
                {
                    MessageBox.Show("Se incarca valorile din pagina VeziHarta");
                    AfisareValori(g2);

                } else
                {
                    MessageBox.Show("Harta din pagina VeziHarta nu a fost incarcata");
                }
            } else
            {
                OperatiiAfisare();
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


                        if (vm[n] >= valmax1)
                        {
                            valmax2 = valmax1;
                            xmax2 = xmax1;
                            ymax2 = ymax1;

                            valmax1 = vm[n];
                            xmax1 = pozX[n];
                            ymax1 = pozY[n];
                        } else if (vm[n] > valmax2) {
                            valmax2 = vm[n];
                            xmax2 = pozX[n];
                            ymax2 = pozY[n];
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperatiiAfisare();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            xmouse = e.X;
            ymouse = e.Y;
            if (ExistaUnPunctPeHarta(xmouse, ymouse) == true)
                MessageBox.Show("Punctul exista pe harta! Alege un alt punct pentru a fi adaugat pe harta!");
            else
            {
                AdaugaMasurare f4 = new AdaugaMasurare();
                f4.ShowDialog();
                valm = f4.ValoareMasurare;

                MessageBox.Show(Convert.ToString("Se pune punctul avand valoarea: ") + valm);
                Brush b;
                if (valm < 20) b = Brushes.LightGreen;
                else if (valm <= 40) b = Brushes.Yellow;
                else b = Brushes.IndianRed;
                desenare(g1, b, xmouse, ymouse, valm);
                this.masurareTableAdapter.InsertMasurare(
                    idHarta, 
                    xmouse, 
                    ymouse, 
                    (float)valm, 
                    Convert.ToDateTime(dateTimePicker1.Text)
                );

                this.masurareTableAdapter.Fill(this.poluareDataSet.Masurare);
                this.masurareTableAdapter.Update(this.poluareDataSet.Masurare);

            }
        }

        private void Vizualizare_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Traseu_Click(object sender, EventArgs e)
        {

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
            AfisareHarta(pictureBox1);
            AfisareHarta(pictureBox2);
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

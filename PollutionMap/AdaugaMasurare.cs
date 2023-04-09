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
    public partial class AdaugaMasurare : Form
    {

        public double ValoareMasurare;
        public AdaugaMasurare()
        {
            InitializeComponent();
        }

        private void AdaugaMasurare_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&& double.TryParse(textBox1.Text, out double result)){
                ValoareMasurare = Convert.ToDouble(textBox1.Text);
                if (ValoareMasurare <= 0) return;
                this.Close();
            } else
            {
                MessageBox.Show("Valoare incorecta!");
                textBox1.Clear();
            }
        }
    }
}

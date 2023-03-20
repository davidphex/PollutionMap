using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollutionMap
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }

        private bool IsValid(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            } catch (FormatException)
            {
                return false;
            }
        }

        public void adaugaUtilizator()
        {
            this.utilizatoriTableAdapter.InsertUtilizatori(
                textBox1.Text,
                textBox2.Text,
                textBox4.Text,
                DateTime.Now
            );

            this.Validate();
            this.utilizatoriBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(poluareDataSet);
            MessageBox.Show("Utilizatorul a fost adaugat cu succes!");
        }

        private void inapoiLaLogin()
        {
            Autentificare form = new Autentificare();
            form.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 4)
            {
                MessageBox.Show("Numele de utilizator trebuie sa aiba cel putin 4 caractere!");
                return;
            }
            if (textBox2.Text.Length < 6)
            {
                MessageBox.Show("Parola trebuie sa aiba cel putin 6 caractere!");
                return;
            }
            if (textBox3.Text.Trim() != textBox2.Text.Trim())
            {
                MessageBox.Show("Cele doua parole trebuie sa coincida");
                return;
            }
            if (!IsValid(textBox4.Text))
            {
                MessageBox.Show("Adresa de mail incorecta!");
                return;
            }

            foreach (DataRowView row in utilizatoriBindingSource.List)
            {
                string nume = (string)row["NumeUtilizator"];
                if (nume.ToString().Trim() == textBox1.Text.Trim())
                {
                    MessageBox.Show("Utilizatorul exista! Alege alt nume!");
                    return;
                }
            }

            adaugaUtilizator();
            inapoiLaLogin();
        }

        private void Inregistrare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poluareDataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.poluareDataSet.Utilizatori);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inapoiLaLogin();
        }
    }
}

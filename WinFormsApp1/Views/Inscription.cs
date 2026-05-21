using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Modele;

namespace WinFormsApp1
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSinscrire_Click(object sender, EventArgs e)
        {
            string Nom = TxtboxNomIn.Text;
            string Prenom = TxtBoxPrenomIn.Text;
            string NumRpps = TxtBoxRpps.Text;
            string Email = TxtBoxEmail.Text;
            string MotDePasseIn = TxtBoxMdpIn.Text;
            string ConfirmationMotDePasse = TxtBoxConfirmdp.Text;
            string Specialite = TxtBoxSpe.Text;
            DateTime dateNais = dtpDateNaissance.Value;

            Medecin m1 = new Medecin(NumRpps, Prenom, Email, MotDePasseIn, ConfirmationMotDePasse,Specialite, dateNais);
            MessageBox.Show(m1.numeroRpps);

            Form Cconnex = new Connection();
            Cconnex.Show();
            this.Hide();
        }

    }
}

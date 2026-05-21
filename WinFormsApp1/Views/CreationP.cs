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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CreerPatient_Click(object sender, EventArgs e)
        {
            string Nom = TxtBoxNom.Text;
            string Prenom = TxtBoxPrenom.Text;
            DateTime Datedenaissance= DateDeNaissance.Value;
            float Poids = (float)NumPoids.Value;
            float Taille = (float)NumTaille.Value;
            string Sexe = comboBoxSexe.Text;
            string Pathologies = TxtBoxPatho.Text;
            string NumeroSecu = TxtBoxNSecu.Text;
            //MessageBox.Show("Nom :" + " " + Nom + " " + "Prenom :" + " " + Prenom + "Date de naissance: " + " " + "etc" );

            Person p1 = new Person(TxtBoxNom.Text, TxtBoxPrenom.Text, DateDeNaissance.Value);
            MessageBox.Show(p1.Prenom);

            Form RetourPageMedecin = new Page_Medecin();
            RetourPageMedecin.Show();
            this.Hide();
        }
        //        string lastname = this.tesxtbox1.text;
        //string name = this.tesxtbox2.text;
        //string birthday = this.tesxtbox3.text;
        private void DateDeNaissance_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

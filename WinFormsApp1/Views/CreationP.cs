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
            // 1. On vérifie d'abord que les champs obligatoires ne sont pas vides
            if (string.IsNullOrWhiteSpace(TxtBoxNom.Text) || string.IsNullOrWhiteSpace(TxtBoxPrenom.Text))
            {
                MessageBox.Show("Le nom et le prénom sont obligatoires pour enregistrer un patient.",
                                "Saisie incomplète", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Traduction du Sexe en booléen pour ta classe Patient
            // Si la ComboBox dit "Masculin" ou "Homme", sexeBool sera 'true', sinon 'false'
            bool sexeBool = (comboBoxSexe.Text == "Masculin" || comboBoxSexe.Text == "Homme");

            // 3. On crée un véritable objet Patient avec toutes les informations saisies
            // (On convertit les valeurs des NumericUpDown (decimal) en int)
            Patient nouveauPatient = new Patient(
                (int)NumPoids.Value,
                (int)NumTaille.Value,
                TxtBoxPatho.Text,
                TxtBoxNSecu.Text,
                sexeBool,
                TxtBoxNom.Text,
                TxtBoxPrenom.Text,
                DateDeNaissance.Value
            );

            // 4. On appelle le contrôleur pour l'envoyer dans la base de données Docker
            WinFormsApp1.Controlleurs.PatientController controller = new WinFormsApp1.Controlleurs.PatientController();
            bool estEnregistre = controller.CreerPatient(nouveauPatient);

            // 5. Si la base de données a accepté l'insertion
            if (estEnregistre)
            {
                MessageBox.Show($"Le patient {nouveauPatient.Prenom} {nouveauPatient.Nom} a bien été sauvegardé !",
                                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // On ferme ce formulaire de création. 
                // Le médecin se retrouve automatiquement sur la page d'accueil qui était restée ouverte derrière.
                this.Close();
            }
        }
        //        string lastname = this.tesxtbox1.text;
        //string name = this.tesxtbox2.text;
        //string birthday = this.tesxtbox3.text;
        private void DateDeNaissance_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

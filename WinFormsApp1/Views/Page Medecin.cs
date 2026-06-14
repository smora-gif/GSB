using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controlleurs;
using WinFormsApp1.Modele;
using WinFormsApp1.Views;
namespace WinFormsApp1
{
    public partial class Page_Medecin : Form
    {
        private Patient _patientEnCours;
        private PatientController _patientController = new PatientController();
        public Page_Medecin()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        // Clic sur "Nouveau Patient"
        private void button1_Click(object sender, EventArgs e)
        {
            Form cCreationPatientForm = new Form2();
            cCreationPatientForm.Show();
        }
        // Clic sur "Liste des Patients"
        private void button3_Click(object sender, EventArgs e)
        {
            Form cListePatientsForm = new PatientListForm(this);
            cListePatientsForm.Show();
        }
        // Appelée depuis la liste pour auto-remplir l'écran
        public void RemplirChamps(Patient p)
        {
            if (p == null) return;
            // On garde la référence du patient entier
            this._patientEnCours = p;
            // Remplissage des champs de l'interface
            txtNom.Text = p.Nom;
            txtPrenom.Text = p.Prenom;
            txtSecu.Text = p.numSecu;
            txtPoids.Text = p.poids.ToString();
            txtTaille.Text = p.taille.ToString();
            txtPatho.Text = p.patho;
            dateNaissance.Value = p.DateNaissance;
            comboBoxSexe.Text = p.sex ? "Masculin" : "Féminin";
        }
        // LA MÉTHODE UNIQUE DU BOUTON MODIFIER (Liée au clic dans l'interface)
        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            // 1. SÉCURITÉ : On vérifie TOUT D'ABORD qu'un patient est chargé à l'écran
            if (_patientEnCours == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un patient à modifier via la liste.",
                                "Aucun patient sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 2. On récupère les valeurs textuelles de l'interface
            _patientEnCours.Nom = txtNom.Text.Trim();
            _patientEnCours.Prenom = txtPrenom.Text.Trim();
            _patientEnCours.numSecu = txtSecu.Text.Trim();
            _patientEnCours.patho = txtPatho.Text.Trim();
            // 3. Conversion sécurisée des données numériques
            if (int.TryParse(txtPoids.Text, out int poidsResult)) _patientEnCours.poids = poidsResult;
            if (int.TryParse(txtTaille.Text, out int tailleResult)) _patientEnCours.taille = tailleResult;
            // 4. Récupération des contrôles spécifiques (Date et Sexe)
            _patientEnCours.DateNaissance = dateNaissance.Value;
            _patientEnCours.sex = (comboBoxSexe.Text == "Masculin" || comboBoxSexe.Text == "Homme");
            // 5. Appel au contrôleur pour enregistrer dans MySQL
            bool succes = _patientController.ModifierPatient(_patientEnCours);
            if (succes)
            {
                MessageBox.Show($"Les modifications pour le patient {_patientEnCours.Prenom} {_patientEnCours.Nom} ont été enregistrées avec succès en base de données !",
                                "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnOrdonnaces_Click(object sender, EventArgs e)
        {
            Form cPage_Ordonnances = new Creation_ordonnance();
            cPage_Ordonnances.Show();
            this.Hide();
        }
    }
}
using System;
using System.Windows.Forms;
using WinFormsApp1.Modele;

namespace WinFormsApp1
{
    public partial class Connection : Form
    {
        // On déclare notre couche d'accès aux données
        private MedecinRepository _medecinRepository;

        public Connection()
        {
            InitializeComponent();
            // On l'initialise au chargement du formulaire
            _medecinRepository = new MedecinRepository();
        }

        private void btnConnection_Click(object sender, EventArgs e) //boutton connection
        {
            string Username = txtboxUtilisateur.Text.Trim();
            string Password = txtboxMdp.Text;

            // Validation de base
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs obligatoires", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Appel de la couche d'accès aux données
                Medecin medecinConnecte = _medecinRepository.Connexion(Username, Password);

                if (medecinConnecte != null)
                {
                    MessageBox.Show($"Bienvenue Docteur {medecinConnecte.Prenom} !", "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirection vers Page_Medecin 
                    Form cPageMedecinForm = new Page_Medecin();
                    cPageMedecinForm.Show();

                    // On cache la page de connexion
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Identifiants incorrects. Veuillez réessayer.", "Échec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur Système", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkInscription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form cinscriptionForm = new Inscription();
            cinscriptionForm.Show();
            this.Hide();
        }
    }
}
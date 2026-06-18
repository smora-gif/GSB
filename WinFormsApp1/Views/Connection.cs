using System;
using System.Windows.Forms;
using WinFormsApp1.Modele;
using WinFormsApp1.Controlleurs;

namespace WinFormsApp1
{
    public partial class Connection : Form
    {
        private MedecinController _medecinController;
        public Connection()
        {
            InitializeComponent();
            _medecinController = new MedecinController();
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
                // Appel de la couche d'accÃ¨s aux donnÃ©es
                Medecin medecinConnecte = _medecinController.Connexion(Username, Password);
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
                    MessageBox.Show("Identifiants incorrects. Veuillez réessayer.", "échec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void Connection_Load(object sender, EventArgs e)
        {
        }
        private void btnAfficherMdp_Click(object sender, EventArgs e)
        {
            // âš ï¸ Remplace 'txtPassword' par le vrai nom de ta TextBox de mot de passe !
            // Si le mot de passe est actuellement masquÃ© par une Ã©toile
            if (txtboxMdp.PasswordChar == '*')
            {
                // On enlÃ¨ve le masque (la valeur '\0' signifie aucun caractÃ¨re de masquage)
                txtboxMdp.PasswordChar = '\0';
                // Optionnel : On change l'icÃ´ne du bouton pour montrer qu'on peut refermer l'Å“il
                btnAfficherMdp.Text = "ðŸ™ˆ";
            }
            else
            {
                // Sinon, c'est qu'il Ã©tait visible, donc on le masque Ã  nouveau avec l'Ã©toile
                txtboxMdp.PasswordChar = '*';
                // On remet l'Å“il normal
                btnAfficherMdp.Text = "ðŸ‘";
            }
        }
    }
}
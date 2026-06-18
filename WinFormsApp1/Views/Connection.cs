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
                // Appel de la couche d'accés aux données
                Medecin medecinConnecte = _medecinController.Connexion(Username, Password);
                if (medecinConnecte != null)
                {
                    MessageBox.Show($"Bienvenue Docteur {medecinConnecte.Prenom} !", "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Redirection vers Page_Medecin
                    Form cPageMedecinForm = new Page_Medecin();
                    cPageMedecinForm.Show();
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
            //Nous avons configuré par default en passCharacter l'*
            if (txtboxMdp.PasswordChar == '*')
            {
                //Si oui on dessactive le mascage
                txtboxMdp.PasswordChar = '\0';
                //On change l'îcone quand on clique
                btnAfficherMdp.Text = "ðŸ™ˆ";
            }
            else
            {
                // Si condition fausse on remet le mascage pour sécurité
                txtboxMdp.PasswordChar = '*';
                // On remet l'oeil normal
                btnAfficherMdp.Text = "🙈‘";
            }
        }
    }
}
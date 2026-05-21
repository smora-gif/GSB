namespace WinFormsApp1
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            string Username = txtboxUtilisateur.Text;
            string Password = txtboxMdp.Text;
            MessageBox.Show("User :" + Username + " " + "PassWord :" + " " + Password);

            Form cPageMedecinForm = new Page_Medecin();
            cPageMedecinForm.Show();
        }

        private void linkInscription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form cinscriptionForm = new Inscription();
            cinscriptionForm.Show();
            this.Hide();
        }
    }
}

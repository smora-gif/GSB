using MySql.Data.MySqlClient;
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

namespace WinFormsApp1.Views
{
    public partial class PatientDetailForm : Form
    {
        public PatientDetailForm()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Patient _patient;
        private readonly PatientController _controller;
        // Le constructeur prend l'ID du patient à afficher.
        // C'est la méthode classique pour passer un paramètre
        // à un formulaire WinForms.
        public PatientDetailForm(Patient p)
        {
            InitializeComponent();
            this._patient = p;
            _controller = new PatientController();
        }


        private void ChargerHistorique()
        {
            var historique = _controller.ObtenirHistorique(_patient.Id);
            dgvHistorique.DataSource = historique;
            PersonnaliserColonnesHistorique();
        }

        private void ChargerAllergies ()
        {
            var ChargerAllergies =_controller.ObtenirAllergie(_patient.Id);
            lstAllergies.DataSource = ChargerAllergies;
        }
        private void PersonnaliserColonnesHistorique()
        {
            if (dgvHistorique.Columns.Count == 0) return;
            dgvHistorique.Columns["Id"].Visible = false;
            dgvHistorique.Columns["DateEmission"].HeaderText = "Date";
            dgvHistorique.Columns["DateEmission"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvHistorique.Columns["MedecinNom"].HeaderText = "Médecin";
            dgvHistorique.Columns["MedecinSpecialite"].HeaderText = "Spécialité";
            dgvHistorique.ReadOnly = true;
            dgvHistorique.AllowUserToAddRows = false;
            dgvHistorique.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        private void PatientDetailForm_Load(object sender, EventArgs e)
        {
            this.txtName.Text = this._patient.Nom;
            this.txtDetailPrenom.Text = this._patient.Prenom;
            this.txtDetailAge.Text = this._patient.CalculerAge() + " ans";
            this.txtDetailNumSecu.Text = this._patient.numSecu.ToString();
            this.TxtDetailNee.Text = this._patient.DateNaissance.ToString();
            lstAllergies.DataSource = _patient.Allergies;
            ChargerAllergies();

        }
    }
}

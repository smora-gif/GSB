using WinFormsApp1.Controlleurs;
using WinFormsApp1.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1.Views
{
    public partial class PatientListForm : Form
    {
        private readonly PatientController _controller;

        public PatientListForm()
        {
            InitializeComponent();
            _controller = new PatientController();
        }

        // Événement au chargement du formulaire
        private void PatientListForm_Load(object sender, EventArgs e)
        {
            // Applique les configurations globales du DataGridView une seule fois
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPatients.ReadOnly = true;
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            RafraichirListe();
        }

        // Clic sur le bouton Rechercher
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            RafraichirListe();
        }

        // Clic sur le bouton Annuler/Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRecherche.Clear(); // Vide la zone de texte de recherche
            RafraichirListe();
        }

        // --------------------------------------------------------------------
        // Méthode centrale : recharge le tableau selon la zone de recherche.
        // --------------------------------------------------------------------
        private void RafraichirListe()
        {
            try
            {
                string motCle = txtRecherche.Text.Trim();

                // Si le champ est vide -> Tous les patients, sinon -> Recherche
                List<Patient> patients = string.IsNullOrEmpty(motCle)
                    ? _controller.ObtenirTousLesPatients()
                    : _controller.RechercherParNom(motCle);

                AfficherPatients(patients);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "test Erreur base de données :\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Injecte la liste dans le DataGridView et lance la mise en forme
        private void AfficherPatients(List<Patient> patients)
        {
            dgvPatients.DataSource = null; // Force la réinitialisation du lien
            dgvPatients.DataSource = patients;

            PersonnaliserColonnes();

            // Met à jour le label du compteur si tu l'as ajouté sur le design
            if (lblNbPatients != null)
                lblNbPatients.Text = patients.Count + " patient(s)";
        }

        // Gère les en-têtes et la visibilité des colonnes
        private void PersonnaliserColonnes()
        {
            if (dgvPatients.Columns.Count == 0) return;

            // Configuration de la colonne ID
            if (dgvPatients.Columns.Contains("Id"))
            {
                dgvPatients.Columns["Id"].HeaderText = "N°";
                dgvPatients.Columns["Id"].Width = 50;
            }

            if (dgvPatients.Columns.Contains("Nom"))
                dgvPatients.Columns["Nom"].HeaderText = "Nom";

            if (dgvPatients.Columns.Contains("Prenom"))
                dgvPatients.Columns["Prenom"].HeaderText = "Prénom";

            if (dgvPatients.Columns.Contains("DateNaissance"))
            {
                dgvPatients.Columns["DateNaissance"].HeaderText = "Date de naissance";
                dgvPatients.Columns["DateNaissance"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvPatients.Columns.Contains("NumeroSecu"))
                dgvPatients.Columns["NumeroSecu"].HeaderText = "N° Sécurité sociale";

            // Masquer les colonnes inutiles de la table
            foreach (var col in new[] { "Patho", "Poids", "Taille", "Sex", "Allergies" })
            {
                if (dgvPatients.Columns.Contains(col))
                    dgvPatients.Columns[col].Visible = false;
            }
        }
        private void dgvPatients_CellDoubleClick(object sender,
                                         DataGridViewCellEventArgs e)
        {
            // Ignorer les clics sur l'en-tête de colonne
            if (e.RowIndex < 0) return;
            // Récupérer l'objet Patient lié à la ligne cliquée.
            // DataBoundItem contient l'objet de la liste DataSource
            // qui correspond à cette ligne.
            Patient p = (Patient)dgvPatients.Rows[e.RowIndex].DataBoundItem;
            MessageBox.Show("test listform" + p.Nom);
            // Ouvrir le formulaire de détail en mode "modal" :
            // ShowDialog() bloque la fenêtre parente jusqu'à fermeture.
            PatientDetailForm fiche = new PatientDetailForm(p);
            fiche.ShowDialog(this);
            // (optionnel) Si le détail modifie le patient, on rafraîchit :
            // RafraichirListe();
        }

        private void btnRechercher_Click_1(object sender, EventArgs e)
        {
            RafraichirListe();
        }

    }
}
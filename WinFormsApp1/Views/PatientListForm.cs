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
        private readonly Page_Medecin _pageMedecinActive;
        public Patient PatientSelectionne { get; private set; }

        public PatientListForm(Page_Medecin pageMedecinActive)
        {
            InitializeComponent();
            _controller = new PatientController();
            _pageMedecinActive = pageMedecinActive;
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

                // Configuration des en-têtes (Textes affichés)
                if (dgvPatients.Columns.Contains("Id")) dgvPatients.Columns["Id"].HeaderText = "N°";
                if (dgvPatients.Columns.Contains("NumeroSecu")) dgvPatients.Columns["NumeroSecu"].HeaderText = "N° Sécurité sociale";
                if (dgvPatients.Columns.Contains("Nom")) dgvPatients.Columns["Nom"].HeaderText = "Nom";
                if (dgvPatients.Columns.Contains("Prenom")) dgvPatients.Columns["Prenom"].HeaderText = "Prénom";

                // FORCE LE LIEN AVEC LES PROPRIÉTÉS DE LA CLASSE PATIENT
                // Si la colonne s'appelle "Nom", elle doit afficher la propriété "Nom" de ton code C#
                if (dgvPatients.Columns.Contains("Nom")) dgvPatients.Columns["Nom"].DataPropertyName = "Nom";
                if (dgvPatients.Columns.Contains("Prenom")) dgvPatients.Columns["Prenom"].DataPropertyName = "Prenom";

                // Ordre d'affichage visuel
                if (dgvPatients.Columns.Contains("Id")) dgvPatients.Columns["Id"].DisplayIndex = 0;
                if (dgvPatients.Columns.Contains("NumeroSecu")) dgvPatients.Columns["NumeroSecu"].DisplayIndex = 1;
                if (dgvPatients.Columns.Contains("Nom")) dgvPatients.Columns["Nom"].DisplayIndex = 2;
                if (dgvPatients.Columns.Contains("Prenom")) dgvPatients.Columns["Prenom"].DisplayIndex = 3;
                if (dgvPatients.Columns.Contains("DateNaissance")) dgvPatients.Columns["DateNaissance"].DisplayIndex = 4;

                // Masquer les colonnes inutiles
                foreach (var col in new[] { "Patho", "Poids", "Taille", "Sex", "Allergies" })
                {
                    if (dgvPatients.Columns.Contains(col))
                        dgvPatients.Columns[col].Visible = false;
                }
            }
        private void dgvPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorer les clics sur l'en-tête de colonne
            if (e.RowIndex < 0) return;

            // Récupérer l'objet Patient lié à la ligne cliquée
            Patient p = (Patient)dgvPatients.Rows[e.RowIndex].DataBoundItem;

            // Poser la question au médecin avec des boutons Oui / Non / Annuler
            DialogResult choix = MessageBox.Show(
                $"Que voulez-vous faire avec le patient {p.Prenom} {p.Nom} ?\n\n" +
                "• [ OUI ] : Remplir la page Médecin avec ses informations.\n" +
                "• [ NON ] : Ouvrir sa fiche (Allergies, Historique...).\n" +
                "• [ ANNULER ] : Revenir à la liste.",
                "Choix de l'action",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (choix == DialogResult.Yes)
            {
                // CAS 1 : On remplit DIRECTEMENT la page médecin qui est affichée à l'écran !
                if (_pageMedecinActive != null)
                {
                    _pageMedecinActive.RemplirChamps(p);
                }

                this.Close(); // On ferme la liste
            }
            else if (choix == DialogResult.No)
            {
                // CAS 2 : Ouvrir uniquement la fiche de détails (Allergies)
                PatientDetailForm fiche = new PatientDetailForm(p);
                fiche.ShowDialog(this);
                // Une fois la fiche fermée, le médecin se retrouve à nouveau sur la liste
            }
            // Si choix == Cancel, il ne se passe rien (la boîte se ferme et la liste reste ouverte)
        }

        private void btnRechercher_Click_1(object sender, EventArgs e)
        {
            RafraichirListe();
        }

    }
}
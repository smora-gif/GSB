using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controlleurs;
using WinFormsApp1.Modele;
namespace WinFormsApp1
{
    public partial class Creation_ordonnance : Form
    {
        private readonly MedicamentController _medicamentController = new MedicamentController();
        private List<Medicament> _medicaments = new List<Medicament>();
        public Creation_ordonnance()
        {
            InitializeComponent();
        }
        private void Creation_ordonnance_Load(object sender, EventArgs e)
        {
            ChargerMedicaments();
        }
        private void ChargerMedicaments()
        {
            try
            {
                _medicaments = _medicamentController.ObtenirTousLesMedicaments();
                ComBoxMedicament.DataSource = null;
                ComBoxMedicament.DataSource = _medicaments;
                ComBoxMedicament.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des médicaments : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (ComBoxMedicament.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un médicament.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nomMedicament = ComBoxMedicament.Text;
            string dose = ListDose.Value + " " + comboBoxUnitDose.Text;
            string frequence = TxtBoxFrequence.Text;
            string limite = DateLimConsomation.Value.ToShortDateString();
            TabMeds.Rows.Add(nomMedicament, dose, frequence, limite);
        }
        private void ComBoxMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComBoxMedicament.SelectedItem is Medicament med)
            {
                string dosage = med.Dosage;
                Match match = Regex.Match(dosage, @"^[\d\.]+(.+)$");
                if (match.Success)
                {
                    comboBoxUnitDose.Text = match.Groups[1].Value;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (TabMeds.SelectedRows.Count > 0)
            {
                TabMeds.Rows.Remove(TabMeds.SelectedRows[0]);
            }
            else if (TabMeds.CurrentRow != null && !TabMeds.CurrentRow.IsNewRow)
            {
                TabMeds.Rows.Remove(TabMeds.CurrentRow);
            }
        }
    }
}
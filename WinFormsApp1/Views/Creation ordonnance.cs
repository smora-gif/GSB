using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Creation_ordonnance : Form
    {
        public Creation_ordonnance()
        {
            InitializeComponent();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            string Medicament = ComBoxMedicament.Text;
            float Dose = Convert.ToSingle(ListDose.Value);
            string UnitDose = comboBoxUnitDose.Text;
            DateTime DateLimiteConso = DateLimConsomation.Value;
            string Frequence = TxtBoxFrequence.Text;



        }
    }
}

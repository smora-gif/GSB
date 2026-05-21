using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Modele
{
    internal class Prescription
    {
        public List<Medicament> Medicaments { get; set; }
        private string Posologie {  get; set; }
        private int Durée { get; set; }

        public Prescription(string Posologie, int Durée, string name, float dosage, int unite)
        { 
            Medicaments = new List<Medicament>();
            this.Posologie = Posologie;
            this.Durée = Durée;
        }

    }
}

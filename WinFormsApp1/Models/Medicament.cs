using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Modele
{
    internal class Medicament
    {
        private string name;
        private int Dosage;
        private int unite;

        public string GetName() { return name; }
        public int GetDosage() { return Dosage; }
        public int GetUnite() { return unite; }
        public void SetName(string name) { this.name = name; }
        public void SetDosage(int dosage) { this.Dosage = dosage; }
        public void SetUnite(int unite) { this.unite = unite; }

        public Medicament (string name, int dosage, int unite)
        {
            this.name = name;
            Dosage = dosage;
            this.unite = unite;
        }
    }
}

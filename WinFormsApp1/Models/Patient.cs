using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Modele
{
    public class Patient : Person
    {
        public int Id {  get; set; }
        public int poids { get; set; }
        public int taille { get; set; }
        public string patho { get; set; } = string.Empty;
        public string numSecu { get; set; } = string.Empty;
        public bool sex { get; set; }
        public List<Allergie> Allergies { get; set; }

        public Patient(int poids, int taille, string Patho, string NumSecu, bool Sex, string prenom, string nom, DateTime DateNaissance) :base (nom, prenom, DateNaissance)
            { 
            this.poids = poids;
            this.taille = taille;
            this.patho = Patho;
            this.numSecu = NumSecu;
            this.sex = Sex;
        }
        public Patient()
        {
        }

    }
}

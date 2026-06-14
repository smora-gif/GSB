using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Modele
{
    public class Person
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public Person() { }
        public Person(string nom, string prenom, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }
        public int CalculerAge()
        {
            // On récupère la date du jour
            DateTime aujourdhui = DateTime.Today;
            // On calcule la différence d'années (Attention : vérifiez si votre propriété
            // héritée de Person s'appelle 'birthdate', 'DateNaissance' ou 'dateNaiss')
            int age = aujourdhui.Year - this.DateNaissance.Year;
            // Si l'anniversaire n'est pas encore passé cette année, on retire 1 an
            if (this.DateNaissance.Date > aujourdhui.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
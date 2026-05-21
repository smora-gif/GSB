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
/*   public class Person
   {
       public string name;
       public DateTime birthday;
       public string firtsname;

       public string? Name { get; internal set; }

       public string getFirstname() { return firtsname; }
       public string getLastname() { return name; }
       public DateTime getBirthday() { return birthday; }

       public void setFirtsname(string newFirtsname) { this.firtsname = newFirtsname; }
       public void setBirthday(DateTime newBirthday) { this.birthday = newBirthday; }
       public void setName(string newName) { this.name = newName; }

       public Person() { }

       public Person(string newName, string firstname, DateTime birthday) {
           this.name = newName;
           this.firtsname= firstname;
           this.birthday = birthday;




       }

   }
}
*/
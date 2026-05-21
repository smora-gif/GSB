using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Modele
{
    public class Medecin : Person
    {

        public string numeroRpps { get; set; }
        private string specialite {  get; set; }
        private string email { get; set; }
        private string password { get; set; }
        public Medecin(string NumeroRpps, string Specialite, string Email, string Password, string name, string firstname, DateTime birthday) : base(name, firstname, birthday)
        {
            this.numeroRpps = NumeroRpps;
            this.email = Email;
            this.password = Password;
            this.specialite = Specialite;


        }

    }
}

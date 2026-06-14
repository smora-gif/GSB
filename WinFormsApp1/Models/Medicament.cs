using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WinFormsApp1.Modele
{
    public class Medicament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }
        public override string ToString()
        {
            return Name + " - " + Dosage;
        }
        public Medicament(int id, string name, string dosage)
        {
            Id = id;
            Name = name;
            Dosage = dosage;
        }
    }
}
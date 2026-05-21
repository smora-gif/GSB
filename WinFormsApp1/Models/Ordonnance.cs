using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Modele
{
    internal class Ordonnance
    {
        private DateTime Date {  get; set; }
        List <Medecin> Medecins { get; set; }
        List <Patient> Patients { get; set; }

        List<Prescription> Prescriptions { get; set; }

        public Ordonnance (DateTime date)
        {
            this.Date = date;
            Medecins = new List <Medecin> ();
            Patients = new List <Patient> ();
            Prescriptions = new List <Prescription> ();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
        } 


    }
}

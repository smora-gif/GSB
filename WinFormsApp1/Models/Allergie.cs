using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Allergie
    {
        int IdAllergie { get; set; }
        string NomAllergie {  get; set; }
   public Allergie( string Libelle, int IdAllergie)
        {
            this.NomAllergie = Libelle;
            this.IdAllergie = IdAllergie;
        } 
    }
        
    }

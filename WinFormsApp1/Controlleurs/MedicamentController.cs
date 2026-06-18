using MySql.Data.MySqlClient;
using WinFormsApp1.Modele;
using WinFormsApp1.Ordonnances.DataAccess;
namespace WinFormsApp1.Controlleurs
{
    public class MedicamentController
    {
        public List<Medicament> ObtenirTousLesMedicaments()
        {
            List<Medicament> medicaments = new List<Medicament>();
            string sql = "SELECT codeMedicament, nom, dosage FROM MEDICAMENT ORDER BY nom";
            using (MySqlConnection cnx = DbConnexion.Ouvrir())
            using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
            {
                using (MySqlDataReader lecteur = cmd.ExecuteReader())
                {
                    while (lecteur.Read())
                    {
                        //Extrait les données de la base
                        int id = lecteur.GetInt32("codeMedicament");
                        string nom = lecteur.GetString("nom");
                        string dosage = lecteur.GetString("dosage");
                        medicaments.Add(new Medicament(id, nom, dosage));
                    }
                }
            }
            return medicaments;
        }
    }
}

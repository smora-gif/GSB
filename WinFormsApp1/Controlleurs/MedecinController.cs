using System;
using MySql.Data.MySqlClient;
using WinFormsApp1.Modele;
using WinFormsApp1.Ordonnances.DataAccess;

namespace WinFormsApp1.Controlleurs
{
    public class MedecinController
    {
        public Medecin Connexion(string rpps, string password)
        {
            string sql = "SELECT * FROM MEDECIN WHERE numeroRPPS = @rpps AND motDePasse = @password";
            using (MySqlConnection cnx = DbConnexion.Ouvrir())
            using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
            {
                //Ici on remplace les parametres par les vraies chaînes de caractères 
                cmd.Parameters.AddWithValue("@rpps", rpps);
                cmd.Parameters.AddWithValue("@password", password);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //Extrait les données et evite un crash. Si DBNull Renvoie rien car null en base ça casse tout
                        string numRpps = reader["numeroRPPS"] != DBNull.Value ? reader["numeroRPPS"].ToString() : "";
                        string prenom = reader["prenom"] != DBNull.Value ? reader["prenom"].ToString() : "";
                        string mail = reader["email"] != DBNull.Value ? reader["email"].ToString() : "";
                        string mdp = reader["motDePasse"] != DBNull.Value ? reader["motDePasse"].ToString() : "";
                        string spe = reader["specialite"] != DBNull.Value ? reader["specialite"].ToString() : "";
                        DateTime dateNais = DateTime.Now;
                        try
                        {
                            dateNais = reader["date_naissance"] != DBNull.Value ? Convert.ToDateTime(reader["date_naissance"]) : DateTime.Now;
                        }
                        catch
                        {
                            try
                            {
                                //Extrait la date de naissance en base et verifie si n'est pas null, il converti to datetime sinon il met la date d'aujourd'hui
                                dateNais = reader["dateNaissance"] != DBNull.Value ? Convert.ToDateTime(reader["dateNaissance"]) : DateTime.Now;
                            }
                            catch
                            {
                                dateNais = DateTime.Now;
                            }
                        }
                        return new Medecin(numRpps, spe, mail, mdp, numRpps, prenom, dateNais);
                    }
                }
            }
            return null;
        }
    }
}

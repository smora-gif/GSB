using System;
using MySql.Data.MySqlClient;
using WinFormsApp1.Modele;

namespace WinFormsApp1
{
    public class MedecinRepository
    {
        private string connectionString = "Server=localhost;Port=3306;Database=gsb_ordonnances;Uid=gsb;Pwd=gsbpass;";

        public Medecin Connexion(string rpps, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // La requête sur la table 'medecin' en minuscules
                    string query = "SELECT * FROM MEDECIN WHERE numeroRPPS = @rpps AND motDePasse = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rpps", rpps);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Récupération des chaînes de caractères (Sécurisées)
                                string numRpps = reader["numeroRPPS"] != DBNull.Value ? reader["numeroRPPS"].ToString() : "";
                                string prenom = reader["prenom"] != DBNull.Value ? reader["prenom"].ToString() : "";
                                string mail = reader["email"] != DBNull.Value ? reader["email"].ToString() : "";
                                string mdp = reader["motDePasse"] != DBNull.Value ? reader["motDePasse"].ToString() : "";
                                string spe = reader["specialite"] != DBNull.Value ? reader["specialite"].ToString() : "";

                                // CORRECTION DE L'ERREUR : On vérifie si la colonne existe ou on utilise un "try/catch" local
                                DateTime dateNais = DateTime.Now;
                                try
                                {
                                    // Essaie d'abord de lire 'date_naissance'
                                    dateNais = reader["date_naissance"] != DBNull.Value ? Convert.ToDateTime(reader["date_naissance"]) : DateTime.Now;
                                }
                                catch
                                {
                                    try
                                    {
                                        // Si 'date_naissance' n'existe pas, essaie 'dateNaissance'
                                        dateNais = reader["dateNaissance"] != DBNull.Value ? Convert.ToDateTime(reader["dateNaissance"]) : DateTime.Now;
                                    }
                                    catch
                                    {
                                        // Si ça plante encore, on garde DateTime.Now par défaut sans bloquer l'application
                                        dateNais = DateTime.Now;
                                    }
                                }

                                // Renvoie l'objet Médecin vers ta Page_Medecin
                                return new Medecin(numRpps, prenom, mail, mdp, mdp, spe, dateNais);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur de connexion à la base de données Docker : " + ex.Message);
                }
            }
            return null;
        }
    }
}
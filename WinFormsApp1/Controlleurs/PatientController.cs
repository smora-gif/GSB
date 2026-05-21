using MySql.Data.MySqlClient;
using WinFormsApp1.Modele;
using WinFormsApp1.Models;
using WinFormsApp1.Ordonnances.DataAccess;
namespace WinFormsApp1.Controlleurs
{
    public class PatientController
    {
        /// <summary>
        /// Récupère tous les patients de la base, triés par nom puis prénom.
        /// </summary>
        public List<Patient> RechercherParNom(string motCle)
        {
            List<Patient> patients = new List<Patient>();

            // Correction de la requête : On sélectionne TOUTES les colonnes nécessaires 
            // pour pouvoir utiliser ton constructeur existant à 8 paramètres.
            string sql = "SELECT numPatient, nom, prenom, dateNaissance, numeroSecu, poids, taille, patho, sex " +
                         "FROM PATIENT " +
                         "WHERE nom LIKE @motCle " +
                         "   OR prenom LIKE @motCle " +
                         "ORDER BY nom, prenom";

            using (MySqlConnection cnx = DbConnexion.Ouvrir())
            using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
            {
                // Les % autour permettent une recherche "contient"
                cmd.Parameters.AddWithValue("@motCle", "%" + motCle + "%");

                using (MySqlDataReader lecteur = cmd.ExecuteReader())
                {
                    while (lecteur.Read())
                    {
                        // On gère les valeurs nulles exactement comme dans ta première méthode
                        bool sexe = false;
                        if (!lecteur.IsDBNull(lecteur.GetOrdinal("sex")))
                            sexe = lecteur.GetBoolean("sex");

                        int poids = 0;
                        if (!lecteur.IsDBNull(lecteur.GetOrdinal("poids")))
                            poids = lecteur.GetInt32("poids");

                        int taille = 0;
                        if (!lecteur.IsDBNull(lecteur.GetOrdinal("taille")))
                            taille = lecteur.GetInt32("taille");

                        string patho = "";
                        if (!lecteur.IsDBNull(lecteur.GetOrdinal("patho")))
                            patho = lecteur.GetString("patho");

                        // Utilisation de TON constructeur à 8 paramètres
                        Patient p = new Patient(
                            poids,
                            taille,
                            patho,
                            lecteur.GetString("numeroSecu"),
                            sexe,
                            lecteur.GetString("nom"),
                            lecteur.GetString("prenom"),
                            lecteur.GetDateTime("dateNaissance")
                        );

                        p.Id = lecteur.GetInt32("numPatient");
                        patients.Add(p);
                    }
                }
            }
            return patients;
        }


        public List<Patient> ObtenirTousLesPatients()
        {
            List<Patient> patients = new List<Patient>();

            // Correction de la requête : On sélectionne TOUTES les colonnes nécessaires 
            // pour pouvoir utiliser ton constructeur existant à 8 paramètres.
            string sql = "SELECT numPatient, nom, prenom, dateNaissance, numeroSecu, poids, taille, patho, sex " +
                         "FROM PATIENT " +
                         "ORDER BY nom, prenom";

            using (MySqlConnection cnx = DbConnexion.Ouvrir())
            using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
            {
                // Les % autour permettent une recherche "contient"


                using (MySqlDataReader lecteur = cmd.ExecuteReader())
                {
                    while (lecteur.Read())
                    {
                        // On gère les valeurs nulles exactement comme dans ta première méthode
                        bool sexe = false;
                        if (!lecteur.IsDBNull(lecteur.GetOrdinal("sex")))
                            sexe = lecteur.GetBoolean("sex");

                        int poids = 0;
                        if (!lecteur.IsDBNull(lecteur.GetOrdinal("poids")))
                            poids = lecteur.GetInt32("poids");

                        int taille = 0;
                        if (!lecteur.IsDBNull(lecteur.GetOrdinal("taille")))
                            taille = lecteur.GetInt32("taille");

                        string patho = "";
                        if (!lecteur.IsDBNull(lecteur.GetOrdinal("patho")))
                            patho = lecteur.GetString("patho");

                        // Utilisation de TON constructeur à 8 paramètres
                        Patient p = new Patient(
                            poids,
                            taille,
                            patho,
                            lecteur.GetString("numeroSecu"),
                            sexe,
                            lecteur.GetString("nom"),
                            lecteur.GetString("prenom"),
                            lecteur.GetDateTime("dateNaissance")
                        );

                        p.Id = lecteur.GetInt32("numPatient");
                        patients.Add(p);
                    }
                }
            }
            return patients;
        }
        /// <summary>
        /// Récupère un patient par son identifiant.
        /// Retourne null si l'ID n'existe pas.
        /// </summary>
        public Patient ObtenirParId(int id)
        {
            Patient patient = null;
            string sql = "SELECT numPatient, nom, prenom, " +
                         "       dateNaissance, numeroSecu, poids, taille, patho, sex" +
                         "FROM PATIENT " +
                         "WHERE numPatient = @id";
            using (MySqlConnection cnx = DbConnexion.Ouvrir())
            using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())  // au plus une ligne attendue
                    {
                        patient = new Patient(
                        r.GetInt32("poids"),
                        r.GetInt32("taille"),
                        r.GetString("patho"),
                        r.GetString("numeroSecu"),
                        r.GetBoolean("sex"),
                        r.GetString("nom"),
                        r.GetString("prenom"),
                        r.GetDateTime("dateNaissance")
                        );
                        patient.Id = r.GetInt32("numPatient");
                    }
                }
            }
            // Une fois le patient construit, on charge ses allergies
            if (patient != null)
            {
                patient.Allergies = ChargerAllergies(id);
            }
            return patient;
        }
        /// <summary>
        /// Retourne la liste des libellés d'allergies pour un patient.
        /// Méthode privée : utilitaire interne au contrôleur.
        /// </summary>
        private List<Allergie> ChargerAllergies(int idPatient)
        {
            List<Allergie> allergies = new List<Allergie>();
            string sql = "SELECT a.libelle, a.codeAllergie " +
                         "FROM   ETRE_ALLERGIQUE ea " +
                         "JOIN   ALLERGIE        a  " +
                         "       ON a.codeAllergie = ea.codeAllergie " +
                         "WHERE  ea.numPatient = @id " +
                         "ORDER BY a.libelle";
            using (MySqlConnection cnx = DbConnexion.Ouvrir())
            using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
            {
                cmd.Parameters.AddWithValue("@id", idPatient);
                using (MySqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                        allergies.Add(new Allergie(r.GetString("libelle"), r.GetInt32("codeAllergie")));
                }
            }
            return allergies;
        }
        /// <summary>
        /// Liste les ordonnances d'un patient, classées de la plus
        /// récente à la plus ancienne.
        /// </summary>
        public List<OrdonnanceResume> ObtenirHistorique(int idPatient)
        {
            List<OrdonnanceResume> historique = new List<OrdonnanceResume>();
            string sql = "SELECT o.numOrdonnance, o.dateEmission, " +
                         "       m.nom AS medecinNom, " +
                         "       m.specialite AS medecinSpecialite " +
                         "FROM   ORDONNANCE o " +
                         "JOIN   MEDECIN m ON m.numMedecin = o.numMedecin " +
                         "WHERE  o.numPatient = @id " +
                         "ORDER BY o.dateEmission DESC";
            using (MySqlConnection cnx = DbConnexion.Ouvrir())
            using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
            {
                cmd.Parameters.AddWithValue("@id", idPatient);
                using (MySqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        historique.Add(new OrdonnanceResume
                        {
                            Id = r.GetInt32("numOrdonnance"),
                            DateEmission = r.GetDateTime("dateEmission"),
                            MedecinNom = r.GetString("medecinNom"),
                            MedecinSpecialite = r.GetString("medecinSpecialite")
                        });
                    }
                }
            }
            return historique;
        }
        public List<string> ObtenirAllergie(int idPatient)
        {
            List<string> allergies = new List<string>();
            string sql = "SELECT a.libelle " +
                             "FROM   ETRE_ALLERGIQUE ea " +
                             "JOIN   ALLERGIE a ON a.codeAllergie = ea.codeAllergie " +
                             "WHERE  ea.numPatient = @id " +
                             "ORDER BY a.libelle";
            using (MySqlConnection cnx = DbConnexion.Ouvrir())
            using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
            {
                cmd.Parameters.AddWithValue("@id", idPatient);

                using (MySqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        // On lit le texte de la colonne "libelle" et on l'ajoute à la liste
                        allergies.Add(r.GetString("libelle"));
                    }
                }
            }
            return allergies;
        }
    }
}
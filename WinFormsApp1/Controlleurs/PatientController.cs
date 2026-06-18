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
            string sql = "SELECT numPatient, nom, prenom, dateNaissance, numeroSecu, poids, taille, patho, sex " +
                         "FROM PATIENT " +
                         "WHERE nom LIKE @motCle " +
                         " OR prenom LIKE @motCle " +
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
                        // On gère les valeurs nulles exactement comme dans la première méthode
                        bool sexe = false;
                        //Verifie si la colonne sex n'est pas null en base et renvoie le sex
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
                        // Utilisation de constructeur patient qui à 8 parametres
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
        public bool CreerPatient(Patient p)
        {
            // Requête SQL d'insertion (Attention à l'orthographe exacte de tes colonnes en BDD)
            string sql = "INSERT INTO PATIENT (nom, prenom, dateNaissance, numeroSecu, poids, taille, patho, sex) " +
                         "VALUES (@nom, @prenom, @dateNaissance, @numeroSecu, @poids, @taille, @patho, @sex)";
            try
            {
                using (MySqlConnection cnx = DbConnexion.Ouvrir())
                using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
                {
                    // Liaison des paramètres pour éviter les injections SQL
                    cmd.Parameters.AddWithValue("@nom", p.Nom);
                    cmd.Parameters.AddWithValue("@prenom", p.Prenom);
                    cmd.Parameters.AddWithValue("@dateNaissance", p.DateNaissance);
                    cmd.Parameters.AddWithValue("@numeroSecu", p.numSecu);
                    cmd.Parameters.AddWithValue("@poids", p.poids);
                    cmd.Parameters.AddWithValue("@taille", p.taille);
                    cmd.Parameters.AddWithValue("@patho", p.patho);
                    // Conversion du sexe pour ta base de données (booléen)
                    cmd.Parameters.AddWithValue("@sex", p.sex);
                    int lignesModifiees = cmd.ExecuteNonQuery();
                    return lignesModifiees > 0; // Renvoie true si l'insertion a réussi
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur SQL lors de la création : " + ex.Message, "Erreur BDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool ModifierPatient(Patient p)
        {
            // On cible bien "numPatient" pour la clause WHERE
            string sql = "UPDATE PATIENT SET " +
                         "  nom = @nom, " +
                         "  prenom = @prenom, " +
                         "  dateNaissance = @dateNaissance, " +
                         "  numeroSecu = @numeroSecu, " +
                         "  poids = @poids, " +
                         "  taille = @taille, " +
                         "  patho = @patho, " +
                         "  sex = @sex " +
                         "WHERE numPatient = @id";
            try
            {
                using (MySqlConnection cnx = DbConnexion.Ouvrir())
                using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
                {
                    // ATTENTION : On utilise bien les propriétés exactes de ton modèle Patient (Nom, Prenom, NumeroSecu, Poids, Taille, Patho, Sex, Id)
                    cmd.Parameters.AddWithValue("@nom", p.Nom);
                    cmd.Parameters.AddWithValue("@prenom", p.Prenom);
                    cmd.Parameters.AddWithValue("@dateNaissance", p.DateNaissance);
                    cmd.Parameters.AddWithValue("@numeroSecu", p.numSecu); // CORRIGÉ (NumeroSecu à la place de numSecu)
                    cmd.Parameters.AddWithValue("@poids", p.poids);           // CORRIGÉ (Poids à la place de poids)
                    cmd.Parameters.AddWithValue("@taille", p.taille);         // CORRIGÉ (Taille à la place de taille)
                    cmd.Parameters.AddWithValue("@patho", p.patho);           // CORRIGÉ (Patho à la place de patho)
                    cmd.Parameters.AddWithValue("@sex", p.sex);               // CORRIGÉ (Sex à la place de sex)
                    cmd.Parameters.AddWithValue("@id", p.Id);                 // L'identifiant unique pour la clause WHERE
                    int lignesModifiees = cmd.ExecuteNonQuery();
                    return lignesModifiees > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur SQL lors de la modification : " + ex.Message, "Erreur BDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
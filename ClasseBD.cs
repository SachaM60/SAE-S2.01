using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.LinkLabel;


namespace SAE_S2._01
{
    public static class ClasseBD
    {
        private static MySqlConnection conn;
        public static bool Ouverture()
        {
            bool ouvert = false;
            string serveur = "10.1.139.236";
            string login = "d3";
            string mdp = "based3";
            string bd = "based3";
            string chaineconnexion = $"Server={serveur};Database={bd};Uid={login};Pwd={mdp};";
            try
            {
                conn = new MySqlConnection(chaineconnexion);
                conn.Open();
                ouvert = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erreur de connexion à la base de données : " + ex.Message);
            }
            return ouvert;
        }

        public static void Fermeture()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public static int InsertionLigne(string NomLigne, int arret_dep, int arret_fin)
        {
            string requeteLigne = $"INSERT INTO Ligne (nom_ligne,arret_dep,arret_fin) VALUES ('{NomLigne}',{arret_dep},{arret_fin});";
            MySqlCommand cmd = new MySqlCommand(requeteLigne, conn);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }

        public static void InsertionArret(string NomArret, double latitude, double longitude)
        {
            string requeteArret = "INSERT INTO Arret (nom_arret, latitude_arret, longitude_arret) " +
                          "VALUES (@nom, @lat, @long);";

            using (MySqlCommand cmd = new MySqlCommand(requeteArret, conn))
            {
                cmd.Parameters.AddWithValue("@nom", NomArret);
                cmd.Parameters.AddWithValue("@lat", latitude);
                cmd.Parameters.AddWithValue("@long", longitude);
                cmd.ExecuteNonQuery();
            }
        }

        public static void InsertionBus(string immatriculation)
        {
            string requeteBus = $"INSERT INTO Bus (immatriculation) VALUES ('{immatriculation}');";
            MySqlCommand cmd = new MySqlCommand(requeteBus, conn);
            cmd.ExecuteNonQuery();
        }

        public static void InsertionHoraire(int bus, int arret, int ligne, string horaire)
        {
            string requeteHoraire = $"INSERT INTO Horaire (id_bus,id_arret,id_ligne,heure_depart) " +
                $"VALUES ({bus},{arret},{ligne},'{horaire}');";
            MySqlCommand cmd = new MySqlCommand(requeteHoraire, conn);
            cmd.ExecuteNonQuery();
        }

        public static void InsertionSuivant(int actuel, int suivant, int ligne)
        {
            string requeteSuivant = $"INSERT INTO Suivant (arret_actuel,arret_suivant,id_ligne) VALUES ({actuel},{suivant},{ligne});";
            MySqlCommand cmd = new MySqlCommand(requeteSuivant, conn);
            cmd.ExecuteNonQuery();
        }

        public static void InsertionCroisement(int arret, int ligne)
        {
            string requeteCroisement = $"INSERT INTO Croisement (id_arret,id_ligne) VALUES ({arret},{ligne});";
            MySqlCommand cmd = new MySqlCommand(requeteCroisement, conn);
            cmd.ExecuteNonQuery();
        }

        public static void InsertionFavori(int utilisateur, int favori)
        {
            string requeteFavori = $"INSERT INTO Favori (id_utilisateur,id_ligne) VALUES ({utilisateur},{favori});";
            MySqlCommand cmd = new MySqlCommand(requeteFavori, conn);
            cmd.ExecuteNonQuery();
        }

        public static void InsertionUtilisateur(string id, string nom, string prenom, string mdp, string sexe, int age)
        {
            string requeteHoraire = $"INSERT INTO Utilisateur (id_utilisateur,nom_utilisateur,prenom_utilisateur," +
                $"mot_de_passe,sexe_utilisateur,age_utilisateur) " +
                $"VALUES ('{id}','{nom}','{prenom}','{mdp}','{sexe}',{age});";
            MySqlCommand cmd = new MySqlCommand(requeteHoraire, conn);
            cmd.ExecuteNonQuery();
        }

        public static void LectureArret(ref List<(int, string, double, double)> Liste)
        {
            string requeteArret = "SELECT * FROM Arret ORDER BY nom_arret;";
            MySqlCommand cmd = new MySqlCommand(requeteArret, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nom = reader.GetString(1);
                double latitude = reader.GetDouble(2);
                double longitude = reader.GetDouble(3);
                Liste.Add((id, nom, latitude, longitude));
            }
            reader.Close();
        }

        public static void LectureLigne(ref List<(int, string, int, int)> Liste)
        {
            string requeteLigne = "SELECT * FROM Ligne ORDER BY nom_ligne;";
            MySqlCommand cmd = new MySqlCommand(requeteLigne, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nom = reader.GetString(1);
                int arret_dep = reader.GetInt32(2);
                int arret_fin = reader.GetInt32(3);
                Liste.Add((id, nom, arret_dep, arret_fin));
            }
            reader.Close();
        }

        public static void LectureBus(ref List<(int, string)> Liste)
        {
            string requeteBus = "SELECT * FROM Bus ORDER BY id_bus;";
            MySqlCommand cmd = new MySqlCommand(requeteBus, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string immatriculation = reader.GetString(1);
                Liste.Add((id, immatriculation));
            }
            reader.Close();
        }

        public static void LectureHoraire(ref List<(int, int, int, string)> Liste)
        {
            string requeteHoraire = "SELECT * FROM Horaire;";
            MySqlCommand cmd = new MySqlCommand(requeteHoraire, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id_bus = reader.GetInt32(0);
                int id_arret = reader.GetInt32(1);
                int id_ligne = reader.GetInt32(2);
                string heure_depart = reader.GetTimeSpan(3).ToString(@"hh\:mm");
                Liste.Add((id_bus, id_arret, id_ligne, heure_depart));
            }
            reader.Close();
        }
    }
}

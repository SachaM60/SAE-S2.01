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

        public static void InsertionLigne(string NomLigne,int arret_dep,int arret_fin) 
        {
            string requeteLigne = $"INSERT INTO Ligne (nom_ligne,arret_dep,arret_fin) VALUES ('{NomLigne}',{arret_dep},{arret_fin});";
            MySqlCommand cmd = new MySqlCommand(requeteLigne, conn);
            cmd.ExecuteNonQuery();
        }

        public static void InsertionArret(string NomArret,double latitude,double longitude) 
        {
            string requeteArret = $"INSERT INTO Arret (nom_arret,latitude_arret,longitude_arret) " +
                $"VALUES ('{NomArret}',{latitude},{longitude});";
            MySqlCommand cmd = new MySqlCommand(requeteArret, conn);
            cmd.ExecuteNonQuery();
        }

        public static void InsertionHoraire(int bus,int arret,int ligne,string horaire) 
        {
            string requeteHoraire = $"INSERT INTO Horaire (id_bus,id_arret,id_ligne,heure_depart) " +
                $"VALUES ({bus},{arret},{ligne},'{horaire}');";
            MySqlCommand cmd = new MySqlCommand(requeteHoraire, conn);
            cmd.ExecuteNonQuery();
        }

        public static void InsertionSuivant(int actuel,int suivant,int ligne) 
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

        public static void InsertionUtilisateur(string id,string nom, string prenom, string mdp, string sexe, int age) 
        {
            string requeteHoraire = $"INSERT INTO Utilisateur (id_utilisateur,nom_utilisateur,prenom_utilisateur," +
                $"mot_de_passe,sexe_utilisateur,age_utilisateur) " +
                $"VALUES ('{id}','{nom}','{prenom}','{mdp}','{sexe}',{age});";
            MySqlCommand cmd = new MySqlCommand(requeteHoraire, conn);
            cmd.ExecuteNonQuery();
        }

        public static void LectureNomArret(ref List<string> liste)
        {
            string requeteArret = "SELECT nom_arret FROM Arret ORDER BY nom_arret;";
            MySqlCommand cmd = new MySqlCommand(requeteArret, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nom = reader.GetString(0);
                liste.Add(nom);
            }
            reader.Close();
        }
    }
}

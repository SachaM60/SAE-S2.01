using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


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

        public static void InsertionLigne() { }

        public static void InsertionArret() { }

        public static void InsertionHoraire() { }

        public static void InsertionSuivant() { }

        public static void InsertionCroisement() { }

        public static void InsertionFavori() { }

        public static void InsertionUtilisateur() { }

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

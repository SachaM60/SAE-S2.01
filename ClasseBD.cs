﻿using System;
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
        public static string UserConnect { get; set; }
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

        //Méthodes d'insertion

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

        public static void InsertionFavori(string utilisateur, int favori)
        {
            string requeteFavori = $"INSERT INTO Favori (id_utilisateur,id_ligne) VALUES ('{utilisateur}',{favori});";
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

        //Méthodes de suppression

        public static void SuppressionLigne(int id)
        {
            string requeteHoraire = $"DELETE FROM Horaire WHERE id_ligne = {id};";
            MySqlCommand cmd = new MySqlCommand(requeteHoraire, conn);
            cmd.ExecuteNonQuery();

            string requeteSuivant = $"DELETE FROM Suivant WHERE id_ligne = {id};";
            MySqlCommand cmd2 = new MySqlCommand(requeteSuivant, conn);
            cmd2.ExecuteNonQuery();

            string requeteCroisement = $"DELETE FROM Croisement WHERE id_ligne = {id};";
            MySqlCommand cmd3 = new MySqlCommand(requeteCroisement, conn);
            cmd3.ExecuteNonQuery();

            string requeteFavori = $"DELETE FROM Favori WHERE id_ligne = {id};";
            MySqlCommand cmd4 = new MySqlCommand(requeteFavori, conn);
            cmd4.ExecuteNonQuery();

            string requeteLigne = $"DELETE FROM Ligne WHERE id_ligne = {id};";
            MySqlCommand cmd5 = new MySqlCommand(requeteLigne, conn);
            cmd5.ExecuteNonQuery();
        }

        public static string SuppressionArret(int id)
        {
            List<(int, string, int, int)> Ligne = new List<(int, string, int, int)>();
            ClasseBD.LectureLigne(ref Ligne);
            if (Ligne.Any(l => l.Item3 == id || l.Item4 == id))
            {
                return "L'arrêt ne peut pas être supprimé car \n il est le départ ou le terminus d'une ligne";
            }

            // Recherche des paires (précédent, id) et (id, suivant) pour chaque ligne
            string requetePrecedents = $"SELECT arret_actuel, id_ligne FROM Suivant WHERE arret_suivant = {id};";
            string requeteSuivants = $"SELECT arret_suivant, id_ligne FROM Suivant WHERE arret_actuel = {id};";

            Dictionary<int, int> precedents = new Dictionary<int, int>(); // id_ligne -> arret_actuel
            Dictionary<int, int> suivants = new Dictionary<int, int>();   // id_ligne -> arret_suivant

            using (MySqlCommand cmdPrec = new MySqlCommand(requetePrecedents, conn))
            using (MySqlDataReader readerPrec = cmdPrec.ExecuteReader())
            {
                while (readerPrec.Read())
                {
                    int precedent = readerPrec.GetInt32(0);
                    int ligne = readerPrec.GetInt32(1);
                    precedents[ligne] = precedent;
                }
            }

            using (MySqlCommand cmdSuiv = new MySqlCommand(requeteSuivants, conn))
            using (MySqlDataReader readerSuiv = cmdSuiv.ExecuteReader())
            {
                while (readerSuiv.Read())
                {
                    int suivant = readerSuiv.GetInt32(0);
                    int ligne = readerSuiv.GetInt32(1);
                    suivants[ligne] = suivant;
                }
            }

            // Pour chaque ligne qui a à la fois un précédent et un suivant
            foreach (var ligne in precedents.Keys)
            {
                if (suivants.ContainsKey(ligne))
                {
                    int precedent = precedents[ligne];
                    int suivant = suivants[ligne];

                    // Insertion du nouveau lien
                    string requeteInsert = $"INSERT INTO Suivant (arret_actuel, arret_suivant, id_ligne) VALUES ({precedent}, {suivant}, {ligne});";
                    MySqlCommand cmdInsert = new MySqlCommand(requeteInsert, conn);
                    cmdInsert.ExecuteNonQuery();
                }
            }

            // Suppression des lignes où id est utilisé
            string requeteDeleteSuivant = $"DELETE FROM Suivant WHERE arret_actuel = {id} OR arret_suivant = {id};";
            MySqlCommand cmdDelSuivant = new MySqlCommand(requeteDeleteSuivant, conn);
            cmdDelSuivant.ExecuteNonQuery();

            // Suppression des croisements associés à l'arrêt
            string requeteCroisement = $"DELETE FROM Croisement WHERE id_arret = {id};";
            MySqlCommand cmdDelCroisement = new MySqlCommand(requeteCroisement, conn);
            cmdDelCroisement.ExecuteNonQuery();

            // Suppression de l'arrêt
            string requeteArret = $"DELETE FROM Arret WHERE id_arret = {id};";
            MySqlCommand cmdDelArret = new MySqlCommand(requeteArret, conn);
            cmdDelArret.ExecuteNonQuery();

            return "";
        }

        public static void SuppressionHoraire(string horaire, int id_arret, int id_ligne)
        {
            string requeteHoraire = $"DELETE FROM Horaire WHERE heure_depart = '{horaire}' AND id_arret = {id_arret} AND id_ligne = {id_ligne};";
            MySqlCommand cmd = new MySqlCommand(requeteHoraire, conn);
            cmd.ExecuteNonQuery();
        }

        public static void SuppressionUtilisateur(string id_utilisateur)
        {
            string requeteUtilisateur = $"DELETE FROM Utilisateur WHERE id_utilisateur = '{id_utilisateur}';";
            MySqlCommand cmd = new MySqlCommand(requeteUtilisateur, conn);
            cmd.ExecuteNonQuery();
        }

        public static void SuppressionFavori(string id_utilisateur)
        {
            string requeteFavori = $"DELETE FROM Favori WHERE id_utilisateur = '{id_utilisateur}';";
            MySqlCommand cmd = new MySqlCommand(requeteFavori, conn);
            cmd.ExecuteNonQuery();
        }

        public static void SuppressionCroisement(int id_ligne)
        {
            string requeteCroisement = $"DELETE FROM Croisement WHERE id_ligne = {id_ligne};";
            MySqlCommand cmd = new MySqlCommand(requeteCroisement, conn);
            cmd.ExecuteNonQuery();
        }

        public static void SuppressionSuivant(int id_ligne)
        {
            string requeteSuivant = $"DELETE FROM Suivant WHERE id_ligne = {id_ligne};";
            MySqlCommand cmd = new MySqlCommand(requeteSuivant, conn);
            cmd.ExecuteNonQuery();
        }

        //Méthodes de lecture

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
            string requeteHoraire = "SELECT * FROM Horaire ORDER BY heure_depart;";
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

        public static void LectureCroisement(ref List<(int, int)> Liste)
        {
            string requeteCroisement = "SELECT * FROM Croisement;";
            MySqlCommand cmd = new MySqlCommand(requeteCroisement, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id_arret = reader.GetInt32(0);
                int id_ligne = reader.GetInt32(1);
                Liste.Add((id_arret, id_ligne));
            }
            reader.Close();
        }

        public static void LectureSuivant(ref List<(int, int, int)> Liste)
        {
            string requeteSuivant = "SELECT * FROM Suivant;";
            MySqlCommand cmd = new MySqlCommand(requeteSuivant, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int arret_actuel = reader.GetInt32(0);
                int arret_suivant = reader.GetInt32(1);
                int id_ligne = reader.GetInt32(2);
                Liste.Add((arret_actuel, arret_suivant, id_ligne));
            }
            reader.Close();
        }

        public static void LectureFavori(ref List<(string, int)> Liste)
        {
            string requeteFavori = "SELECT * FROM Favori;";
            MySqlCommand cmd = new MySqlCommand(requeteFavori, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id_utilisateur = reader.GetString(0);
                int id_ligne = reader.GetInt32(1);
                Liste.Add((id_utilisateur, id_ligne));
            }
            reader.Close();
        }

        public static void LectureUtilisateur(ref List<(string, string, string, string, string, int)> Liste)
        {
            string requeteUtilisateur = "SELECT * FROM Utilisateur;";
            MySqlCommand cmd = new MySqlCommand(requeteUtilisateur, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id_utilisateur = reader.GetString(0);
                string nom_utilisateur = reader.GetString(1);
                string prenom_utilisateur = reader.GetString(2);
                string mot_de_passe = reader.GetString(3);
                string sexe_utilisateur = reader.GetString(4);
                int age_utilisateur = reader.GetInt32(5);
                Liste.Add((id_utilisateur, nom_utilisateur, prenom_utilisateur, mot_de_passe, sexe_utilisateur, age_utilisateur));
            }
            reader.Close();
        }

        public static void LectureArretsDeLaLigne(int idLigne, ref List<int> idsArrets)
        {
            idsArrets.Clear();
            int idPremierArret = -1;

            // Étape 1 : Récupérer le premier arrêt
            using (MySqlCommand cmd = new MySqlCommand("SELECT arret_dep FROM Ligne WHERE id_ligne = @idLigne", conn))
            {
                cmd.Parameters.AddWithValue("@idLigne", idLigne);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    idPremierArret = Convert.ToInt32(result);
                }
                else
                {
                    return; // Ligne non trouvée
                }
            }

            // Étape 2 : Parcourir la table Suivant pour reconstituer le chemin
            int current = idPremierArret;
            idsArrets.Add(current);

            while (true)
            {
                int suivant = -1;

                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT arret_suivant FROM Suivant WHERE arret_actuel = @current AND id_ligne = @idLigne", conn))
                {
                    cmd.Parameters.AddWithValue("@current", current);
                    cmd.Parameters.AddWithValue("@idLigne", idLigne);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        suivant = Convert.ToInt32(result);
                    }
                }

                if (suivant == -1)
                    break; // Fin du parcours

                idsArrets.Add(suivant);
                current = suivant;
            }
        }

        // Méthodes de Modifiaction

        public static void ModificationArret(string Oldnom, string Newnom, double lat, double lon)
        {
            string requeteArret = "UPDATE Arret SET nom_arret = @newnom, latitude_arret = @lat, longitude_arret = @lon " +
                "WHERE nom_arret = @oldnom;";
            using (MySqlCommand cmd = new MySqlCommand(requeteArret, conn))
            {
                cmd.Parameters.AddWithValue("@newnom", Newnom);
                cmd.Parameters.AddWithValue("@lat", lat);
                cmd.Parameters.AddWithValue("@lon", lon);
                cmd.Parameters.AddWithValue("@oldnom", Oldnom);
                cmd.ExecuteNonQuery();
            }
        }

        public static void ModificationHoraire(string Oldhoraire, string Newhoraire, int id_arret, int id_ligne)
        {
            string requeteHoraire = "UPDATE Horaire SET heure_depart = @newhoraire " +
                "WHERE heure_depart = @oldhoraire AND id_arret = @id_arret AND id_ligne = @id_ligne;";
            using (MySqlCommand cmd = new MySqlCommand(requeteHoraire, conn))
            {
                cmd.Parameters.AddWithValue("@newhoraire", Newhoraire);
                cmd.Parameters.AddWithValue("@oldhoraire", Oldhoraire);
                cmd.Parameters.AddWithValue("@id_arret", id_arret);
                cmd.Parameters.AddWithValue("@id_ligne", id_ligne);
                cmd.ExecuteNonQuery();
            }
        }

        public static void ModificationHoraireBis(int idLigne, int NewArret, int OldArret)
        {
            string requeteHoraire = "UPDATE Horaire SET id_arret = @newarret " +
                "WHERE id_ligne = @id_ligne AND id_arret = @oldarret;";
            using (MySqlCommand cmd = new MySqlCommand(requeteHoraire, conn))
            {
                cmd.Parameters.AddWithValue("@newarret", NewArret);
                cmd.Parameters.AddWithValue("@oldarret", OldArret);
                cmd.Parameters.AddWithValue("@id_ligne", idLigne);
                cmd.ExecuteNonQuery();
            }
        }

        public static void ModificationFavori(string utilisateur, string ligne)
        {
            List<(int,string,int,int)> Ligne = new List<(int, string, int, int)>();
            ClasseBD.LectureLigne(ref Ligne);
            List<int> idLigne = new List<int>();

            foreach (var item in Ligne)
            {
                if (item.Item2 == ligne)
                {
                    idLigne.Add(item.Item1);
                }
            }
            foreach (var id in idLigne)
            {
                ClasseBD.InsertionFavori(utilisateur, id);
            }

        }

        public static void ModificationLigne(int idLigne, string nomLigne, int arret_dep, int arret_fin)
        {
            string requeteLigne = "UPDATE Ligne SET nom_ligne = @nom, arret_dep = @arret_dep, arret_fin = @arret_fin " +
                "WHERE id_ligne = @idLigne;";
            using (MySqlCommand cmd = new MySqlCommand(requeteLigne, conn))
            {
                cmd.Parameters.AddWithValue("@nom", nomLigne);
                cmd.Parameters.AddWithValue("@arret_dep", arret_dep);
                cmd.Parameters.AddWithValue("@arret_fin", arret_fin);
                cmd.Parameters.AddWithValue("@idLigne", idLigne);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

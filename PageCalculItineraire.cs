using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Session;
using SAE_S2._01;

namespace SAE_S2._01
{
    public partial class PageCalculItineraire : Form
    {
        //Connection à la base de données
        private static MySqlConnection conn;
        private List<(int, string, double, double)> Arret = new List<(int, string, double, double)>();
        //Définition des variables pour les arrêts de départ et d'arrivée
        private Arret arret_actuel;
        private string nom_arret_actuel;
        private Arret arret_stop;
        private string nom_arret_stop;
        private string chemin = "";
        // Lecture du nombre d'arrêts dans la base de données
        private static int nbarrets = ClasseBD.LectureNombreArret();

        // Initialisation des listes pour stocker les noms et positions des arrêts
        private static List<string> nom = new List<string>(nbarrets);

        private static List<Tuple<double, double>> pos = new List<Tuple<double, double>>(nbarrets);

        // Liste pour stocker les IDs des arrêts
        private static List<int> idArret = new List<int>(nbarrets);

        // Dictionnaire pour stocker les arrêts par ID
        private static Dictionary<int, Arret> ArretByID = new Dictionary<int, Arret>();

        // Initialize the dictionary ArretByIsFavoris before its usage to fix CS0165 error.  
        private static Dictionary<int, bool> ArretByIsFavoris = new Dictionary<int, bool>();

        // Lecture des successeurs et prédécesseurs
        private static Dictionary<int, List<int>> SuccesseursbyId = ClasseBD.LectureSuivant();

        private static Dictionary<int, List<int>> PredecesseursById = ClasseBD.LecturePredecesseur();

        //Lecture des lignes passant par chaque arrêt

        private static Dictionary<int, List<int>> ArretByLigne = ClasseBD.LectureCroisement();

        //Création du graphe du réseau de transport
        private static Graphes Reseau = new Graphes(ArretByID);

        public PageCalculItineraire()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(ClasseBD.UserConnect.Item1))
            {
                btnFavoris.Enabled = false;
            }
            else
            {
                btnFavoris.Enabled = true;
            }
            ClasseBD.LectureArret(ref Arret);
            foreach (var item in Arret)
            {
                comboBox1.Items.Add(item.Item2);
            }
            comboBox1.DropDownHeight = 200;
            comboBox1.DropDownWidth = 200;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            foreach (var item in Arret)
            {
                comboBox2.Items.Add(item.Item2);
            }
            comboBox2.DropDownHeight = 200;
            comboBox2.DropDownWidth = 200;
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Lecture des noms et positions des arrêts
            ClasseBD.LectureNomArret(ref nom, ref pos, nbarrets, ref idArret);

            if (ArretByID.Count == 0) { 
                ////Création des arrêts à partir des données lues
                for (int i = 0; i < nbarrets; i++)
                {
                    ArretByID.Add(idArret[i], new Arret(nom[i], pos[i].Item1, pos[i].Item2, new List<ArretAdjacent>(), new List<ArretAdjacent>(), idArret[i]));
                }

                //Ajout des successeurs
                foreach (int id in SuccesseursbyId.Keys)
                {
                    Arret arret = ArretByID[id];
                    foreach (int adjacentId in SuccesseursbyId[id])
                    {
                        double distance = arret.DistanceVers(ArretByID[adjacentId]); // Calcul de la distance entre les arrêts
                        arret.Add_successeur(new ArretAdjacent(ArretByID[adjacentId], distance / 30, ArretByLigne[id]));
                    }
                }

                //Ajout des prédécesseurs
                foreach (int id in PredecesseursById.Keys)
                {
                    Arret arret = ArretByID[id];
                    foreach (int adjacentId in PredecesseursById[id])
                    {
                        double distance = arret.DistanceVers(ArretByID[adjacentId]); // Calcul de la distance entre les arrêts
                        arret.Add_predecesseur(new ArretAdjacent(ArretByID[adjacentId], distance / 30, ArretByLigne[id]));
                    }
                }
            }
            lblChemin.Text = "";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            PageMenuPrincipal pageMenuPrincipal = new PageMenuPrincipal();
            pageMenuPrincipal.Show();
            this.Close();
        }

        private void btnFavoris_Click(object sender, EventArgs e)
        {
            PageTrajetsFavoris pageTrajetsFavoris = new PageTrajetsFavoris();
            pageTrajetsFavoris.Show();
            this.Close();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            PagePlanDuReseau pagePlanDuReseau = new PagePlanDuReseau();
            pagePlanDuReseau.Show();
            this.Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        // Fait sans la BD pour Verifier le fonctionnement de la page

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Arret de depart

            string nom_arret_actuel = "";
            if (comboBox1.SelectedItem == null)
            {
                nom_arret_actuel = "";
            }
            else
            {
                nom_arret_actuel = comboBox1.SelectedItem.ToString()!;
                arret_actuel = Reseau.Arrets.Values.FirstOrDefault(a => a.Nom.Equals(nom_arret_actuel, StringComparison.OrdinalIgnoreCase))!;
            }
        }

        private void PageCalculItineraire_Load(object sender, EventArgs e)
        {

        }

        //Fait sans la BD pour Verifier le fonctionnement de la page

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Arret d'arrivée

            if (comboBox2.SelectedItem == null)
            {
                nom_arret_stop = "";
            }
            else
            {
                nom_arret_stop = comboBox2.SelectedItem.ToString()!;
                arret_stop = Reseau.Arrets.Values.FirstOrDefault(a => a.Nom.Equals(nom_arret_stop, StringComparison.OrdinalIgnoreCase))!;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Executer le calcul de l'itinéraire entre les deux arrêts sélectionnés
            /// </summary>
             double temps = 0;
            chemin = Reseau.Djikstra(arret_actuel!.Id_arret, arret_stop!.Id_arret, ArretByIsFavoris, ref temps);
            labelAffTempsTra.Text = $"{temps.ToString()} minutes.";
            lblChemin.Text = chemin;
            lblChemin.MaximumSize = new Size(420, 0); 
            lblChemin.AutoSize = true;
        }
    }
}

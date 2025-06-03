using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_S2._01
{
    public partial class PageAjoutHoraire : Form
    {
        /// <summary>
        /// Création des listes pour récupérer les données des tables nécessaires
        /// </summary>
        private List<(int, string, double, double)> Arret = new List<(int, string, double, double)>();
        private List<(int, string, int, int)> Ligne = new List<(int, string, int, int)>();
        private List<(int, string)> Bus = new List<(int, string)>();
        private List<(int, int, int, string)> Horaire = new List<(int, int, int, string)>();

        public PageAjoutHoraire()
        {
            InitializeComponent();

            ClasseBD.LectureArret(ref Arret);
            ClasseBD.LectureLigne(ref Ligne);
            ClasseBD.LectureBus(ref Bus);
            ClasseBD.LectureHoraire(ref Horaire);

            //Afficher une seule fois les noms de ligne dans la combobox
            var nomsLignesUniques = Ligne.Select(l => l.Item2).Distinct();
            foreach (var ligne in nomsLignesUniques)
            {
                comboBoxLigne.Items.Add(ligne);
            }
            ErreurHoraire.Text = "";
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Vérifiier que les champs sont remplies
            if (comboBoxLigne.SelectedIndex == -1 ||
                comboxArret.SelectedIndex == -1 ||
                comboBoxBus.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtBoxHoraire.Text))
            {
                return;
            }
            // Vérification de l'heure (format HH:mm)
            if (!TimeSpan.TryParse(txtBoxHoraire.Text, out TimeSpan horaire))
            {
                ErreurHoraire.Text = "Format d'heure invalide. Utilisez HH:mm ";
            }
            else
            {
                string nomLigne = comboBoxLigne.SelectedItem.ToString();
                string nomArret = comboxArret.SelectedItem.ToString();
                int idArret = Arret.First(a => a.Item2 == nomArret).Item1;
                int idLigne = Ligne.First(l => l.Item2 == nomLigne && l.Item3 == idArret).Item1;
                int idBus = (int)comboBoxBus.SelectedItem;

                ClasseBD.InsertionHoraire(idBus, idArret, idLigne, horaire.ToString(@"hh\:mm"));

                PageModifBd pageModifBd = new PageModifBd();
                pageModifBd.Show();
                this.Close();
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageChoixAjout pagechoixajout = new PageChoixAjout();
            pagechoixajout.Show();
            this.Close();
        }

        private void comboBoxBus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Quand une ligne est sélectionnée, on remplit les différentes combobox
        /// Combobox arrêt avec les deux arrêts de départ disponible pour la ligne
        /// ComboBox Bus avec les Bus passant déjà sur la ligne ou les bus non utilisés sur le reseau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomLigneChoisie = comboBoxLigne.SelectedItem.ToString();

            var idLignesAssocies = Ligne.Where(l => l.Item2 == nomLigneChoisie).Select(l => l.Item1).ToList();

            comboxArret.Items.Clear();
            comboBoxBus.Items.Clear();

            foreach (var idLigne in idLignesAssocies)
            {
                foreach (var arret in Arret)
                {
                    if (Ligne.Any(l => l.Item1 == idLigne && l.Item3 == arret.Item1))
                    {
                        if (!comboxArret.Items.Contains(arret.Item2))
                            comboxArret.Items.Add(arret.Item2);
                    }
                }
            }

            foreach (var bus in Bus)
            {
                bool estUtilisePourLigne = Horaire.Any(h => h.Item1 == bus.Item1 && idLignesAssocies.Contains(h.Item3));
                bool estJamaisUtilise = !Horaire.Any(h => h.Item1 == bus.Item1);

                if (estUtilisePourLigne || estJamaisUtilise)
                {
                    comboBoxBus.Items.Add(bus.Item1);
                }
            }
        }
    }
}

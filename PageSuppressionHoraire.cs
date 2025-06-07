using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_S2._01
{
    public partial class PageSuppressionHoraire : Form
    {
        //Liste des données de la base
        private List<(int, string, int, int)> Ligne = new List<(int, string, int, int)>();
        private List<(int, string, double, double)> Arret = new List<(int, string, double, double)>();
        private List<(int, int, int, string)> Horaire = new List<(int, int, int, string)>();

        public PageSuppressionHoraire()
        {
            InitializeComponent();
            lbLigne.Text = lbHoraire.Text = lbArret.Text = "";
            comboBoxArret.Hide();
            comboBoxHoraire.Hide();
            comboBoxHoraire.Height = 200;
            comboBoxHoraire.Width = 200;
            btnSupprimer.Enabled = false;

            ClasseBD.LectureArret(ref Arret);
            ClasseBD.LectureLigne(ref Ligne);
            ClasseBD.LectureHoraire(ref Horaire);

            //Affiche une fois le nom de la ligne dans la liste
            var nomsLignesUniques = Ligne.Select(l => l.Item2).Distinct();
            foreach (var ligne in nomsLignesUniques)
            {
                lstBoxLigne.Items.Add(ligne);
            }

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageChoixSuppression page = new PageChoixSuppression();
            page.Show();
            this.Close();
        }

        /// <summary>
        /// Si tout les champs sont remplis
        /// On récupère chaque donnée puis on supprime l'horaire de la base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (comboBoxHoraire.SelectedItem != null && lstBoxLigne.SelectedItem != null && comboBoxArret.SelectedItem != null)
            {
                string selectedLigne = lstBoxLigne.SelectedItem.ToString();
                string selectedArret = comboBoxArret.SelectedItem.ToString();
                string selectedHoraire = TimeSpan.Parse(comboBoxHoraire.SelectedItem.ToString()).ToString(@"hh\:mm\:ss");

                // Trouver l'ID de l'arrêt sélectionné
                int arretId = Arret.FirstOrDefault(a => a.Item2 == selectedArret).Item1;
                // Trouver l'ID de la ligne sélectionnée
                int ligneId = Ligne.FirstOrDefault(l => l.Item2 == selectedLigne && l.Item3 == arretId).Item1;

                ClasseBD.SuppressionHoraire(selectedHoraire,arretId,ligneId);

                PageModifBd page = new PageModifBd();
                page.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne, un arrêt et un horaire avant de supprimer.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Quand on sélectionne une ligne dans la liste,
        /// on affiche les informations concernant ces arrêts de départ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBoxLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxLigne.SelectedItem != null)
            {
                lbLigne.Text = $"Ligne sélectionnée : {lstBoxLigne.SelectedItem.ToString()}";
                lbArret.Text = $"Arrêt : ";

                comboBoxArret.Items.Clear();
                comboBoxArret.Show();
                comboBoxHoraire.Hide();

                //On récupère les deux Id de la ligne
                List<(int, string, int, int)> LigneSelect = new List<(int,string,int,int)>();
                foreach (var ligne in Ligne)
                {
                    if (ligne.Item2 == lstBoxLigne.SelectedItem.ToString())
                    {
                        LigneSelect.Add(ligne);
                    }
                }

                //On ajoute dans la combobox les deux arrêts de départ
                foreach (var ligne in LigneSelect)
                {
                    if (Arret.Any(a => a.Item1 == ligne.Item3))
                    {
                        var arret = Arret.First(a => a.Item1 == ligne.Item3);
                        comboBoxArret.Items.Add(arret.Item2);
                    }
                }
            }
        }

        private void comboBoxHoraire_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Quand un arrêt de départ est choisis,
        /// on affiche les horaires correspondant à celui-ci dans une combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxArret.SelectedItem != null)
            {
                lbHoraire.Text = $"Horaire : ";
                comboBoxHoraire.Items.Clear();
                comboBoxHoraire.Show();
                List<(int, int, int, string)> HoraireSelect = new List<(int, int, int, string)>();

                foreach (var horaire in Horaire)
                {
                    if (Arret.Any(a => a.Item1 == horaire.Item2 && a.Item2 == comboBoxArret.SelectedItem.ToString()))
                    {
                        HoraireSelect.Add(horaire);
                    }
                }

                foreach (var horaire in HoraireSelect)
                {
                    comboBoxHoraire.Items.Add(horaire.Item4);
                }
                if (comboBoxHoraire.Items.Count > 0)
                {
                    btnSupprimer.Enabled = true;
                }
            }
        }
    }
}

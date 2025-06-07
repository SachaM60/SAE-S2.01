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
    public partial class PageModificationLigne : Form
    {
        //Liste des données nécessaires de la base
        private List<(int, string, double, double)> Arret = new List<(int, string, double, double)>();
        private List<(int, string, int, int)> Ligne = new List<(int, string, int, int)>();
        private List<(int, int, int)> Suivant = new List<(int, int, int)>();
        private List<(int, int, int, string)> Horaire = new List<(int, int, int, string)>();

        //Premier arrêt de la ligne = arret_dep
        private int IdFirstArret;

        public PageModificationLigne()
        {
            InitializeComponent();

            ClasseBD.LectureArret(ref Arret);
            ClasseBD.LectureLigne(ref Ligne);
            ClasseBD.LectureSuivant(ref Suivant);
            ClasseBD.LectureHoraire(ref Horaire);

            lbNomLigne.Text = "";
            LbArret.Text = "";
            txtBoxNom.Hide();
            NumUpADownNbArret.Hide();

            flpArrets.AutoScroll = true;
            BtnValider.Enabled = false;

            foreach (var item in Ligne)
            {
                lstBoxLigne.Items.Add($"({item.Item1}) {item.Item2}");
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            PageChoixModification pageChoixModification = new PageChoixModification();
            pageChoixModification.Show();
            this.Close();
        }

        /// <summary>
        /// Si la la ligne a un nom et plus de deux arrêts, la ligne est modifié ainsi que toutes ces relations
        /// Sinon un message d'erreur s'affiche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValider_Click(object sender, EventArgs e)
        {
            string nomLigne = lstBoxLigne.SelectedItem?.ToString();
            string nouveauNom = txtBoxNom.Text.Trim();

            if (string.IsNullOrEmpty(nomLigne) || string.IsNullOrEmpty(nouveauNom) || flpArrets.Controls.Count <2)
            {
                MessageBox.Show("Veuillez sélectionner une ligne, entrer un nom valide et ajouter au moins deux arrêts.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int idLigne = int.Parse(lstBoxLigne.SelectedItem.ToString().Substring(1, lstBoxLigne.SelectedItem.ToString().IndexOf(')') - 1));
                List<int> idArret = new List<int>();

                //Récupérer les arrêts sélectionnés
                foreach (ComboBox cb in flpArrets.Controls)
                {
                    if (cb.SelectedItem is string nomArret)
                    {
                        var arret = Arret.FirstOrDefault(a => a.Item2 == nomArret);
                        idArret.Add(arret.Item1);
                    }

                }

                // Mettre à jour la ligne 
                ClasseBD.ModificationLigne(idLigne, nouveauNom, idArret.First(), idArret.Last());

                // Mettre à jour Croisement
                ClasseBD.SuppressionCroisement(idLigne);
                for (int i = 0; i < idArret.Count - 1; i++)
                {
                    ClasseBD.InsertionCroisement(idArret[i], idLigne);
                }

                //Mettre à jour Suivant
                ClasseBD.SuppressionSuivant(idLigne);
                for (int i = 0; i < idArret.Count - 1; i++)
                {
                    int suivantId = idArret[i + 1];
                    ClasseBD.InsertionSuivant(idArret[i], suivantId, idLigne);
                }

                //Mettre à jour Horaire si le premier arrêt de la ligne a été modifié
                foreach (var horaire in Horaire)
                {
                    if (horaire.Item3 == idLigne && horaire.Item2 != idArret[0])
                    {
                        ClasseBD.ModificationHoraireBis(idLigne, idArret.First(), IdFirstArret);
                    }
                }
            }
            PageModifBd pageModifBd = new PageModifBd();
            pageModifBd.Show();
            this.Close();
        }

        /// <summary>
        /// Au changement de ligne dans la liste, on affiche les informations de la ligne sélectionnée
        /// Nom et arrêt par lesquels elle passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBoxLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomLigne = lstBoxLigne.SelectedItem.ToString();
            nomLigne = nomLigne.Substring(nomLigne.IndexOf(' ') + 1);

            //Récupérer l'id = le nombre entre parenthèses
            int idLigne = int.Parse(lstBoxLigne.SelectedItem.ToString().Substring(1, lstBoxLigne.SelectedItem.ToString().IndexOf(')') - 1));

            if (lstBoxLigne.SelectedItem != null)
            {
                BtnValider.Enabled = true;
                lbNomLigne.Text = "Ligne sélectionnée :";
                LbArret.Text = "Arrêts de la ligne :";
                txtBoxNom.Show();
                txtBoxNom.Text = nomLigne;
                AfficherArretsLigne(idLigne);
                NumUpADownNbArret.Show();

                foreach (var arret in Arret)
                {
                    if (flpArrets.Controls[0] is ComboBox cb0 && arret.Item2 == cb0.SelectedItem?.ToString())
                    {
                        IdFirstArret = arret.Item1;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// On affiche des combobox pour chaque arrêt associés à la ligne dans l'odre
        /// </summary>
        /// <param name="idLigne"></param>
        private void AfficherArretsLigne(int idLigne)
        {
            flpArrets.Controls.Clear();

            // Dictionnaire pour un accès rapide id => nom
            Dictionary<int, string> dictionnaireArrets = Arret.ToDictionary(a => a.Item1, a => a.Item2);

            // Récupérer les arrêts utilisés dans la ligne
            List<int> arretsLigne = new();
            ClasseBD.LectureArretsDeLaLigne(idLigne, ref arretsLigne);

            // Ajouter les ComboBox dans le FlowLayoutPanel
            foreach (int idArret in arretsLigne)
            {
                ComboBox cb = new ComboBox();
                cb.DropDownHeight = 200;
                cb.DropDownWidth = 300;
                cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
                cb.DropDownStyle = ComboBoxStyle.DropDownList;

                // Ajouter tous les arrêts dans la ComboBox
                foreach (var arret in Arret)
                {
                    cb.Items.Add(arret.Item2);
                }

                // Sélectionner l’arrêt actuel
                if (dictionnaireArrets.TryGetValue(idArret, out string nomArret))
                {
                    cb.SelectedItem = nomArret;
                }

                // Ajouter la ComboBox au FlowLayoutPanel
                flpArrets.Controls.Add(cb);

            }
            // Mettre à jour la valeur du NumericUpDown
            NumUpADownNbArret.Value = arretsLigne.Count;
        }

        /// <summary>
        /// Quand le NumUpDown change de valeur, on ajoute ou supprime des combobox
        /// On les places après les arrêts déjà existant ou on supprime les dernières
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumUpADownNbArret_ValueChanged(object sender, EventArgs e)
        {
            int nombreArrets = (int)NumUpADownNbArret.Value;
            int nombreActuel = flpArrets.Controls.Count;
            if (nombreArrets > nombreActuel)
            {
                /* Ajouter des ComboBox si nécessaire
                 * ( quand on change de ligne la méthode détecte un changement de valeur alors qu'on veut seulement
                 * ajouter les lignes de l'arrêt donc on vérifie que l'on n'est pas dans ce cas) */
                for (int i = nombreActuel; i < nombreArrets; i++)
                {
                    ComboBox cb = new ComboBox();
                    cb.DropDownHeight = 200;
                    cb.DropDownWidth = 300;
                    cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cb.AutoCompleteSource = AutoCompleteSource.ListItems;
                    cb.DropDownStyle = ComboBoxStyle.DropDownList;
                    // Ajouter tous les arrêts dans la ComboBox
                    foreach (var arret in Arret)
                    {
                        cb.Items.Add(arret.Item2);
                    }

                    // Ajouter la ComboBox au FlowLayoutPanel
                    flpArrets.Controls.Add(cb);
                }
            }
            else if (nombreArrets < nombreActuel)
            {
                // Supprimer les ComboBox en trop
                for (int i = nombreActuel - 1; i >= nombreArrets; i--)
                {
                    flpArrets.Controls.RemoveAt(i);
                }
            }
        }
    }
}

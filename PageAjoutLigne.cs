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

namespace SAE_S2._01
{
    public partial class PageAjoutLigne : Form
    {
        //Liste des arrêts de la table
        private List<(int, string, double, double)> Arret = new List<(int, string, double, double)>();

        public PageAjoutLigne()
        {
            InitializeComponent();
            lbArret.Text = "";
            btnValider.Enabled = false;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageChoixAjout pagechoixajout = new PageChoixAjout();
            pagechoixajout.Show();
            this.Close();
        }

        /// <summary>
        /// Ajoute la ligne dans la base ainsi que de remplir les tables associés :
        /// Suivant pour les prédécesseurs de chaque arrêt pour la ligne
        /// Croisement pour tout les arrêts de la ligne
        /// On répète l'opération une deuxième fois mais dans le sens inverse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            List<int> idArrets = new List<int>();

            foreach (ComboBox cb in flpArret.Controls)
            {
                string nomArret = cb.SelectedItem.ToString();
                var arretTrouve = Arret.Find(a => a.Item2 == nomArret);
                idArrets.Add(arretTrouve.Item1);
            }

            // Insertion de la ligne (avec premier et dernier arrêt)
            int idLigne = ClasseBD.InsertionLigne(txtBoxNom.Text, idArrets.First(), idArrets.Last());

            // Insertion dans la table Suivant
            for (int i = 0; i < idArrets.Count - 1; i++)
            {
                ClasseBD.InsertionSuivant(idArrets[i], idArrets[i + 1], idLigne);
            }

            // Insertion dans la table Croisement
            foreach (int idArret in idArrets)
            {
                ClasseBD.InsertionCroisement(idArret, idLigne);
            }

            // Insertion de la ligne dans l'autre sens
            idLigne = ClasseBD.InsertionLigne(txtBoxNom.Text, idArrets.Last(), idArrets.First());

            // Insertion dans la table Suivant pour l'autre sens
            for (int i = idArrets.Count - 1; i > 0; i--)
            {
                ClasseBD.InsertionSuivant(idArrets[i], idArrets[i - 1], idLigne);
            }
            // Insertion dans la table Croisement pour l'autre sens
            foreach (int idArret in idArrets)
            {
                ClasseBD.InsertionCroisement(idArret, idLigne);
            }

            PageModifBd pagemodifbd = new PageModifBd();
            pagemodifbd.Show();
            this.Close();
        }

        /// <summary>
        /// Création  de combobox selon la valeur du NumericUpDown
        /// Chaque combobox est rempli avec tout les arrêts de la base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownNbArret_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownNbArret.Value > 0)
            {
                lbArret.Text = " Choisir les arrêts : ";
            }
            else { lbArret.Text = ""; }
            int compt = (int)numericUpDownNbArret.Value;

            if (compt > flpArret.Controls.Count)
            {
                for (int j = flpArret.Controls.Count; j < (compt); j++)
                {
                    ComboBox ListeLigne = new ComboBox();
                    ClasseBD.LectureArret(ref Arret);
                    foreach (var item in Arret)
                    {
                        ListeLigne.Items.Add(item.Item2);
                    }
                    ListeLigne.DropDownHeight = 200;
                    ListeLigne.DropDownWidth = 200;
                    ListeLigne.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    ListeLigne.AutoCompleteSource = AutoCompleteSource.ListItems;
                    flpArret.Controls.Add(ListeLigne);
                }
            }
            else
            {
                for (int i = flpArret.Controls.Count; i > (compt); i--)
                {
                    flpArret.Controls.RemoveAt(flpArret.Controls.Count - 1);
                }

            }

            if (numericUpDownNbArret.Value >= 2)
            {
                btnValider.Enabled = true;
            }
            else
            {
                btnValider.Enabled = false;
            }
        }

        private void flpArret_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBoxNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

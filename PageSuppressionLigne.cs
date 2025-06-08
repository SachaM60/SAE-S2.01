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
    public partial class PageSuppressionLigne : Form
    {

        private List<(int, string, int, int)> Ligne = new List<(int, string, int, int)>();
        private List<string> NomsLignes = new List<string>();

        public PageSuppressionLigne()
        {
            InitializeComponent();
            lbInfo.Text = "";
            lbDepart.Text = "";
            lbId.Text = "";
            lbNom.Text = "";
            lbTerminus.Text = "";

            // Charger les lignes depuis la base
            ClasseBD.LectureLigne(ref Ligne);

            // Créer une liste formatée à afficher dans la ListBox
            List<string> affichageLignes = new List<string>();
            foreach (var ligne in Ligne)
            {
                string affichage = $"{ligne.Item2} ({ligne.Item1}) ";
                affichageLignes.Add(affichage);
            }

            lstBoxLigne.DataSource = affichageLignes;
            btnSupprimer.Enabled = false;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageChoixSuppression page = new PageChoixSuppression();
            page.Show();
            this.Close();
        }

        /// <summary>
        /// Si une ligne a été sélectionnée, on supprime la ligne et ces références de la base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            if (lstBoxLigne.SelectedIndex >= 0)
            {
                var ligneSelectionnee = Ligne[lstBoxLigne.SelectedIndex];
                ClasseBD.SuppressionLigne(ligneSelectionnee.Item1);

                PageModifBd page = new PageModifBd();
                page.Show();
                this.Close();
            }

        }

        /// <summary>
        /// Au choix d'une ligne dans la liste, on affiche toutes ces informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBoxLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxLigne.SelectedItem != null)
            {
                btnSupprimer.Enabled = true;

                if (lstBoxLigne.SelectedIndex >= 0)
                {
                    btnSupprimer.Enabled = true;
                    var ligneSelectionnee = Ligne[lstBoxLigne.SelectedIndex];

                    lbInfo.Text = "Informations de la ligne";
                    lbDepart.Text = $"Départ : {ligneSelectionnee.Item3}";
                    lbId.Text = $"ID : {ligneSelectionnee.Item1}";
                    lbNom.Text = $"Nom : {ligneSelectionnee.Item2}";
                    lbTerminus.Text = $"Terminus : {ligneSelectionnee.Item4}";
                }
            }
        }
    }
}

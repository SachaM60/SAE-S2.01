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
    public partial class PageSuppressionArret : Form
    {
        //Liste des données de la base
        private List<(int, string, double, double)> Arret = new List<(int, string, double, double)>();
        private List<(int,string,int,int)> Ligne = new List<(int, string, int, int)>();
        private List<(int,int)> Croisement = new List<(int, int)>();

        public PageSuppressionArret()
        {
            InitializeComponent();

            lbArret.Text = "";
            lbLigne.Text = "";
            lbErreur.Text = "";
            btnSupprimer.Enabled = false;

            ClasseBD.LectureArret(ref Arret);
            ClasseBD.LectureLigne(ref Ligne);
            ClasseBD.LectureCroisement(ref Croisement);

            List<string> affichageArrets = new List<string>();
            foreach (var arret in Arret)
            {
                affichageArrets.Add($"{arret.Item2}");
            }

            lstBoxArret.DataSource = affichageArrets;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageChoixSuppression page = new PageChoixSuppression();
            page.Show();
            this.Close();
        }

        /// <summary>
        /// On supprime l'arrêt si il n'y a pas d'erreur sinon on reste sur la page
        /// Le message d'erreur se produit dans la méthode de suppression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            (int,string,double,double)arretselectionne = (-1,"",-1,-1);
            foreach (var arret in Arret)
            {
                if (lstBoxArret.SelectedItem.ToString() == arret.Item2)
                {
                    arretselectionne = arret;
                }
            }
            lbErreur.Text = ClasseBD.SuppressionArret(arretselectionne.Item1);
            if (lbErreur.Text == "")
            {
                PageModifBd page = new PageModifBd();
                page.Show();
                this.Close();
            }
        }

        /// <summary>
        /// Quand un arrêt est choisis, on affiche les lignes qui passent par celui-ci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBoxArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            (int, string, double, double) arretselectionne = (0,"",0,0);
            lbErreur.Text = "";

            if (lstBoxArret.SelectedItem != null)
            {
                btnSupprimer.Enabled = true;
                lbArret.Text = $"Arret sélectionné : {lstBoxArret.SelectedItem.ToString()}";
                lbLigne.Text = "Ligne associée : ";

                flpLigne.Controls.Clear();

                //On récupère toutes les données de l'arrêt sélectionnée
                foreach (var arret in Arret)
                {
                    if (lstBoxArret.SelectedItem.ToString() == arret.Item2)
                    {
                        arretselectionne = arret;
                    }
                }
                
                //On récupère et affiche les lignes qui se croisent avec l'arrêt
                foreach (var croisement in Croisement)
                {
                    if (arretselectionne.Item1 == croisement.Item1)
                    {
                        foreach (var ligne in Ligne)
                        {
                            if (ligne.Item1 == croisement.Item2)
                            {
                                Label label = new Label();
                                label.Text = $"{ligne.Item2}";
                                label.AutoSize = true;
                                flpLigne.Controls.Add(label);
                            }
                        }
                    }
                }
            }
        }
    }
}

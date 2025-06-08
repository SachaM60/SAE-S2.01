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
    public partial class PageTrajetsFavoris : Form
    {
        //Liste des données nécessaires pour gérer les favoris d'un utilisateur
        private List<(int,string,int,int)> Ligne = new List<(int, string, int, int)>();
        private List<(string,int)> Favori = new List<(string, int)>();
        public PageTrajetsFavoris()
        {
            InitializeComponent();
            ClasseBD.LectureLigne(ref Ligne);
            ClasseBD.LectureFavori(ref Favori);

            var favorisUser = Favori
            .Where(fav => fav.Item1 == ClasseBD.UserConnect.Item1)
            .Select(fav => fav.Item2)
            .ToList();

            //Remplissage des deux listes box selon les favoris déjà enregistrés de l'utilisateur
            foreach (var ligne in Ligne)
            {
                if (favorisUser.Contains(ligne.Item1))
                {
                    if (!listFav.Items.Contains(ligne.Item2))
                        listFav.Items.Add(ligne.Item2);
                }
                else
                {
                    if (!listDispo.Items.Contains(ligne.Item2))
                        listDispo.Items.Add(ligne.Item2);
                }
            }

            listDispo.MouseDoubleClick += DispoToFav;
            listFav.MouseDoubleClick += FavToDispo;
        }

        /// <summary>
        /// Déplace une ligne des favoris vers les lignes disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FavToDispo(object sender, EventArgs e)
        {
            if (listFav.SelectedItem != null)
            {
                listDispo.Items.Add(listFav.SelectedItem);
                listFav.Items.Remove(listFav.SelectedItem);
            }
        }

        /// <summary>
        /// Déplace une ligne disponibles vers les favoris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DispoToFav(object sender, MouseEventArgs e)
        {
            if (listDispo.SelectedItem != null)
            {
                listFav.Items.Add(listDispo.SelectedItem);
                listDispo.Items.Remove(listDispo.SelectedItem);
            }
        }

        /// <summary>
        /// Au changement de page, les favoris sont modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (listFav.Items.Count > 0)
            {
                ClasseBD.SuppressionFavori();
                foreach (var item in listFav.Items)
                {
                    ClasseBD.ModificationFavori(ClasseBD.UserConnect.Item1, item.ToString());
                }
            }
            else if (listFav.Items.Count == 0)
            {
                ClasseBD.SuppressionFavori();
            }
            
            PageMenuPrincipal pageMenuPrincipal = new PageMenuPrincipal();
            pageMenuPrincipal.Show();
            this.Close();
        }

        /// <summary>
        /// Au changement de page, les favoris sont modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculItinéraire_Click(object sender, EventArgs e)
        {
            if (listFav.Items.Count > 0)
            {
                ClasseBD.SuppressionFavori();
                foreach (var item in listFav.Items)
                {
                    ClasseBD.ModificationFavori(ClasseBD.UserConnect.Item1, item.ToString());
                }
            }

            PageCalculItineraire pageCalculItineraire = new PageCalculItineraire();
            pageCalculItineraire.Show();
            this.Close();
        }

        /// <summary>
        /// Au changement de page, les favoris sont modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlan_Click(object sender, EventArgs e)
        {
            if (listFav.Items.Count > 0)
            {
                ClasseBD.SuppressionFavori();
                foreach (var item in listFav.Items)
                {
                    ClasseBD.ModificationFavori(ClasseBD.UserConnect.Item1, item.ToString());
                }
            }

            PagePlanDuReseau pagePlanDuReseau = new PagePlanDuReseau();
            pagePlanDuReseau.Show();
            this.Close();
        }
    }
}
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
        public PageTrajetsFavoris()
        {
            InitializeComponent();
            ConfigListes();
        }

        private void ConfigListes()
        {
            // BD non utilisée
            listDispo.Items.AddRange(new string[] {
                "Ligne 9",
                "Ligne 10",
                "Ligne 11",
                "Ligne 12",
                "Ligne 13",
                "Ligne 14",
                "Ligne 15",
                "Ligne 16",
                "Ligne 17",
                "Ligne 18",
                "Ligne 19",
                "Ligne 20",
                "Ligne 21",
                "Ligne 22",
                "Ligne 11 Express",
            });

            listDispo.MouseDoubleClick += DispoToFav;
            listFav.MouseDoubleClick += FavToDispo;
        }

        private void FavToDispo(object sender, EventArgs e)
        {
            if (listFav.SelectedItem != null)
            {
                listDispo.Items.Add(listFav.SelectedItem);
                listFav.Items.Remove(listFav.SelectedItem);
            }
        }

        private void DispoToFav(object sender, MouseEventArgs e)
        {
            if (listDispo.SelectedItem != null)
            {
                listFav.Items.Add(listDispo.SelectedItem);
                listDispo.Items.Remove(listDispo.SelectedItem);
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            PageMenuPrincipal pageMenuPrincipal = new PageMenuPrincipal();
            pageMenuPrincipal.Show();
            this.Close();
        }

        private void btnCalculItinéraire_Click(object sender, EventArgs e)
        {
            PageCalculItineraire pageCalculItineraire = new PageCalculItineraire();
            pageCalculItineraire.Show();
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
    }
}
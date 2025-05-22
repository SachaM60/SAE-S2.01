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
    public partial class PageMenuPrincipal : Form
    {
        public PageMenuPrincipal()
        {
            InitializeComponent();
        }

        private void picAccueilMenu_Click(object sender, EventArgs e)
        {
            PageAccueil pageAccueil = new PageAccueil();
            pageAccueil.Show();
            this.Close();
        }

        private void btnFavoris_Click(object sender, EventArgs e)
        {
            PageTrajetsFavoris pageTrajetsFavoris = new PageTrajetsFavoris();
            pageTrajetsFavoris.Show();
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

        private void picAdmin_Click(object sender, EventArgs e)
        {
            PageMenuAdmin pageMenuAdmin = new PageMenuAdmin();
            pageMenuAdmin.Show();
            this.Close();
        }
    }
}

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
            picAdmin.Visible = false;
            if (string.IsNullOrEmpty( (ClasseBD.UserConnect).Item1 ) )
            {
                btnFavoris.Enabled = false;
            }
            else
            {
                btnFavoris.Enabled = true;
                if (ClasseBD.UserConnect.Item2 == 1) { picAdmin.Visible = true; }
            }
        }

        private void picAccueilMenu_Click(object sender, EventArgs e)
        {
            ClasseBD.UserConnect = ("", 0);
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

        /// <summary>
        /// Demande de saisie de mot de passe Administrateur pour vérifier si il s'agit bien d'un admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picAdmin_Click(object sender, EventArgs e)
        {
            string password = Microsoft.VisualBasic.Interaction.InputBox("Veuillez saisir le mot de passe administrateur :", "Accès Administrateur", "", -1, -1);
           
            if (password != "admin")
            {
                MessageBox.Show("Mot de passe incorrect. Accès refusé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                PageMenuAdmin pageMenuAdmin = new PageMenuAdmin();
                pageMenuAdmin.Show();
                this.Close();
            }
        }
    }
}

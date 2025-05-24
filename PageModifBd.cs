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
    public partial class PageModifBd : Form
    {
        public PageModifBd()
        {
            InitializeComponent();
        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {
            PageMenuPrincipal pageMenuPrincipal = new PageMenuPrincipal();
            pageMenuPrincipal.Show();
            this.Close();
        }

        private void picAccueil_Click(object sender, EventArgs e)
        {
            PageAccueil pageAccueil = new PageAccueil();
            pageAccueil.Show();
            this.Close();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            PageChoixAjout pageChoixAjout = new PageChoixAjout();
            pageChoixAjout.Show();
            this.Close();
        }

        private void btnSuppression_Click(object sender, EventArgs e)
        {
            PageChoixSuppression pageSuppressionDeDonnées = new PageChoixSuppression();
            pageSuppressionDeDonnées.Show();
            this.Close();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            PageChoixModification pageModificationDeDonnées = new PageChoixModification();
            pageModificationDeDonnées.Show();
            this.Close();
        }
    }
}

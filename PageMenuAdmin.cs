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
    public partial class PageMenuAdmin : Form
    {
        /// <summary>
        /// Page accessible uniquement par un admin
        ///     Peut retourner sur l'application ou modifier la base de donnée
        /// </summary>
        public PageMenuAdmin()
        {
            InitializeComponent();
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            PageAccueil pageAccueil = new PageAccueil();
            pageAccueil.Show();
            this.Close();
        }

        private void btnAccesAppli_Click(object sender, EventArgs e)
        {
            PageMenuPrincipal pageMenuPrincipal = new PageMenuPrincipal();
            pageMenuPrincipal.Show();
            this.Close();
        }

        private void btnAccesBD_Click(object sender, EventArgs e)
        {
            PageModifBd pageModifBd = new PageModifBd();
            pageModifBd.Show();
            this.Close();
        }
    }
}

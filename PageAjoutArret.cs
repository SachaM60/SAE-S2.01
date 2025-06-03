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
    public partial class PageAjoutArret : Form
    {
        public PageAjoutArret()
        {
            InitializeComponent();
            lbErreurLat.Text = "";
            lbErreurLong.Text = "";
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageChoixAjout pagechoixajout = new PageChoixAjout();
            pagechoixajout.Show();
            this.Close();
        }

        /// <summary>
        /// Vérifie que les coordonnées sont correctement saisies et affiche ou non un message d'erreur
        /// Si tout est bon l'arrêt est insérer dans la base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            double latitude, longitude;
            bool latOk = double.TryParse(txtBoxLatitude.Text, out latitude);
            bool longOk = double.TryParse(txtBoxLongitude.Text, out longitude);

            if (!latOk)
            {
                lbErreurLat.Text = "Latitude invalide.";
            }

            if (!longOk)
            {
                lbErreurLong.Text = "Longitude invalide.";
            }

            if (latOk && longOk)
            {
                ClasseBD.InsertionArret(txtBoxNom.Text, latitude, longitude);
                PageModifBd pagemodifbd = new PageModifBd();
                pagemodifbd.Show();
                this.Close();
            }
        }

        private void numericUpDownNbLigne_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}

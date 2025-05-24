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

        private List<string> test = ["Valeur 1", "Valeur 2", "Je t'emmerde", "Faudra enlever"];
        public PageSuppressionArret()
        {
            InitializeComponent();
            lbArret.Text = "";
            lbLigne.Text = "";
            lstBoxArret.DataSource = test;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageChoixSuppression page = new PageChoixSuppression();
            page.Show();
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Supprimer tout ce qui concecerne l'arrêt et modifier suivant en conséquence ( Avant : 2->5 ; 5->10 / Après : 2->10 )
            PageModifBd page = new PageModifBd();
            page.Show();
            this.Close();
        }

        private void lstBoxArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomArret = "L'arret sélectionné";

            if (lstBoxArret.SelectedIndex != 0)
            {
                lbArret.Text = $"Arrêt sélectionné : {nomArret}";
                lbLigne.Text = "Ligne désservie : ";
            }
        }
    }
}

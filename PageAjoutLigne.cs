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
    public partial class PageAjoutLigne : Form
    {
        public PageAjoutLigne()
        {
            InitializeComponent();
            lbArret.Text = "";
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageChoixAjout pagechoixajout = new PageChoixAjout();
            pagechoixajout.Show();
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //Commande de BD pour ajouter dans Ligne et suivant
            PageModifBd pagemodifbd = new PageModifBd();
            pagemodifbd.Show();
            this.Close();
        }

        private void numericUpDownNbArret_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownNbArret.Value > 0)
            {
                lbArret.Text = " Choisir les arrêts : ";
            }
            else { lbArret.Text = ""; }
            int compt = (int)numericUpDownNbArret.Value;

            if (compt > flpArret.Controls.Count)
            {
                for (int j = flpArret.Controls.Count; j < (compt); j++)
                {
                    ComboBox ListeLigne = new ComboBox();
                    //Commande de BD à faire pour remplir les ComboBox avec les arret de la base
                    flpArret.Controls.Add(ListeLigne);
                }
            }
            else
            {
                for (int i = flpArret.Controls.Count; i > (compt); i--)
                {
                    flpArret.Controls.RemoveAt(flpArret.Controls.Count - 1);
                }

            }
        }
    }
}

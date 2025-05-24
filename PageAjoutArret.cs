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
            lbLigne.Text = "";
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageChoixAjout pagechoixajout = new PageChoixAjout();
            pagechoixajout.Show();
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //Commande de BD pour Ajouter les infos récolter dans arrêt et croisement
            PageModifBd pagemodifbd = new PageModifBd();
            pagemodifbd.Show();
            this.Close();
        }

        private void numericUpDownNbLigne_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownNbLigne.Value > 0)
            {
                lbLigne.Text = "Lesquelles : ";
            }
            else { lbLigne.Text = ""; }
            int compt = (int)numericUpDownNbLigne.Value;

            if (compt > flpLigne.Controls.Count)
            {
                for (int j = flpLigne.Controls.Count; j < (compt); j++)
                {
                    ComboBox ListeLigne = new ComboBox();
                    //Commande de BD à faire pour remplir les ComboBox
                    flpLigne.Controls.Add(ListeLigne);
                }
            }
            else
            {
                for (int i = flpLigne.Controls.Count; i > (compt); i--)
                {
                    flpLigne.Controls.RemoveAt(flpLigne.Controls.Count - 1);
                }

            }
        }
    }
}

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
    public partial class PageSuppressionLigne : Form
    {

        private List<string> test = ["Valeur 1","Valeur 2","Je t'emmerde","Faudra enlever"];
        public PageSuppressionLigne()
        {
            InitializeComponent();
            lbInfo.Text = "";
            lbDepart.Text = "";
            lbDepartBD.Text = "";
            lbId.Text = "";
            lbIdBD.Text = "";
            lbNom.Text = "";
            lbNomBD.Text = "";
            lbTerminus.Text = "";
            lbTerminusBD.Text = "";
            //Faudra définir avec une requête SQL le contenu de la listbox
            lstBoxLigne.DataSource = test;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageChoixSuppression page = new PageChoixSuppression();
            page.Show();
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Mettre les commandes SQL pour supprimer la ligne de toutes les tables ou elle apparaît
            PageModifBd page = new PageModifBd();
            page.Show();
            this.Close();
        }

        private void lstBoxLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxLigne.SelectedIndex != 0)
            {
                //Les lb qui finissent avec BD ont besoin d'une requête SQL pour afficherles infos dans la base
                lbInfo.Text = "Informations de la ligne";
                lbDepart.Text = " Départ : ";
                lbDepartBD.Text = "";
                lbId.Text = " id : ";
                lbIdBD.Text = "";
                lbNom.Text = " Nom : ";
                lbNomBD.Text = "";
                lbTerminus.Text = "Terminus : ";
                lbTerminusBD.Text = "";
            }
        }
    }
}

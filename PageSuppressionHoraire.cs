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
    public partial class PageSuppressionHoraire : Form
    {

        private List<string> test = ["Valeur 1", "Valeur 2", "Je t'emmerde", "Faudra enlever"];
        public PageSuppressionHoraire()
        {
            InitializeComponent();
            lbLigne.Text = "";
            lbHoraire.Text = "";
            lbArret.Text = "";
            comboBoxArret.Hide();
            comboBoxHoraire.Hide();
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
            PageModifBd page = new PageModifBd();
            page.Show();
            this.Close();
        }

        private void lstBoxLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomligne = "nom";
            if (lstBoxLigne.SelectedIndex != 0)
            {
                lbLigne.Text = $"Ligne sélectionnée : {nomligne}";
                lbArret.Text = "Arrêt : ";
                lbHoraire.Text = "Horaire : ";
                comboBoxHoraire.Show();
                comboBoxArret.Show();
            }
        }
    }
}

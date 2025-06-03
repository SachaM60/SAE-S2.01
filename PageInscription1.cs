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
    public partial class PageInscription1 : Form
    {
        public PageInscription1()
        {
            InitializeComponent();
            comboBoxSexe.Items.Add("Homme");
            comboBoxSexe.Items.Add("Femme");
            comboBoxSexe.Items.Add("Autre");
        }

        private void btnRetourInscription_Click(object sender, EventArgs e)
        {
            PageChoixConnexion pageChoixConnexion = new PageChoixConnexion();
            pageChoixConnexion.Show();
            this.Close();

        }

        /// <summary>
        /// On vérifie que tout les champs sont valides
        /// Si des champs sont vides, on affiche un message d'erreur
        /// Si l'utilisateur est trop jeune on le renvoit à l'accueil
        /// Sinon on passe à la suite de l'inscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValiderInscription_Click(object sender, EventArgs e)
        {
            if (txtNomInscription.Text == "" || txtPrenomInscription.Text == "" || comboBoxSexe.SelectedItem == null || numAgeInscription.Value < 12)
            {
                if (numAgeInscription.Value < 12)
                {
                    //Message d'erreur qui renvoie au MenuPrincipal
                    MessageBox.Show("Vous êtes trop jeune !", "Erreur d'inscription", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PageAccueil pageAccueil = new PageAccueil();
                    pageAccueil.Show();
                    this.Close();
                }
                return;
            }
            else
            {
                PageInscription2 pageInscription2 = new PageInscription2(txtNomInscription.Text,txtPrenomInscription.Text,comboBoxSexe.SelectedItem.ToString(),(int)numAgeInscription.Value);
                pageInscription2.Show();
                this.Close();
            }
        }
    }
}

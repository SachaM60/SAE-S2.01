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

    public partial class PageConnexion : Form
    {
        private List<(string, string, string, string, string, int)> Utilisateur = new List<(string, string, string, string, string, int)>();

        public PageConnexion()
        {
            InitializeComponent();
            ClasseBD.LectureUtilisateur(ref Utilisateur);
            lbErreurId.Text = "";
            lbErreurMdp.Text = "";
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageChoixConnexion pageChoixConnexion = new PageChoixConnexion();
            pageChoixConnexion.Show();
            this.Close();
        }

        private void btnValiderConnexion_Click(object sender, EventArgs e)
        {
            string username = txtIdentifiantConnexion.Text;
            string password = txtMotDePasseConnexion.Text;

            lbErreurId.Text = "";
            lbErreurMdp.Text = "";

            if (string.IsNullOrEmpty(username))
            {
                lbErreurId.Text = "Veuillez entrer un identifiant.";
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                lbErreurMdp.Text = "Veuillez entrer un mot de passe.";
                return;
            }

            foreach (var user in Utilisateur)
            {
                if (user.Item1 == username && user.Item4 == password)
                {
                    ClasseBD.UserConnect = user.Item1;

                    DialogResult result = MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        PageMenuPrincipal menu = new PageMenuPrincipal();
                        menu.Show();
                        this.Close();
                    }
                }

                else if (Utilisateur.Any(u => u.Item1 == username) == false)
                {
                    lbErreurId.Text = "Identifiant incorrect.";
                    lbErreurMdp.Text = "";
                }

                else if (user.Item1 == username)
                {
                    lbErreurMdp.Text = "Mot de passe incorrect.";
                    lbErreurId.Text = "";
                }
            }

        }
    }
}

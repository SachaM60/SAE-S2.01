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
    public partial class PageInscription2 : Form
    {
        //Donnée de la page d'inscription précédente
        private string nom;
        private string prenom;
        private string sexe;
        private int age;

        //Liste des utilisateur déjà existant dans la base
        private static List<(string,string,string,string,string,int,int)> Utilisateur = new List<(string, string, string, string, string, int,int)>();

        public PageInscription2(string nom, string prenom, string sexe, int age)
        {
            InitializeComponent();
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.age = age;

            ClasseBD.LectureUtilisateur(ref Utilisateur);

            lbErreurId.Text = "";
            lbErreurMdp.Text = "";
        }

        private void btnRetourInscription2_Click(object sender, EventArgs e)
        {
            PageInscription1 pageInscription1 = new PageInscription1();
            pageInscription1.Show();
            this.Close();
        }

        /// <summary>
        /// Ajout de l'utilisateur dans la base si tout est valide et redirection vers l'application
        /// Vérifiaction :
        ///     -Id déjà dans la base ( Id doit être unique)
        ///     -Chaque champ est rempli
        ///     Affichage d'un message d'erreur selon le problème rencontré
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider2_Click(object sender, EventArgs e)
        {
            lbErreurId.Text = "";
            lbErreurMdp.Text = "";

            if (txtIdentifiant.Text == "" || txtMotDePasse.Text == "")
            {
                if (txtIdentifiant.Text == "")
                {
                    lbErreurId.Text = "Veuillez saisir un identifiant";
                }

                if (txtMotDePasse.Text == "")
                {
                    lbErreurMdp.Text = "Veuillez saisir un mot de passe";
                }
            }
            else
            {
                foreach (var utilisateur in Utilisateur)
                {
                    if (utilisateur.Item1 == txtIdentifiant.Text)
                    {
                        lbErreurId.Text = "Identifiant déjà utilisé";
                        return;
                    }
                }

                ClasseBD.InsertionUtilisateur(txtIdentifiant.Text,nom,prenom,txtMotDePasse.Text,sexe,age);
                PageChoixConnexion pageChoixConnexion = new PageChoixConnexion();
                pageChoixConnexion.Show();
                this.Close();
            }
        }
    }
}

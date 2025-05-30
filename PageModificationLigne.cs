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
    public partial class PageModificationLigne : Form
    {
        private List<(int, string, double, double)> Arret = new List<(int, string, double, double)>();
        private List<(int, string, int, int)> Ligne = new List<(int, string, int, int)>();
        private List<(int,int,int)> Suivant = new List<(int, int, int)>();

        public PageModificationLigne()
        {
            InitializeComponent();

            ClasseBD.LectureArret(ref Arret);
            ClasseBD.LectureLigne(ref Ligne);
            ClasseBD.LectureSuivant(ref Suivant);

            lbNomLigne.Text = "";
            LbArret.Text = "";
            txtBoxNom.Hide();
            NumUpADownNbArret.Hide();

            foreach (var item in Ligne)
            {
                lstBoxLigne.Items.Add($"({item.Item1}) {item.Item2}");
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            PageChoixModification pageChoixModification = new PageChoixModification();
            pageChoixModification.Show();
            this.Close();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            PageModifBd pageModifBd = new PageModifBd();
            pageModifBd.Show();
            this.Close();
        }

        private void lstBoxLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomLigne = lstBoxLigne.SelectedItem.ToString();

            if (lstBoxLigne.SelectedItem != null)
            {
                lbNomLigne.Text = "Ligne sélectionnée :";
                LbArret.Text = "Arrêts de la ligne :";
                txtBoxNom.Show();
                txtBoxNom.Text = nomLigne;
                NumUpADownNbArret.Show();
            }
        }
    }
}

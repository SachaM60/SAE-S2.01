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
    public partial class PageModificationHoraire : Form
    {
        private List<(int, string, int, int)> Ligne = new List<(int, string, int, int)>();
        private List<(int, string, double, double)> Arret = new List<(int, string, double, double)>();
        private List<(int, int, int, string)> Horaire = new List<(int, int, int, string)>();

        public PageModificationHoraire()
        {
            InitializeComponent();

            LblSelectionHoraire.Text = "";
            lbHoraire.Text = "";
            lbArret.Text = "";
            ComboBoxHoraires.Hide();
            comboBoxArret.Hide();
            NumUpADownHeure.Hide();
            NumUpADownMinute.Hide();

            ClasseBD.LectureLigne(ref Ligne);
            ClasseBD.LectureHoraire(ref Horaire);
            ClasseBD.LectureArret(ref Arret);

            foreach (var ligne in Ligne)
            {
                if (!ComboBoxLigne.Items.Contains(ligne.Item2))
                {
                    ComboBoxLigne.Items.Add(ligne.Item2);
                }
            }

        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            PageChoixModification pageChoixModification = new PageChoixModification();
            pageChoixModification.Show();
            this.Hide();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxLigne.SelectedItem != null)
            {
                lbArret.Text = "Arrêt de départ : ";
                foreach (var ligne in Ligne)
                {
                    if (ligne.Item2 == ComboBoxLigne.SelectedItem.ToString())
                    {
                        if (Arret.Any(a => a.Item1 == ligne.Item3))
                        {
                            var arret = Arret.First(a => a.Item1 == ligne.Item3);
                            if (!comboBoxArret.Items.Contains(arret.Item2))
                            {
                                comboBoxArret.Items.Add(arret.Item2);
                            }
                        }
                    }
                }
            }
        }

        private void comboBoxArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxArret.SelectedItem != null)
            {
                LblSelectionHoraire.Text = "Selectionner l'horaire à modifier : ";
                ComboBoxHoraires.Show();
                lbHoraire.Text = "Nouvel Horaire : ";
                NumUpADownHeure.Show();
                NumUpADownMinute.Show();
            }
        }
    }
}

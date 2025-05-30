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
            BtnValider.Enabled = false;

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
            int idarret = 0;
            foreach (var arret in Arret)
            {
                if (arret.Item2 == comboBoxArret.SelectedItem.ToString())
                {
                    idarret = arret.Item1;
                    break;
                }
            }

            int idligne = 0;
            foreach (var ligne in Ligne)
            {
                if (ligne.Item2 == ComboBoxLigne.SelectedItem.ToString() && ligne.Item3==idarret)
                {
                    idligne = ligne.Item1;
                    break;
                }
            }
            string Newhoraire = NumUpADownHeure.Value.ToString() + ":" + NumUpADownMinute.Value.ToString();
            string oldhoraire = ComboBoxHoraires.SelectedItem.ToString();
            ClasseBD.ModificationHoraire(oldhoraire,Newhoraire,idarret,idligne);
            PageChoixModification pageChoixModification = new PageChoixModification();
            pageChoixModification.Show();
            this.Close();
        }

        private void ComboBoxLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxLigne.SelectedItem != null)
            {
                lbArret.Text = "Arrêt de départ : ";
                comboBoxArret.Items.Clear();
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
                comboBoxArret.Show();
            }
        }

        private void comboBoxArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxHoraires.Items.Clear();
            if (comboBoxArret.SelectedItem != null)
            {
                List<int> idLigne = new List<int>();
                foreach (var ligne in Ligne)
                {
                    if (ligne.Item2 == ComboBoxLigne.SelectedItem.ToString())
                    {
                        idLigne.Add(ligne.Item1);
                    }
                }

                int idArret = 0;
                foreach (var arret in Arret)
                {
                    if (arret.Item2 == comboBoxArret.SelectedItem.ToString())
                    {
                        idArret = arret.Item1;
                        break;
                    }
                }

                LblSelectionHoraire.Text = "Selectionner l'horaire à modifier : ";
                foreach (var horaire in Horaire)
                {
                    if (idLigne.Contains(horaire.Item3) && idArret == horaire.Item2)
                    {
                        ComboBoxHoraires.Items.Add(horaire.Item4);
                    }
                }
                ComboBoxHoraires.Show();
                lbHoraire.Text = "Nouvel Horaire : ";
                NumUpADownHeure.Show();
                NumUpADownMinute.Show();
            }
        }

        private void ComboBoxHoraires_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxHoraires.SelectedItem != null)
            {
                BtnValider.Enabled = true;
            }
        }
    }
}

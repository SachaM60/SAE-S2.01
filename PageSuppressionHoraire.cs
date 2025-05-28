using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_S2._01
{
    public partial class PageSuppressionHoraire : Form
    {
        private List<(int, string, int, int)> Ligne = new List<(int, string, int, int)>();
        private List<(int, string, double, double)> Arret = new List<(int, string, double, double)>();
        private List<(int, int, int, string)> Horaire = new List<(int, int, int, string)>();

        public PageSuppressionHoraire()
        {
            InitializeComponent();
            lbLigne.Text = lbHoraire.Text = lbArret.Text = "";
            comboBoxArret.Hide();
            comboBoxHoraire.Hide();
            btnSupprimer.Enabled = false;

            ClasseBD.LectureArret(ref Arret);
            ClasseBD.LectureLigne(ref Ligne);
            ClasseBD.LectureHoraire(ref Horaire);

            var nomsLignesUniques = Ligne.Select(l => l.Item2).Distinct();
            foreach (var ligne in nomsLignesUniques)
            {
                lstBoxLigne.Items.Add(ligne);
            }

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
        }

        private void comboBoxHoraire_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxArret_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

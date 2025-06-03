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
    public partial class PageModificationArret : Form
    {
        private List<(int, string, double, double)> Arret = new List<(int, string, double, double)>();
        public PageModificationArret()
        {
            InitializeComponent();

            Lblat.Text = "";
            Lblong.Text = "";
            LbNom.Text = "";
            lbErreurLat.Text = "";
            lbErreurLong.Text = "";

            TxtBoxLat.Hide();
            TxtBoxLong.Hide();
            TxtBoxNom.Hide();

            ClasseBD.LectureArret(ref Arret);


            comboBoxArret.DropDownHeight = 200;
            comboBoxArret.DropDownWidth = 200;
            comboBoxArret.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxArret.AutoCompleteSource = AutoCompleteSource.ListItems;

            foreach (var arret in Arret)
            {
                comboBoxArret.Items.Add(arret.Item2);
            }

            BtnValider.Enabled = false;
        }

        /// <summary>
        /// On vérifie que les coordonnées saisies sont corrects,
        /// Si elles sont bonnes, on modifie l'arrêt
        /// Sinon un message s'affiche selon l'erreur rencontrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValider_Click(object sender, EventArgs e)
        {
            double latitude, longitude;
            bool latOk = double.TryParse(TxtBoxLat.Text, out latitude);
            bool longOk = double.TryParse(TxtBoxLong.Text, out longitude);
            lbErreurLat.Text = "";
            lbErreurLong.Text = "";

            if (!latOk)
            {
                lbErreurLat.Text = "Latitude invalide.";
            }

            if (!longOk)
            {
                lbErreurLong.Text = "Longitude invalide.";
            }

            if (latOk && longOk)
            {
                ClasseBD.ModificationArret(comboBoxArret.SelectedItem.ToString(), TxtBoxNom.Text, latitude, longitude);
                PageModifBd pagemodifbd = new PageModifBd();
                pagemodifbd.Show();
                this.Close();
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            PageChoixModification pageChoixModification = new PageChoixModification();
            pageChoixModification.Show();
            this.Hide();
        }

        /// <summary>
        /// Quand un arrêt est choisit, on affiche ses informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxArret.SelectedItem != null)
            {
                BtnValider.Enabled = true;
                foreach (var arret in Arret)
                {
                    if (arret.Item2 == comboBoxArret.SelectedItem.ToString())
                    {
                        Lblat.Text = "Latitude de l'arrêt:";
                        Lblong.Text = "Longitude de l'arrêt:";
                        LbNom.Text = "Nom de l'arrêt :";
                        TxtBoxLat.Show();
                        TxtBoxLong.Show();
                        TxtBoxNom.Show();
                        TxtBoxLat.Text = arret.Item3.ToString();
                        TxtBoxLong.Text = arret.Item4.ToString();
                        TxtBoxNom.Text = arret.Item2;
                        break;
                    }
                }
            }
        }
    }
}

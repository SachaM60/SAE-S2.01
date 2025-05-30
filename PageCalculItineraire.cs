using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAE_S2._01
{
    public partial class PageCalculItineraire : Form
    {
        //Connection à la base de données
        private static MySqlConnection conn;
        private List<(int, string, double, double)> Arret = new List<(int, string, double, double)>();

        public PageCalculItineraire()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(ClasseBD.UserConnect))
            {
                btnFavoris.Enabled = false;
            }
            else
            {
                btnFavoris.Enabled = true;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            PageMenuPrincipal pageMenuPrincipal = new PageMenuPrincipal();
            pageMenuPrincipal.Show();
            this.Close();
        }

        private void btnFavoris_Click(object sender, EventArgs e)
        {
            PageTrajetsFavoris pageTrajetsFavoris = new PageTrajetsFavoris();
            pageTrajetsFavoris.Show();
            this.Close();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            PagePlanDuReseau pagePlanDuReseau = new PagePlanDuReseau();
            pagePlanDuReseau.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        // Fait sans la BD pour Verifier le fonctionnement de la page

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Arret)
            {
                comboBox1.Items.Add(item.Item2);
            }
            comboBox1.DropDownHeight = 200;
            comboBox1.DropDownWidth = 200;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void PageCalculItineraire_Load(object sender, EventArgs e)
        {

        }

        //Fait sans la BD pour Verifier le fonctionnement de la page

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Arret)
            {
                comboBox1.Items.Add(item.Item2);
            }
            comboBox1.DropDownHeight = 200;
            comboBox1.DropDownWidth = 200;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}

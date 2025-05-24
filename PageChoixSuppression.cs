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
    public partial class PageChoixSuppression : Form
    {
        public PageChoixSuppression()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageModifBd pageModifBd = new PageModifBd();
            pageModifBd.Show();
            this.Close();
        }

        private void btnSuppressionLigne_Click(object sender, EventArgs e)
        {
            PageSuppressionLigne pageSuppressionlign = new PageSuppressionLigne();
            pageSuppressionlign.Show();
            this.Close();
        }

        private void btnSuppressionArret_Click(object sender, EventArgs e)
        {
            PageSuppressionArret pageSuppressionArret = new PageSuppressionArret();
            pageSuppressionArret.Show();
            this.Close();
        }

        private void btnSuppressionHoraire_Click(object sender, EventArgs e)
        {
            PageSuppressionHoraire pageSuppressionHoraire = new PageSuppressionHoraire();
            pageSuppressionHoraire.Show();
            this.Close();
        }
    }
}

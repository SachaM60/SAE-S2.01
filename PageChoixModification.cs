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
    public partial class PageChoixModification : Form
    {
        public PageChoixModification()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageModifBd pageModifBd = new PageModifBd();
            pageModifBd.Show();
            this.Close();
        }

        private void btnModificationLigne_Click(object sender, EventArgs e)
        {
            PageModificationLigne pageModificationLigne = new PageModificationLigne();
            pageModificationLigne.Show();
            this.Close();
        }

        private void btnModificationArret_Click(object sender, EventArgs e)
        {
            PageModificationArret pageModificationArret = new PageModificationArret();
            pageModificationArret.Show();
            this.Close();
        }

        private void btnModificationHoraire_Click(object sender, EventArgs e)
        {
            PageModificationHoraire pageModificationHoraire = new PageModificationHoraire();
            pageModificationHoraire.Show();
            this.Close();
        }
    }
}

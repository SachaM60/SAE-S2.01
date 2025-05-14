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
        public PageConnexion()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageChoixConnexion pageChoixConnexion = new PageChoixConnexion();
            pageChoixConnexion.Show();
            this.Close();
        }

        private void btnValiderConnexion_Click(object sender, EventArgs e)
        {
            PageValidationConnexion pageValidationConnexion = new PageValidationConnexion();
            pageValidationConnexion.Show();
            this.Close();
        }
    }
}

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
    public partial class PageInscription1 : Form
    {
        public PageInscription1()
        {
            InitializeComponent();
        }

        private void btnRetourInscription_Click(object sender, EventArgs e)
        {
            PageChoixConnexion pageChoixConnexion = new PageChoixConnexion();
            pageChoixConnexion.Show();
            this.Close();

        }

        private void btnValiderInscription_Click(object sender, EventArgs e)
        {
            PageInscription2 pageInscription2 = new PageInscription2();
            pageInscription2.Show();
            this.Close();
        }
    }
}

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
    public partial class PageInscription2 : Form
    {
        public PageInscription2()
        {
            InitializeComponent();
        }

        private void btnRetourInscription2_Click(object sender, EventArgs e)
        {
            PageInscription1 pageInscription1 = new PageInscription1();
            pageInscription1.Show();
            this.Close();
        }

        private void btnValider2_Click(object sender, EventArgs e)
        {
            PageValidationConnexion pageValidationConnexion = new PageValidationConnexion();
            pageValidationConnexion.Show();
            this.Close();
        }
    }
}

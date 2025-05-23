﻿using System;
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
    public partial class PageChoixAjout : Form
    {
        public PageChoixAjout()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            PageModifBd pageModifBd = new PageModifBd();
            pageModifBd.Show();
            this.Close();
        }

        private void btnAjoutArret_Click(object sender, EventArgs e)
        {
            PageAjoutArret pageAjoutArret = new PageAjoutArret();
            pageAjoutArret.Show();
            this.Close();
        }

        private void btnAjoutLigne_Click(object sender, EventArgs e)
        {
            PageAjoutLigne pageAjoutligne = new PageAjoutLigne();
            pageAjoutligne.Show();
            this.Close();
        }

        private void btnAjoutHoraire_Click(object sender, EventArgs e)
        {
            PageAjoutHoraire pageAjouthoraire = new PageAjoutHoraire();
            pageAjouthoraire.Show();
            this.Close();
        }
    }
}

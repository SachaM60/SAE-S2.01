using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Formats.Asn1.AsnWriter;

namespace SAE_S2._01
{
    public partial class PagePlanDuReseau : Form
    {
        public PagePlanDuReseau()
        {
            InitializeComponent();
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

        private void btnCalculItinéraire_Click(object sender, EventArgs e)
        {
            PageCalculItineraire pageCalculItineraire = new PageCalculItineraire();
            pageCalculItineraire.Show();
            this.Close();
        }

        private void cboxChoixLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cboxChoixLigne.SelectedItem?.ToString();

            if (selected != null)
            {
                switch (selected)
                {
                    case "Ligne 9":
                        picPlan.Image = Properties.Resources.plan_9_19;
                        break;
                    case "Ligne 10":
                        picPlan.Image = Properties.Resources.plan_10;
                        break;
                    case "Ligne 11":
                        picPlan.Image = Properties.Resources.plan_11_11express;
                        break;
                    case "Ligne 12":
                        picPlan.Image = Properties.Resources.plan_12;
                        break;
                    case "Ligne 13":
                        picPlan.Image = Properties.Resources.plan_13;
                        break;
                    case "Ligne 14":
                        picPlan.Image = Properties.Resources.plan_14;
                        break;
                    case "Ligne 15":
                        picPlan.Image = Properties.Resources.plan_15_18;
                        break;
                    case "Ligne 16":
                        picPlan.Image = Properties.Resources.plan_16;
                        break;
                    case "Ligne 17":
                        picPlan.Image = Properties.Resources.plan_17;
                        break;
                    case "Ligne 18":
                        picPlan.Image = Properties.Resources.plan_15_18;
                        break;
                    case "Ligne 19":
                        picPlan.Image = Properties.Resources.plan_9_19;
                        break;
                    case "Ligne 21":
                        picPlan.Image = Properties.Resources.plan_21;
                        break;
                    case "Ligne 11 Express":
                        picPlan.Image = Properties.Resources.plan_11_11express;
                        break;
                    default:
                        picPlan.Image = Properties.Resources.plan_general_2024;
                        break;
                }
            }
            }

        private void PagePlanDuReseau_Load(object sender, EventArgs e)
        {
            picPlan.Image = Properties.Resources.plan_general_2024;

        }
    }
}

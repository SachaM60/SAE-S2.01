namespace SAE_S2._01
{
    public partial class PageChoixConnexion : Form
    {
        public PageChoixConnexion()
        {
            InitializeComponent();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            PageInscription1 pageInscription = new PageInscription1();
            pageInscription.Show();
            this.Close();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            PageConnexion pageConnexion = new PageConnexion();
            pageConnexion.Show();
            this.Close();
        }

        private void btnRetourChoixConnexion_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0]!.Show();
            this.Close();
        }

        private void picAdmin_Click(object sender, EventArgs e)
        {
        }
    }
}

namespace SAE_S2._01
{
    partial class PageChoixConnexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConnexion = new Button();
            btnInscription = new Button();
            lblPasDeCompte = new Label();
            lblCompteExiste = new Label();
            btnRetourChoixConnexion = new Button();
            SuspendLayout();
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(555, 249);
            btnConnexion.Margin = new Padding(4, 4, 4, 4);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(186, 70);
            btnConnexion.TabIndex = 2;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // btnInscription
            // 
            btnInscription.Location = new Point(555, 92);
            btnInscription.Margin = new Padding(4, 4, 4, 4);
            btnInscription.Name = "btnInscription";
            btnInscription.Size = new Size(186, 70);
            btnInscription.TabIndex = 3;
            btnInscription.Text = "S'inscrire";
            btnInscription.UseVisualStyleBackColor = true;
            btnInscription.Click += btnInscription_Click;
            // 
            // lblPasDeCompte
            // 
            lblPasDeCompte.AutoSize = true;
            lblPasDeCompte.Location = new Point(231, 115);
            lblPasDeCompte.Margin = new Padding(4, 0, 4, 0);
            lblPasDeCompte.Name = "lblPasDeCompte";
            lblPasDeCompte.Size = new Size(142, 25);
            lblPasDeCompte.TabIndex = 4;
            lblPasDeCompte.Text = "Pas de compte ?";
            // 
            // lblCompteExiste
            // 
            lblCompteExiste.AutoSize = true;
            lblCompteExiste.Location = new Point(231, 271);
            lblCompteExiste.Margin = new Padding(4, 0, 4, 0);
            lblCompteExiste.Name = "lblCompteExiste";
            lblCompteExiste.Size = new Size(151, 25);
            lblCompteExiste.TabIndex = 5;
            lblCompteExiste.Text = "Déjà un compte ?";
            // 
            // btnRetourChoixConnexion
            // 
            btnRetourChoixConnexion.Location = new Point(410, 389);
            btnRetourChoixConnexion.Margin = new Padding(4, 4, 4, 4);
            btnRetourChoixConnexion.Name = "btnRetourChoixConnexion";
            btnRetourChoixConnexion.Size = new Size(168, 62);
            btnRetourChoixConnexion.TabIndex = 6;
            btnRetourChoixConnexion.Text = "Retour à l'accueil";
            btnRetourChoixConnexion.UseVisualStyleBackColor = true;
            btnRetourChoixConnexion.Click += btnRetourChoixConnexion_Click;
            // 
            // PageChoixConnexion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnRetourChoixConnexion);
            Controls.Add(lblCompteExiste);
            Controls.Add(lblPasDeCompte);
            Controls.Add(btnInscription);
            Controls.Add(btnConnexion);
            Margin = new Padding(4, 4, 4, 4);
            Name = "PageChoixConnexion";
            Text = "Page de connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnConnexion;
        private Button btnInscription;
        private Label lblPasDeCompte;
        private Label lblCompteExiste;
        private Button btnRetourChoixConnexion;
    }
}

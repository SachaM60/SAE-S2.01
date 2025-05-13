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
            btnConnexion.Location = new Point(444, 199);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(149, 56);
            btnConnexion.TabIndex = 2;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // btnInscription
            // 
            btnInscription.Location = new Point(444, 74);
            btnInscription.Name = "btnInscription";
            btnInscription.Size = new Size(149, 56);
            btnInscription.TabIndex = 3;
            btnInscription.Text = "S'inscrire";
            btnInscription.UseVisualStyleBackColor = true;
            btnInscription.Click += btnInscription_Click;
            // 
            // lblPasDeCompte
            // 
            lblPasDeCompte.AutoSize = true;
            lblPasDeCompte.Location = new Point(185, 92);
            lblPasDeCompte.Name = "lblPasDeCompte";
            lblPasDeCompte.Size = new Size(117, 20);
            lblPasDeCompte.TabIndex = 4;
            lblPasDeCompte.Text = "Pas de compte ?";
            // 
            // lblCompteExiste
            // 
            lblCompteExiste.AutoSize = true;
            lblCompteExiste.Location = new Point(185, 217);
            lblCompteExiste.Name = "lblCompteExiste";
            lblCompteExiste.Size = new Size(126, 20);
            lblCompteExiste.TabIndex = 5;
            lblCompteExiste.Text = "Déjà un compte ?";
            // 
            // btnRetourChoixConnexion
            // 
            btnRetourChoixConnexion.Location = new Point(328, 311);
            btnRetourChoixConnexion.Name = "btnRetourChoixConnexion";
            btnRetourChoixConnexion.Size = new Size(134, 50);
            btnRetourChoixConnexion.TabIndex = 6;
            btnRetourChoixConnexion.Text = "Retour à l'accueil";
            btnRetourChoixConnexion.UseVisualStyleBackColor = true;
            btnRetourChoixConnexion.Click += btnRetourChoixConnexion_Click;
            // 
            // PageChoixConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRetourChoixConnexion);
            Controls.Add(lblCompteExiste);
            Controls.Add(lblPasDeCompte);
            Controls.Add(btnInscription);
            Controls.Add(btnConnexion);
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

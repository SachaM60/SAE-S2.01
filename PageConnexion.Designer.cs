namespace SAE_S2._01
{
    partial class PageConnexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIdentifiantConnexion = new Label();
            lblMotDePasseConnexion = new Label();
            txtIdentifiantConnexion = new TextBox();
            txtMotDePasseConnexion = new TextBox();
            btnRetour = new Button();
            btnValiderConnexion = new Button();
            lbErreurId = new Label();
            lbErreurMdp = new Label();
            SuspendLayout();
            // 
            // lblIdentifiantConnexion
            // 
            lblIdentifiantConnexion.AutoSize = true;
            lblIdentifiantConnexion.Location = new Point(248, 132);
            lblIdentifiantConnexion.Margin = new Padding(4, 0, 4, 0);
            lblIdentifiantConnexion.Name = "lblIdentifiantConnexion";
            lblIdentifiantConnexion.Size = new Size(101, 25);
            lblIdentifiantConnexion.TabIndex = 0;
            lblIdentifiantConnexion.Text = "Identifiant :";
            // 
            // lblMotDePasseConnexion
            // 
            lblMotDePasseConnexion.AutoSize = true;
            lblMotDePasseConnexion.Location = new Point(221, 205);
            lblMotDePasseConnexion.Margin = new Padding(4, 0, 4, 0);
            lblMotDePasseConnexion.Name = "lblMotDePasseConnexion";
            lblMotDePasseConnexion.Size = new Size(129, 25);
            lblMotDePasseConnexion.TabIndex = 1;
            lblMotDePasseConnexion.Text = "Mot de passe :";
            // 
            // txtIdentifiantConnexion
            // 
            txtIdentifiantConnexion.Location = new Point(418, 129);
            txtIdentifiantConnexion.Margin = new Padding(4, 4, 4, 4);
            txtIdentifiantConnexion.Name = "txtIdentifiantConnexion";
            txtIdentifiantConnexion.Size = new Size(155, 31);
            txtIdentifiantConnexion.TabIndex = 2;
            // 
            // txtMotDePasseConnexion
            // 
            txtMotDePasseConnexion.Location = new Point(418, 201);
            txtMotDePasseConnexion.Margin = new Padding(4, 4, 4, 4);
            txtMotDePasseConnexion.Name = "txtMotDePasseConnexion";
            txtMotDePasseConnexion.Size = new Size(155, 31);
            txtMotDePasseConnexion.TabIndex = 3;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(442, 426);
            btnRetour.Margin = new Padding(4, 4, 4, 4);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(118, 36);
            btnRetour.TabIndex = 4;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnValiderConnexion
            // 
            btnValiderConnexion.Location = new Point(442, 371);
            btnValiderConnexion.Margin = new Padding(4, 4, 4, 4);
            btnValiderConnexion.Name = "btnValiderConnexion";
            btnValiderConnexion.Size = new Size(118, 36);
            btnValiderConnexion.TabIndex = 5;
            btnValiderConnexion.Text = "Valider";
            btnValiderConnexion.UseVisualStyleBackColor = true;
            btnValiderConnexion.Click += btnValiderConnexion_Click;
            // 
            // lbErreurId
            // 
            lbErreurId.AutoSize = true;
            lbErreurId.Location = new Point(613, 132);
            lbErreurId.Name = "lbErreurId";
            lbErreurId.Size = new Size(58, 25);
            lbErreurId.TabIndex = 6;
            lbErreurId.Text = "Erreur";
            // 
            // lbErreurMdp
            // 
            lbErreurMdp.AutoSize = true;
            lbErreurMdp.Location = new Point(613, 207);
            lbErreurMdp.Name = "lbErreurMdp";
            lbErreurMdp.Size = new Size(58, 25);
            lbErreurMdp.TabIndex = 7;
            lbErreurMdp.Text = "Erreur";
            // 
            // PageConnexion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(lbErreurMdp);
            Controls.Add(lbErreurId);
            Controls.Add(btnValiderConnexion);
            Controls.Add(btnRetour);
            Controls.Add(txtMotDePasseConnexion);
            Controls.Add(txtIdentifiantConnexion);
            Controls.Add(lblMotDePasseConnexion);
            Controls.Add(lblIdentifiantConnexion);
            Margin = new Padding(4, 4, 4, 4);
            Name = "PageConnexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdentifiantConnexion;
        private Label lblMotDePasseConnexion;
        private TextBox txtIdentifiantConnexion;
        private TextBox txtMotDePasseConnexion;
        private Button btnRetour;
        private Button btnValiderConnexion;
        private Label lbErreurId;
        private Label lbErreurMdp;
    }
}
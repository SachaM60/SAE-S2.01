namespace SAE_S2._01
{
    partial class PageInscription2
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
            lblExplicationsInscription2 = new Label();
            lblIdentifiant = new Label();
            lblMotDePasse = new Label();
            btnValider2 = new Button();
            btnRetourInscription2 = new Button();
            txtIdentifiant = new TextBox();
            txtMotDePasse = new TextBox();
            lbErreurId = new Label();
            lbErreurMdp = new Label();
            SuspendLayout();
            // 
            // lblExplicationsInscription2
            // 
            lblExplicationsInscription2.AutoSize = true;
            lblExplicationsInscription2.Location = new Point(322, 66);
            lblExplicationsInscription2.Margin = new Padding(4, 0, 4, 0);
            lblExplicationsInscription2.Name = "lblExplicationsInscription2";
            lblExplicationsInscription2.Size = new Size(325, 25);
            lblExplicationsInscription2.TabIndex = 0;
            lblExplicationsInscription2.Text = "Veuillez enter les informations suivantes";
            // 
            // lblIdentifiant
            // 
            lblIdentifiant.AutoSize = true;
            lblIdentifiant.Location = new Point(242, 180);
            lblIdentifiant.Margin = new Padding(4, 0, 4, 0);
            lblIdentifiant.Name = "lblIdentifiant";
            lblIdentifiant.Size = new Size(101, 25);
            lblIdentifiant.TabIndex = 2;
            lblIdentifiant.Text = "Identifiant :";
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Location = new Point(216, 253);
            lblMotDePasse.Margin = new Padding(4, 0, 4, 0);
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Size = new Size(129, 25);
            lblMotDePasse.TabIndex = 3;
            lblMotDePasse.Text = "Mot de passe :";
            // 
            // btnValider2
            // 
            btnValider2.Location = new Point(448, 358);
            btnValider2.Margin = new Padding(4);
            btnValider2.Name = "btnValider2";
            btnValider2.Size = new Size(118, 36);
            btnValider2.TabIndex = 4;
            btnValider2.Text = "Valider";
            btnValider2.UseVisualStyleBackColor = true;
            btnValider2.Click += btnValider2_Click;
            // 
            // btnRetourInscription2
            // 
            btnRetourInscription2.Location = new Point(449, 429);
            btnRetourInscription2.Margin = new Padding(4);
            btnRetourInscription2.Name = "btnRetourInscription2";
            btnRetourInscription2.Size = new Size(118, 36);
            btnRetourInscription2.TabIndex = 5;
            btnRetourInscription2.Text = "Retour";
            btnRetourInscription2.UseVisualStyleBackColor = true;
            btnRetourInscription2.Click += btnRetourInscription2_Click;
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.Location = new Point(431, 177);
            txtIdentifiant.Margin = new Padding(4);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.Size = new Size(155, 31);
            txtIdentifiant.TabIndex = 7;
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Location = new Point(431, 253);
            txtMotDePasse.Margin = new Padding(4);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(155, 31);
            txtMotDePasse.TabIndex = 8;
            // 
            // lbErreurId
            // 
            lbErreurId.AutoSize = true;
            lbErreurId.Location = new Point(630, 183);
            lbErreurId.Name = "lbErreurId";
            lbErreurId.Size = new Size(58, 25);
            lbErreurId.TabIndex = 10;
            lbErreurId.Text = "Erreur";
            // 
            // lbErreurMdp
            // 
            lbErreurMdp.AutoSize = true;
            lbErreurMdp.Location = new Point(630, 259);
            lbErreurMdp.Name = "lbErreurMdp";
            lbErreurMdp.Size = new Size(58, 25);
            lbErreurMdp.TabIndex = 11;
            lbErreurMdp.Text = "Erreur";
            // 
            // PageInscription2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(lbErreurMdp);
            Controls.Add(lbErreurId);
            Controls.Add(txtMotDePasse);
            Controls.Add(txtIdentifiant);
            Controls.Add(btnRetourInscription2);
            Controls.Add(btnValider2);
            Controls.Add(lblMotDePasse);
            Controls.Add(lblIdentifiant);
            Controls.Add(lblExplicationsInscription2);
            Margin = new Padding(4);
            Name = "PageInscription2";
            Text = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExplicationsInscription2;
        private Label lblIdentifiant;
        private Label lblMotDePasse;
        private Button btnValider2;
        private Button btnRetourInscription2;
        private TextBox txtIdentifiant;
        private TextBox txtMotDePasse;
        private Label lbErreurId;
        private Label lbErreurMdp;
    }
}
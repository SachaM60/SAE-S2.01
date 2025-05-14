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
            lblMail = new Label();
            lblIdentifiant = new Label();
            lblMotDePasse = new Label();
            btnValider2 = new Button();
            btnRetourInscription2 = new Button();
            txtMail = new TextBox();
            txtIdentifiant = new TextBox();
            txtMotDePasse = new TextBox();
            SuspendLayout();
            // 
            // lblExplicationsInscription2
            // 
            lblExplicationsInscription2.AutoSize = true;
            lblExplicationsInscription2.Location = new Point(258, 53);
            lblExplicationsInscription2.Name = "lblExplicationsInscription2";
            lblExplicationsInscription2.Size = new Size(272, 20);
            lblExplicationsInscription2.TabIndex = 0;
            lblExplicationsInscription2.Text = "Veuillez enter les informations suivantes";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(177, 106);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(101, 20);
            lblMail.TabIndex = 1;
            lblMail.Text = "Adresse mail :";
            // 
            // lblIdentifiant
            // 
            lblIdentifiant.AutoSize = true;
            lblIdentifiant.Location = new Point(194, 162);
            lblIdentifiant.Name = "lblIdentifiant";
            lblIdentifiant.Size = new Size(84, 20);
            lblIdentifiant.TabIndex = 2;
            lblIdentifiant.Text = "Identifiant :";
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Location = new Point(173, 220);
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Size = new Size(105, 20);
            lblMotDePasse.TabIndex = 3;
            lblMotDePasse.Text = "Mot de passe :";
            // 
            // btnValider2
            // 
            btnValider2.Location = new Point(358, 273);
            btnValider2.Name = "btnValider2";
            btnValider2.Size = new Size(94, 29);
            btnValider2.TabIndex = 4;
            btnValider2.Text = "Valider";
            btnValider2.UseVisualStyleBackColor = true;
            btnValider2.Click += btnValider2_Click;
            // 
            // btnRetourInscription2
            // 
            btnRetourInscription2.Location = new Point(359, 330);
            btnRetourInscription2.Name = "btnRetourInscription2";
            btnRetourInscription2.Size = new Size(94, 29);
            btnRetourInscription2.TabIndex = 5;
            btnRetourInscription2.Text = "Retour";
            btnRetourInscription2.UseVisualStyleBackColor = true;
            btnRetourInscription2.Click += btnRetourInscription2_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(345, 103);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(125, 27);
            txtMail.TabIndex = 6;
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.Location = new Point(345, 159);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.Size = new Size(125, 27);
            txtIdentifiant.TabIndex = 7;
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Location = new Point(345, 220);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(125, 27);
            txtMotDePasse.TabIndex = 8;
            // 
            // PageInscription2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMotDePasse);
            Controls.Add(txtIdentifiant);
            Controls.Add(txtMail);
            Controls.Add(btnRetourInscription2);
            Controls.Add(btnValider2);
            Controls.Add(lblMotDePasse);
            Controls.Add(lblIdentifiant);
            Controls.Add(lblMail);
            Controls.Add(lblExplicationsInscription2);
            Name = "PageInscription2";
            Text = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExplicationsInscription2;
        private Label lblMail;
        private Label lblIdentifiant;
        private Label lblMotDePasse;
        private Button btnValider2;
        private Button btnRetourInscription2;
        private TextBox txtMail;
        private TextBox txtIdentifiant;
        private TextBox txtMotDePasse;
    }
}
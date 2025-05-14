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
            SuspendLayout();
            // 
            // lblIdentifiantConnexion
            // 
            lblIdentifiantConnexion.AutoSize = true;
            lblIdentifiantConnexion.Location = new Point(198, 106);
            lblIdentifiantConnexion.Name = "lblIdentifiantConnexion";
            lblIdentifiantConnexion.Size = new Size(84, 20);
            lblIdentifiantConnexion.TabIndex = 0;
            lblIdentifiantConnexion.Text = "Identifiant :";
            // 
            // lblMotDePasseConnexion
            // 
            lblMotDePasseConnexion.AutoSize = true;
            lblMotDePasseConnexion.Location = new Point(177, 164);
            lblMotDePasseConnexion.Name = "lblMotDePasseConnexion";
            lblMotDePasseConnexion.Size = new Size(105, 20);
            lblMotDePasseConnexion.TabIndex = 1;
            lblMotDePasseConnexion.Text = "Mot de passe :";
            // 
            // txtIdentifiantConnexion
            // 
            txtIdentifiantConnexion.Location = new Point(334, 103);
            txtIdentifiantConnexion.Name = "txtIdentifiantConnexion";
            txtIdentifiantConnexion.Size = new Size(125, 27);
            txtIdentifiantConnexion.TabIndex = 2;
            // 
            // txtMotDePasseConnexion
            // 
            txtMotDePasseConnexion.Location = new Point(334, 161);
            txtMotDePasseConnexion.Name = "txtMotDePasseConnexion";
            txtMotDePasseConnexion.Size = new Size(125, 27);
            txtMotDePasseConnexion.TabIndex = 3;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(354, 341);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(94, 29);
            btnRetour.TabIndex = 4;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnValiderConnexion
            // 
            btnValiderConnexion.Location = new Point(354, 297);
            btnValiderConnexion.Name = "btnValiderConnexion";
            btnValiderConnexion.Size = new Size(94, 29);
            btnValiderConnexion.TabIndex = 5;
            btnValiderConnexion.Text = "Valider";
            btnValiderConnexion.UseVisualStyleBackColor = true;
            btnValiderConnexion.Click += btnValiderConnexion_Click;
            // 
            // PageConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValiderConnexion);
            Controls.Add(btnRetour);
            Controls.Add(txtMotDePasseConnexion);
            Controls.Add(txtIdentifiantConnexion);
            Controls.Add(lblMotDePasseConnexion);
            Controls.Add(lblIdentifiantConnexion);
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
    }
}
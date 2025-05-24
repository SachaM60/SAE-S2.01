namespace SAE_S2._01
{
    partial class PageChoixModification
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
            btnRetour = new Button();
            btnModificationHoraire = new Button();
            btnModificationArret = new Button();
            btnModificationLigne = new Button();
            lblChoixAjout = new Label();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(423, 416);
            btnRetour.Margin = new Padding(4);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(118, 36);
            btnRetour.TabIndex = 14;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnModificationHoraire
            // 
            btnModificationHoraire.Location = new Point(369, 325);
            btnModificationHoraire.Margin = new Padding(4);
            btnModificationHoraire.Name = "btnModificationHoraire";
            btnModificationHoraire.Size = new Size(247, 36);
            btnModificationHoraire.TabIndex = 13;
            btnModificationHoraire.Text = "Modification d'un horaire";
            btnModificationHoraire.UseVisualStyleBackColor = true;
            btnModificationHoraire.Click += btnModificationHoraire_Click;
            // 
            // btnModificationArret
            // 
            btnModificationArret.Location = new Point(369, 265);
            btnModificationArret.Margin = new Padding(4);
            btnModificationArret.Name = "btnModificationArret";
            btnModificationArret.Size = new Size(247, 36);
            btnModificationArret.TabIndex = 12;
            btnModificationArret.Text = "Modification d'un arret";
            btnModificationArret.UseVisualStyleBackColor = true;
            btnModificationArret.Click += btnModificationArret_Click;
            // 
            // btnModificationLigne
            // 
            btnModificationLigne.Location = new Point(369, 203);
            btnModificationLigne.Margin = new Padding(4);
            btnModificationLigne.Name = "btnModificationLigne";
            btnModificationLigne.Size = new Size(247, 36);
            btnModificationLigne.TabIndex = 11;
            btnModificationLigne.Text = "Modification d'une ligne";
            btnModificationLigne.UseVisualStyleBackColor = true;
            btnModificationLigne.Click += btnModificationLigne_Click;
            // 
            // lblChoixAjout
            // 
            lblChoixAjout.AutoSize = true;
            lblChoixAjout.Location = new Point(288, 111);
            lblChoixAjout.Margin = new Padding(4, 0, 4, 0);
            lblChoixAjout.Name = "lblChoixAjout";
            lblChoixAjout.Size = new Size(411, 25);
            lblChoixAjout.TabIndex = 10;
            lblChoixAjout.Text = "Quels types de données souhaitez vous modifier ?";
            // 
            // PageChoixModification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnRetour);
            Controls.Add(btnModificationHoraire);
            Controls.Add(btnModificationArret);
            Controls.Add(btnModificationLigne);
            Controls.Add(lblChoixAjout);
            Margin = new Padding(4);
            Name = "PageChoixModification";
            Text = "Choix des données à modifier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetour;
        private Button btnModificationHoraire;
        private Button btnModificationArret;
        private Button btnModificationLigne;
        private Label lblChoixAjout;
    }
}
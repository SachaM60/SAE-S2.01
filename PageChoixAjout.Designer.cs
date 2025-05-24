namespace SAE_S2._01
{
    partial class PageChoixAjout
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
            lblChoixAjout = new Label();
            btnAjoutLigne = new Button();
            btnAjoutArret = new Button();
            btnAjoutHoraire = new Button();
            btnRetour = new Button();
            SuspendLayout();
            // 
            // lblChoixAjout
            // 
            lblChoixAjout.AutoSize = true;
            lblChoixAjout.Location = new Point(275, 76);
            lblChoixAjout.Margin = new Padding(4, 0, 4, 0);
            lblChoixAjout.Name = "lblChoixAjout";
            lblChoixAjout.Size = new Size(399, 25);
            lblChoixAjout.TabIndex = 0;
            lblChoixAjout.Text = "Quels types de données souhaitez vous ajouter ?";
            // 
            // btnAjoutLigne
            // 
            btnAjoutLigne.Location = new Point(366, 168);
            btnAjoutLigne.Margin = new Padding(4, 4, 4, 4);
            btnAjoutLigne.Name = "btnAjoutLigne";
            btnAjoutLigne.Size = new Size(219, 36);
            btnAjoutLigne.TabIndex = 1;
            btnAjoutLigne.Text = "Ajout d'une ligne";
            btnAjoutLigne.UseVisualStyleBackColor = true;
            // 
            // btnAjoutArret
            // 
            btnAjoutArret.Location = new Point(366, 230);
            btnAjoutArret.Margin = new Padding(4, 4, 4, 4);
            btnAjoutArret.Name = "btnAjoutArret";
            btnAjoutArret.Size = new Size(219, 36);
            btnAjoutArret.TabIndex = 2;
            btnAjoutArret.Text = "Ajout d'un arret";
            btnAjoutArret.UseVisualStyleBackColor = true;
            btnAjoutArret.Click += btnAjoutArret_Click;
            // 
            // btnAjoutHoraire
            // 
            btnAjoutHoraire.Location = new Point(366, 291);
            btnAjoutHoraire.Margin = new Padding(4, 4, 4, 4);
            btnAjoutHoraire.Name = "btnAjoutHoraire";
            btnAjoutHoraire.Size = new Size(219, 36);
            btnAjoutHoraire.TabIndex = 3;
            btnAjoutHoraire.Text = "Ajout d'un horaire";
            btnAjoutHoraire.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(410, 381);
            btnRetour.Margin = new Padding(4, 4, 4, 4);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(118, 36);
            btnRetour.TabIndex = 4;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // PageChoixAjout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnRetour);
            Controls.Add(btnAjoutHoraire);
            Controls.Add(btnAjoutArret);
            Controls.Add(btnAjoutLigne);
            Controls.Add(lblChoixAjout);
            Margin = new Padding(4, 4, 4, 4);
            Name = "PageChoixAjout";
            Text = "Choix des données à ajouter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChoixAjout;
        private Button btnAjoutLigne;
        private Button btnAjoutArret;
        private Button btnAjoutHoraire;
        private Button btnRetour;
    }
}
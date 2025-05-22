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
            lblChoixAjout.Location = new Point(220, 61);
            lblChoixAjout.Name = "lblChoixAjout";
            lblChoixAjout.Size = new Size(329, 20);
            lblChoixAjout.TabIndex = 0;
            lblChoixAjout.Text = "Quels types de données souhaitez vous ajouter ?";
            // 
            // btnAjoutLigne
            // 
            btnAjoutLigne.Location = new Point(293, 134);
            btnAjoutLigne.Name = "btnAjoutLigne";
            btnAjoutLigne.Size = new Size(175, 29);
            btnAjoutLigne.TabIndex = 1;
            btnAjoutLigne.Text = "Ajout d'une ligne";
            btnAjoutLigne.UseVisualStyleBackColor = true;
            // 
            // btnAjoutArret
            // 
            btnAjoutArret.Location = new Point(293, 184);
            btnAjoutArret.Name = "btnAjoutArret";
            btnAjoutArret.Size = new Size(175, 29);
            btnAjoutArret.TabIndex = 2;
            btnAjoutArret.Text = "Ajout d'un arret";
            btnAjoutArret.UseVisualStyleBackColor = true;
            // 
            // btnAjoutHoraire
            // 
            btnAjoutHoraire.Location = new Point(293, 233);
            btnAjoutHoraire.Name = "btnAjoutHoraire";
            btnAjoutHoraire.Size = new Size(175, 29);
            btnAjoutHoraire.TabIndex = 3;
            btnAjoutHoraire.Text = "Ajout d'un horaire";
            btnAjoutHoraire.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(328, 305);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(94, 29);
            btnRetour.TabIndex = 4;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // PageChoixAjout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRetour);
            Controls.Add(btnAjoutHoraire);
            Controls.Add(btnAjoutArret);
            Controls.Add(btnAjoutLigne);
            Controls.Add(lblChoixAjout);
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
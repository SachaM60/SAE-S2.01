namespace SAE_S2._01
{
    partial class PageChoixSuppression
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
            btnSuppressionHoraire = new Button();
            btnSuppressionArret = new Button();
            btnSuppressionLigne = new Button();
            lblChoixAjout = new Label();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(436, 416);
            btnRetour.Margin = new Padding(4);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(118, 36);
            btnRetour.TabIndex = 9;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnSuppressionHoraire
            // 
            btnSuppressionHoraire.Location = new Point(392, 326);
            btnSuppressionHoraire.Margin = new Padding(4);
            btnSuppressionHoraire.Name = "btnSuppressionHoraire";
            btnSuppressionHoraire.Size = new Size(219, 36);
            btnSuppressionHoraire.TabIndex = 8;
            btnSuppressionHoraire.Text = "Suppression d'un horaire";
            btnSuppressionHoraire.UseVisualStyleBackColor = true;
            btnSuppressionHoraire.Click += btnSuppressionHoraire_Click;
            // 
            // btnSuppressionArret
            // 
            btnSuppressionArret.Location = new Point(392, 265);
            btnSuppressionArret.Margin = new Padding(4);
            btnSuppressionArret.Name = "btnSuppressionArret";
            btnSuppressionArret.Size = new Size(219, 36);
            btnSuppressionArret.TabIndex = 7;
            btnSuppressionArret.Text = "Suppression d'un arret";
            btnSuppressionArret.UseVisualStyleBackColor = true;
            btnSuppressionArret.Click += btnSuppressionArret_Click;
            // 
            // btnSuppressionLigne
            // 
            btnSuppressionLigne.Location = new Point(392, 203);
            btnSuppressionLigne.Margin = new Padding(4);
            btnSuppressionLigne.Name = "btnSuppressionLigne";
            btnSuppressionLigne.Size = new Size(219, 36);
            btnSuppressionLigne.TabIndex = 6;
            btnSuppressionLigne.Text = "Suppression d'une ligne";
            btnSuppressionLigne.UseVisualStyleBackColor = true;
            btnSuppressionLigne.Click += btnSuppressionLigne_Click;
            // 
            // lblChoixAjout
            // 
            lblChoixAjout.AutoSize = true;
            lblChoixAjout.Location = new Point(301, 111);
            lblChoixAjout.Margin = new Padding(4, 0, 4, 0);
            lblChoixAjout.Name = "lblChoixAjout";
            lblChoixAjout.Size = new Size(425, 25);
            lblChoixAjout.TabIndex = 5;
            lblChoixAjout.Text = "Quels types de données souhaitez vous supprimer ?";
            // 
            // PageChoixSuppression
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnRetour);
            Controls.Add(btnSuppressionHoraire);
            Controls.Add(btnSuppressionArret);
            Controls.Add(btnSuppressionLigne);
            Controls.Add(lblChoixAjout);
            Margin = new Padding(4);
            Name = "PageChoixSuppression";
            Text = "Choix des données à supprimer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetour;
        private Button btnSuppressionHoraire;
        private Button btnSuppressionArret;
        private Button btnSuppressionLigne;
        private Label lblChoixAjout;
    }
}
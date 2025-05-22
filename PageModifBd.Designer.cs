namespace SAE_S2._01
{
    partial class PageModifBd
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
            lblModifBD = new Label();
            lblChoixModif = new Label();
            btnAjout = new Button();
            btnSuppression = new Button();
            btnModif = new Button();
            btnConsulter = new Button();
            picAccueil = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picAccueil).BeginInit();
            SuspendLayout();
            // 
            // lblModifBD
            // 
            lblModifBD.AutoSize = true;
            lblModifBD.Location = new Point(271, 43);
            lblModifBD.Name = "lblModifBD";
            lblModifBD.Size = new Size(247, 20);
            lblModifBD.TabIndex = 0;
            lblModifBD.Text = "Modification de la base de données";
            // 
            // lblChoixModif
            // 
            lblChoixModif.AutoSize = true;
            lblChoixModif.Location = new Point(260, 99);
            lblChoixModif.Name = "lblChoixModif";
            lblChoixModif.Size = new Size(272, 20);
            lblChoixModif.TabIndex = 1;
            lblChoixModif.Text = "Quels actions souhaitez vous effectuer ?";
            // 
            // btnAjout
            // 
            btnAjout.Location = new Point(287, 192);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(214, 29);
            btnAjout.TabIndex = 2;
            btnAjout.Text = "Ajout de données";
            btnAjout.UseVisualStyleBackColor = true;
            btnAjout.Click += btnAjout_Click;
            // 
            // btnSuppression
            // 
            btnSuppression.Location = new Point(287, 252);
            btnSuppression.Name = "btnSuppression";
            btnSuppression.Size = new Size(214, 29);
            btnSuppression.TabIndex = 3;
            btnSuppression.Text = "Suppression de données";
            btnSuppression.UseVisualStyleBackColor = true;
            btnSuppression.Click += btnSuppression_Click;
            // 
            // btnModif
            // 
            btnModif.Location = new Point(287, 304);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(214, 29);
            btnModif.TabIndex = 4;
            btnModif.Text = "Modification des données";
            btnModif.UseVisualStyleBackColor = true;
            btnModif.Click += btnModif_Click;
            // 
            // btnConsulter
            // 
            btnConsulter.Location = new Point(287, 388);
            btnConsulter.Name = "btnConsulter";
            btnConsulter.Size = new Size(214, 29);
            btnConsulter.TabIndex = 5;
            btnConsulter.Text = "Consulter l'application";
            btnConsulter.UseVisualStyleBackColor = true;
            btnConsulter.Click += btnConsulter_Click;
            // 
            // picAccueil
            // 
            picAccueil.Image = Properties.Resources.house_icon_187945;
            picAccueil.Location = new Point(722, 12);
            picAccueil.Name = "picAccueil";
            picAccueil.Size = new Size(66, 61);
            picAccueil.SizeMode = PictureBoxSizeMode.StretchImage;
            picAccueil.TabIndex = 6;
            picAccueil.TabStop = false;
            picAccueil.Click += picAccueil_Click;
            // 
            // PageModifBd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picAccueil);
            Controls.Add(btnConsulter);
            Controls.Add(btnModif);
            Controls.Add(btnSuppression);
            Controls.Add(btnAjout);
            Controls.Add(lblChoixModif);
            Controls.Add(lblModifBD);
            Name = "PageModifBd";
            Text = "Modification de la base de données";
            ((System.ComponentModel.ISupportInitialize)picAccueil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModifBD;
        private Label lblChoixModif;
        private Button btnAjout;
        private Button btnSuppression;
        private Button btnModif;
        private Button btnConsulter;
        private PictureBox picAccueil;
    }
}
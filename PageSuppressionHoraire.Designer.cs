namespace SAE_S2._01
{
    partial class PageSuppressionHoraire
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
            btnSupprimer = new Button();
            btnRetour = new Button();
            lstBoxLigne = new ListBox();
            lbLigne = new Label();
            lbArret = new Label();
            lbHoraire = new Label();
            comboBoxArret = new ComboBox();
            comboBoxHoraire = new ComboBox();
            SuspendLayout();
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(531, 402);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(245, 34);
            btnSupprimer.TabIndex = 5;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(241, 402);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(245, 34);
            btnRetour.TabIndex = 4;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // lstBoxLigne
            // 
            lstBoxLigne.FormattingEnabled = true;
            lstBoxLigne.ItemHeight = 25;
            lstBoxLigne.Location = new Point(24, 11);
            lstBoxLigne.Name = "lstBoxLigne";
            lstBoxLigne.Size = new Size(180, 429);
            lstBoxLigne.TabIndex = 3;
            lstBoxLigne.SelectedIndexChanged += lstBoxLigne_SelectedIndexChanged;
            // 
            // lbLigne
            // 
            lbLigne.AutoSize = true;
            lbLigne.Location = new Point(245, 82);
            lbLigne.Name = "lbLigne";
            lbLigne.Size = new Size(207, 25);
            lbLigne.TabIndex = 6;
            lbLigne.Text = "Ligne sélectionnée : nom";
            // 
            // lbArret
            // 
            lbArret.AutoSize = true;
            lbArret.Location = new Point(245, 169);
            lbArret.Name = "lbArret";
            lbArret.Size = new Size(65, 25);
            lbArret.TabIndex = 7;
            lbArret.Text = "Arrêt : ";
            // 
            // lbHoraire
            // 
            lbHoraire.AutoSize = true;
            lbHoraire.Location = new Point(245, 263);
            lbHoraire.Name = "lbHoraire";
            lbHoraire.Size = new Size(84, 25);
            lbHoraire.TabIndex = 8;
            lbHoraire.Text = "Horaire : ";
            // 
            // comboBoxArret
            // 
            comboBoxArret.FormattingEnabled = true;
            comboBoxArret.Location = new Point(329, 166);
            comboBoxArret.Name = "comboBoxArret";
            comboBoxArret.Size = new Size(182, 33);
            comboBoxArret.TabIndex = 9;
            comboBoxArret.SelectedIndexChanged += comboBoxArret_SelectedIndexChanged;
            // 
            // comboBoxHoraire
            // 
            comboBoxHoraire.FormattingEnabled = true;
            comboBoxHoraire.Location = new Point(335, 260);
            comboBoxHoraire.Name = "comboBoxHoraire";
            comboBoxHoraire.Size = new Size(182, 33);
            comboBoxHoraire.TabIndex = 10;
            comboBoxHoraire.SelectedIndexChanged += comboBoxHoraire_SelectedIndexChanged;
            // 
            // PageSuppressionHoraire
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxHoraire);
            Controls.Add(comboBoxArret);
            Controls.Add(lbHoraire);
            Controls.Add(lbArret);
            Controls.Add(lbLigne);
            Controls.Add(btnSupprimer);
            Controls.Add(btnRetour);
            Controls.Add(lstBoxLigne);
            Name = "PageSuppressionHoraire";
            Text = "PageSuppressionHoraire";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSupprimer;
        private Button btnRetour;
        private ListBox lstBoxLigne;
        private Label lbLigne;
        private Label lbArret;
        private Label lbHoraire;
        private ComboBox comboBoxArret;
        private ComboBox comboBoxHoraire;
    }
}
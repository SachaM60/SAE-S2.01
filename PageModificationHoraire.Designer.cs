namespace SAE_S2._01
{
    partial class PageModificationHoraire
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
            BtnRetour = new Button();
            BtnValider = new Button();
            LblSelectionHoraire = new Label();
            lbHoraire = new Label();
            ComboBoxHoraires = new ComboBox();
            LbLigne = new Label();
            ComboBoxLigne = new ComboBox();
            NumUpADownHeure = new NumericUpDown();
            NumUpADownMinute = new NumericUpDown();
            comboBoxArret = new ComboBox();
            lbArret = new Label();
            ((System.ComponentModel.ISupportInitialize)NumUpADownHeure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUpADownMinute).BeginInit();
            SuspendLayout();
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(324, 409);
            BtnRetour.Margin = new Padding(4);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(118, 36);
            BtnRetour.TabIndex = 0;
            BtnRetour.Text = "Retour";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // BtnValider
            // 
            BtnValider.Enabled = false;
            BtnValider.Location = new Point(536, 409);
            BtnValider.Margin = new Padding(4);
            BtnValider.Name = "BtnValider";
            BtnValider.Size = new Size(118, 36);
            BtnValider.TabIndex = 1;
            BtnValider.Text = "Valider";
            BtnValider.UseVisualStyleBackColor = true;
            BtnValider.Click += BtnValider_Click;
            // 
            // LblSelectionHoraire
            // 
            LblSelectionHoraire.AutoSize = true;
            LblSelectionHoraire.Location = new Point(111, 232);
            LblSelectionHoraire.Margin = new Padding(4, 0, 4, 0);
            LblSelectionHoraire.Name = "LblSelectionHoraire";
            LblSelectionHoraire.Size = new Size(279, 25);
            LblSelectionHoraire.TabIndex = 2;
            LblSelectionHoraire.Text = "Selectionner l'Horaire à Modifier : ";
            // 
            // lbHoraire
            // 
            lbHoraire.AutoSize = true;
            lbHoraire.Location = new Point(245, 316);
            lbHoraire.Margin = new Padding(4, 0, 4, 0);
            lbHoraire.Name = "lbHoraire";
            lbHoraire.Size = new Size(145, 25);
            lbHoraire.TabIndex = 3;
            lbHoraire.Text = "Nouvel Horaire : ";
            // 
            // ComboBoxHoraires
            // 
            ComboBoxHoraires.FormattingEnabled = true;
            ComboBoxHoraires.Location = new Point(420, 229);
            ComboBoxHoraires.Margin = new Padding(4);
            ComboBoxHoraires.Name = "ComboBoxHoraires";
            ComboBoxHoraires.Size = new Size(188, 33);
            ComboBoxHoraires.TabIndex = 4;
            ComboBoxHoraires.SelectedIndexChanged += ComboBoxHoraires_SelectedIndexChanged;
            // 
            // LbLigne
            // 
            LbLigne.AutoSize = true;
            LbLigne.Location = new Point(207, 113);
            LbLigne.Margin = new Padding(4, 0, 4, 0);
            LbLigne.Name = "LbLigne";
            LbLigne.Size = new Size(183, 25);
            LbLigne.TabIndex = 5;
            LbLigne.Text = "Selectionner la ligne : ";
            // 
            // ComboBoxLigne
            // 
            ComboBoxLigne.FormattingEnabled = true;
            ComboBoxLigne.Location = new Point(420, 113);
            ComboBoxLigne.Margin = new Padding(4);
            ComboBoxLigne.Name = "ComboBoxLigne";
            ComboBoxLigne.Size = new Size(188, 33);
            ComboBoxLigne.TabIndex = 6;
            ComboBoxLigne.SelectedIndexChanged += ComboBoxLigne_SelectedIndexChanged;
            // 
            // NumUpADownHeure
            // 
            NumUpADownHeure.Location = new Point(420, 314);
            NumUpADownHeure.Margin = new Padding(4);
            NumUpADownHeure.Name = "NumUpADownHeure";
            NumUpADownHeure.Size = new Size(91, 31);
            NumUpADownHeure.TabIndex = 7;
            // 
            // NumUpADownMinute
            // 
            NumUpADownMinute.Location = new Point(518, 314);
            NumUpADownMinute.Margin = new Padding(4);
            NumUpADownMinute.Name = "NumUpADownMinute";
            NumUpADownMinute.Size = new Size(91, 31);
            NumUpADownMinute.TabIndex = 8;
            // 
            // comboBoxArret
            // 
            comboBoxArret.FormattingEnabled = true;
            comboBoxArret.Location = new Point(420, 175);
            comboBoxArret.Margin = new Padding(4);
            comboBoxArret.Name = "comboBoxArret";
            comboBoxArret.Size = new Size(188, 33);
            comboBoxArret.TabIndex = 10;
            comboBoxArret.SelectedIndexChanged += comboBoxArret_SelectedIndexChanged;
            // 
            // lbArret
            // 
            lbArret.AutoSize = true;
            lbArret.Location = new Point(243, 178);
            lbArret.Margin = new Padding(4, 0, 4, 0);
            lbArret.Name = "lbArret";
            lbArret.Size = new Size(142, 25);
            lbArret.TabIndex = 9;
            lbArret.Text = "Arrêt de départ :";
            // 
            // PageModificationHoraire
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(comboBoxArret);
            Controls.Add(lbArret);
            Controls.Add(NumUpADownMinute);
            Controls.Add(NumUpADownHeure);
            Controls.Add(ComboBoxLigne);
            Controls.Add(LbLigne);
            Controls.Add(ComboBoxHoraires);
            Controls.Add(lbHoraire);
            Controls.Add(LblSelectionHoraire);
            Controls.Add(BtnValider);
            Controls.Add(BtnRetour);
            Margin = new Padding(4);
            Name = "PageModificationHoraire";
            Text = "PageModificationHoraire";
            ((System.ComponentModel.ISupportInitialize)NumUpADownHeure).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUpADownMinute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRetour;
        private Button BtnValider;
        private Label LblSelectionHoraire;
        private Label lbHoraire;
        private ComboBox ComboBoxHoraires;
        private Label LbLigne;
        private ComboBox ComboBoxLigne;
        private NumericUpDown NumUpADownHeure;
        private NumericUpDown NumUpADownMinute;
        private ComboBox comboBoxArret;
        private Label lbArret;
    }
}
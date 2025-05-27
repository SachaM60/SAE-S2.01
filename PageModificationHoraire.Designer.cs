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
            label2 = new Label();
            ComboBoxHoraires = new ComboBox();
            LblSelectionLigne = new Label();
            ComboBoxSelectinLigne = new ComboBox();
            NumUpADownHeure = new NumericUpDown();
            NumUpADownMinute = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumUpADownHeure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUpADownMinute).BeginInit();
            SuspendLayout();
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(259, 327);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(94, 29);
            BtnRetour.TabIndex = 0;
            BtnRetour.Text = "Retour";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // BtnValider
            // 
            BtnValider.Enabled = false;
            BtnValider.Location = new Point(429, 327);
            BtnValider.Name = "BtnValider";
            BtnValider.Size = new Size(94, 29);
            BtnValider.TabIndex = 1;
            BtnValider.Text = "Valider";
            BtnValider.UseVisualStyleBackColor = true;
            // 
            // LblSelectionHoraire
            // 
            LblSelectionHoraire.AutoSize = true;
            LblSelectionHoraire.Location = new Point(81, 186);
            LblSelectionHoraire.Name = "LblSelectionHoraire";
            LblSelectionHoraire.Size = new Size(236, 20);
            LblSelectionHoraire.TabIndex = 2;
            LblSelectionHoraire.Text = "Selectionner l'Horaire à Modifier : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 253);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 3;
            label2.Text = "Nouvel Horaire : ";
            // 
            // ComboBoxHoraires
            // 
            ComboBoxHoraires.FormattingEnabled = true;
            ComboBoxHoraires.Location = new Point(336, 183);
            ComboBoxHoraires.Name = "ComboBoxHoraires";
            ComboBoxHoraires.Size = new Size(151, 28);
            ComboBoxHoraires.TabIndex = 4;
            // 
            // LblSelectionLigne
            // 
            LblSelectionLigne.AutoSize = true;
            LblSelectionLigne.Location = new Point(162, 120);
            LblSelectionLigne.Name = "LblSelectionLigne";
            LblSelectionLigne.Size = new Size(155, 20);
            LblSelectionLigne.TabIndex = 5;
            LblSelectionLigne.Text = "Selectionner la ligne : ";
            // 
            // ComboBoxSelectinLigne
            // 
            ComboBoxSelectinLigne.FormattingEnabled = true;
            ComboBoxSelectinLigne.Location = new Point(336, 120);
            ComboBoxSelectinLigne.Name = "ComboBoxSelectinLigne";
            ComboBoxSelectinLigne.Size = new Size(151, 28);
            ComboBoxSelectinLigne.TabIndex = 6;
            // 
            // NumUpADownHeure
            // 
            NumUpADownHeure.Location = new Point(336, 251);
            NumUpADownHeure.Name = "NumUpADownHeure";
            NumUpADownHeure.Size = new Size(73, 27);
            NumUpADownHeure.TabIndex = 7;
            // 
            // NumUpADownMinute
            // 
            NumUpADownMinute.Location = new Point(414, 251);
            NumUpADownMinute.Name = "NumUpADownMinute";
            NumUpADownMinute.Size = new Size(73, 27);
            NumUpADownMinute.TabIndex = 8;
            // 
            // PageModificationHoraire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NumUpADownMinute);
            Controls.Add(NumUpADownHeure);
            Controls.Add(ComboBoxSelectinLigne);
            Controls.Add(LblSelectionLigne);
            Controls.Add(ComboBoxHoraires);
            Controls.Add(label2);
            Controls.Add(LblSelectionHoraire);
            Controls.Add(BtnValider);
            Controls.Add(BtnRetour);
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
        private Label label2;
        private ComboBox ComboBoxHoraires;
        private Label LblSelectionLigne;
        private ComboBox ComboBoxSelectinLigne;
        private NumericUpDown NumUpADownHeure;
        private NumericUpDown NumUpADownMinute;
    }
}
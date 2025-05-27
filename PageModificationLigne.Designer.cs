namespace SAE_S2._01
{
    partial class PageModificationLigne
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
            LblSelectionLigne = new Label();
            ComboBoxSelectLigne = new ComboBox();
            LblDepartLigne = new Label();
            NumUpADownNbArret = new NumericUpDown();
            flpArretsDesservis = new FlowLayoutPanel();
            LblSelectionArrets = new Label();
            BtnRetour = new Button();
            BtnValider = new Button();
            LblWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)NumUpADownNbArret).BeginInit();
            SuspendLayout();
            // 
            // LblSelectionLigne
            // 
            LblSelectionLigne.AutoSize = true;
            LblSelectionLigne.Location = new Point(81, 59);
            LblSelectionLigne.Name = "LblSelectionLigne";
            LblSelectionLigne.Size = new Size(228, 20);
            LblSelectionLigne.TabIndex = 0;
            LblSelectionLigne.Text = "Selectionner la ligne à modifier : ";
            LblSelectionLigne.Click += label1_Click;
            // 
            // ComboBoxSelectLigne
            // 
            ComboBoxSelectLigne.FormattingEnabled = true;
            ComboBoxSelectLigne.Location = new Point(315, 56);
            ComboBoxSelectLigne.Name = "ComboBoxSelectLigne";
            ComboBoxSelectLigne.Size = new Size(151, 28);
            ComboBoxSelectLigne.TabIndex = 1;
            // 
            // LblDepartLigne
            // 
            LblDepartLigne.AutoSize = true;
            LblDepartLigne.Location = new Point(56, 119);
            LblDepartLigne.Name = "LblDepartLigne";
            LblDepartLigne.Size = new Size(253, 20);
            LblDepartLigne.TabIndex = 2;
            LblDepartLigne.Text = "Nombre d'arrêts présent dans ligne : ";
            // 
            // NumUpADownNbArret
            // 
            NumUpADownNbArret.Location = new Point(315, 117);
            NumUpADownNbArret.Name = "NumUpADownNbArret";
            NumUpADownNbArret.Size = new Size(88, 27);
            NumUpADownNbArret.TabIndex = 3;
            // 
            // flpArretsDesservis
            // 
            flpArretsDesservis.Location = new Point(315, 186);
            flpArretsDesservis.Name = "flpArretsDesservis";
            flpArretsDesservis.Size = new Size(328, 150);
            flpArretsDesservis.TabIndex = 4;
            // 
            // LblSelectionArrets
            // 
            LblSelectionArrets.AutoSize = true;
            LblSelectionArrets.Location = new Point(78, 177);
            LblSelectionArrets.Name = "LblSelectionArrets";
            LblSelectionArrets.Size = new Size(228, 20);
            LblSelectionArrets.TabIndex = 5;
            LblSelectionArrets.Text = "Selectionner les arrêts desservis : ";
            LblSelectionArrets.Click += label1_Click_1;
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(293, 379);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(94, 29);
            BtnRetour.TabIndex = 6;
            BtnRetour.Text = "Retour";
            BtnRetour.UseVisualStyleBackColor = true;
            // 
            // BtnValider
            // 
            BtnValider.Location = new Point(423, 379);
            BtnValider.Name = "BtnValider";
            BtnValider.Size = new Size(94, 29);
            BtnValider.TabIndex = 7;
            BtnValider.Text = "Valider";
            BtnValider.UseVisualStyleBackColor = true;
            // 
            // LblWarning
            // 
            LblWarning.AutoSize = true;
            LblWarning.Location = new Point(148, 197);
            LblWarning.Name = "LblWarning";
            LblWarning.Size = new Size(161, 20);
            LblWarning.TabIndex = 8;
            LblWarning.Text = "( Sens de la descente ) ";
            LblWarning.Click += LblWarning_Click;
            // 
            // PageModificationLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblWarning);
            Controls.Add(BtnValider);
            Controls.Add(BtnRetour);
            Controls.Add(LblSelectionArrets);
            Controls.Add(flpArretsDesservis);
            Controls.Add(NumUpADownNbArret);
            Controls.Add(LblDepartLigne);
            Controls.Add(ComboBoxSelectLigne);
            Controls.Add(LblSelectionLigne);
            Name = "PageModificationLigne";
            Text = "PageModificationLigne";
            ((System.ComponentModel.ISupportInitialize)NumUpADownNbArret).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblSelectionLigne;
        private ComboBox ComboBoxSelectLigne;
        private Label LblDepartLigne;
        private NumericUpDown NumUpADownNbArret;
        private FlowLayoutPanel flpArretsDesservis;
        private Label LblSelectionArrets;
        private Button BtnRetour;
        private Button BtnValider;
        private Label LblWarning;
    }
}
namespace SAE_S2._01
{
    partial class PageModificationArret
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
            LabelChoixArret = new Label();
            comboBoxArret = new ComboBox();
            BtnRetour = new Button();
            BtnValider = new Button();
            LabelNomArret = new Label();
            TxtBoxNom = new TextBox();
            LblLattitude = new Label();
            LblLongitude = new Label();
            TxtBoxLattitude = new TextBox();
            TxtBoxLongittude = new TextBox();
            SuspendLayout();
            // 
            // LabelChoixArret
            // 
            LabelChoixArret.AutoSize = true;
            LabelChoixArret.Location = new Point(67, 84);
            LabelChoixArret.Name = "LabelChoixArret";
            LabelChoixArret.Size = new Size(202, 20);
            LabelChoixArret.TabIndex = 0;
            LabelChoixArret.Text = "Choisissez l'arrêt à Modifier : ";
            // 
            // comboBoxArret
            // 
            comboBoxArret.FormattingEnabled = true;
            comboBoxArret.Location = new Point(291, 81);
            comboBoxArret.Name = "comboBoxArret";
            comboBoxArret.Size = new Size(151, 28);
            comboBoxArret.TabIndex = 1;
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(254, 354);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(94, 29);
            BtnRetour.TabIndex = 2;
            BtnRetour.Text = "Retour";
            BtnRetour.UseVisualStyleBackColor = true;
            // 
            // BtnValider
            // 
            BtnValider.Enabled = false;
            BtnValider.Location = new Point(444, 354);
            BtnValider.Name = "BtnValider";
            BtnValider.Size = new Size(94, 29);
            BtnValider.TabIndex = 3;
            BtnValider.Text = "Valider";
            BtnValider.UseVisualStyleBackColor = true;
            BtnValider.Click += BtnValider_Click;
            // 
            // LabelNomArret
            // 
            LabelNomArret.AutoSize = true;
            LabelNomArret.Location = new Point(153, 148);
            LabelNomArret.Name = "LabelNomArret";
            LabelNomArret.Size = new Size(116, 20);
            LabelNomArret.TabIndex = 4;
            LabelNomArret.Text = "Nom de l'arrêt : ";
            // 
            // TxtBoxNom
            // 
            TxtBoxNom.Location = new Point(291, 145);
            TxtBoxNom.Name = "TxtBoxNom";
            TxtBoxNom.Size = new Size(125, 27);
            TxtBoxNom.TabIndex = 5;
            // 
            // LblLattitude
            // 
            LblLattitude.AutoSize = true;
            LblLattitude.Location = new Point(127, 203);
            LblLattitude.Name = "LblLattitude";
            LblLattitude.Size = new Size(142, 20);
            LblLattitude.TabIndex = 6;
            LblLattitude.Text = "Lattitude de l'arrêt : ";
            // 
            // LblLongitude
            // 
            LblLongitude.AutoSize = true;
            LblLongitude.Location = new Point(114, 258);
            LblLongitude.Name = "LblLongitude";
            LblLongitude.Size = new Size(155, 20);
            LblLongitude.TabIndex = 7;
            LblLongitude.Text = "Longittude de l'arrêt : ";
            // 
            // TxtBoxLattitude
            // 
            TxtBoxLattitude.Location = new Point(291, 203);
            TxtBoxLattitude.Name = "TxtBoxLattitude";
            TxtBoxLattitude.Size = new Size(125, 27);
            TxtBoxLattitude.TabIndex = 8;
            // 
            // TxtBoxLongittude
            // 
            TxtBoxLongittude.Location = new Point(291, 258);
            TxtBoxLongittude.Name = "TxtBoxLongittude";
            TxtBoxLongittude.Size = new Size(125, 27);
            TxtBoxLongittude.TabIndex = 9;
            // 
            // PageModificationArret
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtBoxLongittude);
            Controls.Add(TxtBoxLattitude);
            Controls.Add(LblLongitude);
            Controls.Add(LblLattitude);
            Controls.Add(TxtBoxNom);
            Controls.Add(LabelNomArret);
            Controls.Add(BtnValider);
            Controls.Add(BtnRetour);
            Controls.Add(comboBoxArret);
            Controls.Add(LabelChoixArret);
            Name = "PageModificationArret";
            Text = "PageModificationArret";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelChoixArret;
        private ComboBox comboBoxArret;
        private Button BtnRetour;
        private Button BtnValider;
        private Label LabelNomArret;
        private TextBox TxtBoxNom;
        private Label LblLattitude;
        private Label LblLongitude;
        private TextBox TxtBoxLattitude;
        private TextBox TxtBoxLongittude;
    }
}
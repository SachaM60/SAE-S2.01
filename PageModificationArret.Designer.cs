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
            LbNom = new Label();
            TxtBoxNom = new TextBox();
            Lblat = new Label();
            Lblong = new Label();
            TxtBoxLat = new TextBox();
            TxtBoxLong = new TextBox();
            lbErreurLat = new Label();
            lbErreurLong = new Label();
            SuspendLayout();
            // 
            // LabelChoixArret
            // 
            LabelChoixArret.AutoSize = true;
            LabelChoixArret.Location = new Point(158, 64);
            LabelChoixArret.Margin = new Padding(4, 0, 4, 0);
            LabelChoixArret.Name = "LabelChoixArret";
            LabelChoixArret.Size = new Size(242, 25);
            LabelChoixArret.TabIndex = 0;
            LabelChoixArret.Text = "Choisissez l'arrêt à Modifier : ";
            // 
            // comboBoxArret
            // 
            comboBoxArret.FormattingEnabled = true;
            comboBoxArret.Location = new Point(438, 60);
            comboBoxArret.Margin = new Padding(4);
            comboBoxArret.Name = "comboBoxArret";
            comboBoxArret.Size = new Size(223, 33);
            comboBoxArret.TabIndex = 1;
            comboBoxArret.SelectedIndexChanged += comboBoxArret_SelectedIndexChanged;
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(116, 513);
            BtnRetour.Margin = new Padding(4);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(273, 36);
            BtnRetour.TabIndex = 2;
            BtnRetour.Text = "Retour";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // BtnValider
            // 
            BtnValider.Enabled = false;
            BtnValider.Location = new Point(634, 513);
            BtnValider.Margin = new Padding(4);
            BtnValider.Name = "BtnValider";
            BtnValider.Size = new Size(273, 36);
            BtnValider.TabIndex = 3;
            BtnValider.Text = "Valider";
            BtnValider.UseVisualStyleBackColor = true;
            BtnValider.Click += BtnValider_Click;
            // 
            // LbNom
            // 
            LbNom.AutoSize = true;
            LbNom.Location = new Point(265, 196);
            LbNom.Margin = new Padding(4, 0, 4, 0);
            LbNom.Name = "LbNom";
            LbNom.Size = new Size(140, 25);
            LbNom.TabIndex = 4;
            LbNom.Text = "Nom de l'arrêt : ";
            // 
            // TxtBoxNom
            // 
            TxtBoxNom.Location = new Point(438, 192);
            TxtBoxNom.Margin = new Padding(4);
            TxtBoxNom.Name = "TxtBoxNom";
            TxtBoxNom.Size = new Size(223, 31);
            TxtBoxNom.TabIndex = 5;
            // 
            // Lblat
            // 
            Lblat.AutoSize = true;
            Lblat.Location = new Point(233, 278);
            Lblat.Margin = new Padding(4, 0, 4, 0);
            Lblat.Name = "Lblat";
            Lblat.Size = new Size(163, 25);
            Lblat.TabIndex = 6;
            Lblat.Text = "Latitude de l'arrêt : ";
            // 
            // Lblong
            // 
            Lblong.AutoSize = true;
            Lblong.Location = new Point(216, 361);
            Lblong.Margin = new Padding(4, 0, 4, 0);
            Lblong.Name = "Lblong";
            Lblong.Size = new Size(180, 25);
            Lblong.TabIndex = 7;
            Lblong.Text = "Longitude de l'arrêt : ";
            // 
            // TxtBoxLat
            // 
            TxtBoxLat.Location = new Point(438, 278);
            TxtBoxLat.Margin = new Padding(4);
            TxtBoxLat.Name = "TxtBoxLat";
            TxtBoxLat.Size = new Size(223, 31);
            TxtBoxLat.TabIndex = 8;
            // 
            // TxtBoxLong
            // 
            TxtBoxLong.Location = new Point(438, 361);
            TxtBoxLong.Margin = new Padding(4);
            TxtBoxLong.Name = "TxtBoxLong";
            TxtBoxLong.Size = new Size(223, 31);
            TxtBoxLong.TabIndex = 9;
            // 
            // lbErreurLat
            // 
            lbErreurLat.AutoSize = true;
            lbErreurLat.Location = new Point(682, 284);
            lbErreurLat.Name = "lbErreurLat";
            lbErreurLat.Size = new Size(58, 25);
            lbErreurLat.TabIndex = 10;
            lbErreurLat.Text = "Erreur";
            // 
            // lbErreurLong
            // 
            lbErreurLong.AutoSize = true;
            lbErreurLong.Location = new Point(682, 367);
            lbErreurLong.Name = "lbErreurLong";
            lbErreurLong.Size = new Size(58, 25);
            lbErreurLong.TabIndex = 11;
            lbErreurLong.Text = "Erreur";
            // 
            // PageModificationArret
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(lbErreurLong);
            Controls.Add(lbErreurLat);
            Controls.Add(TxtBoxLong);
            Controls.Add(TxtBoxLat);
            Controls.Add(Lblong);
            Controls.Add(Lblat);
            Controls.Add(TxtBoxNom);
            Controls.Add(LbNom);
            Controls.Add(BtnValider);
            Controls.Add(BtnRetour);
            Controls.Add(comboBoxArret);
            Controls.Add(LabelChoixArret);
            Margin = new Padding(4);
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
        private Label LbNom;
        private TextBox TxtBoxNom;
        private Label Lblat;
        private Label Lblong;
        private TextBox TxtBoxLat;
        private TextBox TxtBoxLong;
        private Label lbErreurLat;
        private Label lbErreurLong;
    }
}
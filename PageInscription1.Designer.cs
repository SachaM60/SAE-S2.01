namespace SAE_S2._01
{
    partial class PageInscription1
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
            btnRetourInscription = new Button();
            lblNomInscription = new Label();
            lblPrenomInscription = new Label();
            lblAgeInscription = new Label();
            lblSexeInscription = new Label();
            btnValiderInscription = new Button();
            txtNomInscription = new TextBox();
            txtPrenomInscription = new TextBox();
            numAgeInscription = new NumericUpDown();
            comboBoxSexe = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numAgeInscription).BeginInit();
            SuspendLayout();
            // 
            // btnRetourInscription
            // 
            btnRetourInscription.Location = new Point(445, 465);
            btnRetourInscription.Margin = new Padding(4);
            btnRetourInscription.Name = "btnRetourInscription";
            btnRetourInscription.Size = new Size(118, 36);
            btnRetourInscription.TabIndex = 0;
            btnRetourInscription.Text = "Retour";
            btnRetourInscription.UseVisualStyleBackColor = true;
            btnRetourInscription.Click += btnRetourInscription_Click;
            // 
            // lblNomInscription
            // 
            lblNomInscription.AutoSize = true;
            lblNomInscription.Location = new Point(286, 90);
            lblNomInscription.Margin = new Padding(4, 0, 4, 0);
            lblNomInscription.Name = "lblNomInscription";
            lblNomInscription.Size = new Size(61, 25);
            lblNomInscription.TabIndex = 1;
            lblNomInscription.Text = "Nom :";
            // 
            // lblPrenomInscription
            // 
            lblPrenomInscription.AutoSize = true;
            lblPrenomInscription.Location = new Point(264, 164);
            lblPrenomInscription.Margin = new Padding(4, 0, 4, 0);
            lblPrenomInscription.Name = "lblPrenomInscription";
            lblPrenomInscription.Size = new Size(83, 25);
            lblPrenomInscription.TabIndex = 2;
            lblPrenomInscription.Text = "Prénom :";
            // 
            // lblAgeInscription
            // 
            lblAgeInscription.AutoSize = true;
            lblAgeInscription.Location = new Point(294, 234);
            lblAgeInscription.Margin = new Padding(4, 0, 4, 0);
            lblAgeInscription.Name = "lblAgeInscription";
            lblAgeInscription.Size = new Size(53, 25);
            lblAgeInscription.TabIndex = 3;
            lblAgeInscription.Text = "Age :";
            // 
            // lblSexeInscription
            // 
            lblSexeInscription.AutoSize = true;
            lblSexeInscription.Location = new Point(286, 304);
            lblSexeInscription.Margin = new Padding(4, 0, 4, 0);
            lblSexeInscription.Name = "lblSexeInscription";
            lblSexeInscription.Size = new Size(57, 25);
            lblSexeInscription.TabIndex = 4;
            lblSexeInscription.Text = "Sexe :";
            // 
            // btnValiderInscription
            // 
            btnValiderInscription.Location = new Point(444, 405);
            btnValiderInscription.Margin = new Padding(4);
            btnValiderInscription.Name = "btnValiderInscription";
            btnValiderInscription.Size = new Size(118, 36);
            btnValiderInscription.TabIndex = 5;
            btnValiderInscription.Text = "Valider";
            btnValiderInscription.UseVisualStyleBackColor = true;
            btnValiderInscription.Click += btnValiderInscription_Click;
            // 
            // txtNomInscription
            // 
            txtNomInscription.Location = new Point(444, 86);
            txtNomInscription.Margin = new Padding(4);
            txtNomInscription.Name = "txtNomInscription";
            txtNomInscription.Size = new Size(155, 31);
            txtNomInscription.TabIndex = 6;
            // 
            // txtPrenomInscription
            // 
            txtPrenomInscription.Location = new Point(444, 164);
            txtPrenomInscription.Margin = new Padding(4);
            txtPrenomInscription.Name = "txtPrenomInscription";
            txtPrenomInscription.Size = new Size(155, 31);
            txtPrenomInscription.TabIndex = 7;
            // 
            // numAgeInscription
            // 
            numAgeInscription.Location = new Point(444, 234);
            numAgeInscription.Margin = new Padding(4);
            numAgeInscription.Name = "numAgeInscription";
            numAgeInscription.Size = new Size(155, 31);
            numAgeInscription.TabIndex = 8;
            // 
            // comboBoxSexe
            // 
            comboBoxSexe.FormattingEnabled = true;
            comboBoxSexe.Location = new Point(445, 304);
            comboBoxSexe.Name = "comboBoxSexe";
            comboBoxSexe.Size = new Size(154, 33);
            comboBoxSexe.TabIndex = 9;
            // 
            // PageInscription1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(comboBoxSexe);
            Controls.Add(numAgeInscription);
            Controls.Add(txtPrenomInscription);
            Controls.Add(txtNomInscription);
            Controls.Add(btnValiderInscription);
            Controls.Add(lblSexeInscription);
            Controls.Add(lblAgeInscription);
            Controls.Add(lblPrenomInscription);
            Controls.Add(lblNomInscription);
            Controls.Add(btnRetourInscription);
            Margin = new Padding(4);
            Name = "PageInscription1";
            Text = "Inscription";
            ((System.ComponentModel.ISupportInitialize)numAgeInscription).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetourInscription;
        private Label lblNomInscription;
        private Label lblPrenomInscription;
        private Label lblAgeInscription;
        private Label lblSexeInscription;
        private Button btnValiderInscription;
        private TextBox txtNomInscription;
        private TextBox txtPrenomInscription;
        private NumericUpDown numAgeInscription;
        private ComboBox comboBoxSexe;
    }
}
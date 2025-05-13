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
            ((System.ComponentModel.ISupportInitialize)numAgeInscription).BeginInit();
            SuspendLayout();
            // 
            // btnRetourInscription
            // 
            btnRetourInscription.Location = new Point(356, 372);
            btnRetourInscription.Name = "btnRetourInscription";
            btnRetourInscription.Size = new Size(94, 29);
            btnRetourInscription.TabIndex = 0;
            btnRetourInscription.Text = "Retour";
            btnRetourInscription.UseVisualStyleBackColor = true;
            btnRetourInscription.Click += btnRetourInscription_Click;
            // 
            // lblNomInscription
            // 
            lblNomInscription.AutoSize = true;
            lblNomInscription.Location = new Point(229, 72);
            lblNomInscription.Name = "lblNomInscription";
            lblNomInscription.Size = new Size(49, 20);
            lblNomInscription.TabIndex = 1;
            lblNomInscription.Text = "Nom :";
            // 
            // lblPrenomInscription
            // 
            lblPrenomInscription.AutoSize = true;
            lblPrenomInscription.Location = new Point(211, 131);
            lblPrenomInscription.Name = "lblPrenomInscription";
            lblPrenomInscription.Size = new Size(67, 20);
            lblPrenomInscription.TabIndex = 2;
            lblPrenomInscription.Text = "Prénom :";
            // 
            // lblAgeInscription
            // 
            lblAgeInscription.AutoSize = true;
            lblAgeInscription.Location = new Point(235, 187);
            lblAgeInscription.Name = "lblAgeInscription";
            lblAgeInscription.Size = new Size(43, 20);
            lblAgeInscription.TabIndex = 3;
            lblAgeInscription.Text = "Age :";
            // 
            // lblSexeInscription
            // 
            lblSexeInscription.AutoSize = true;
            lblSexeInscription.Location = new Point(229, 243);
            lblSexeInscription.Name = "lblSexeInscription";
            lblSexeInscription.Size = new Size(47, 20);
            lblSexeInscription.TabIndex = 4;
            lblSexeInscription.Text = "Sexe :";
            // 
            // btnValiderInscription
            // 
            btnValiderInscription.Location = new Point(355, 324);
            btnValiderInscription.Name = "btnValiderInscription";
            btnValiderInscription.Size = new Size(94, 29);
            btnValiderInscription.TabIndex = 5;
            btnValiderInscription.Text = "Valider";
            btnValiderInscription.UseVisualStyleBackColor = true;
            btnValiderInscription.Click += btnValiderInscription_Click;
            // 
            // txtNomInscription
            // 
            txtNomInscription.Location = new Point(355, 69);
            txtNomInscription.Name = "txtNomInscription";
            txtNomInscription.Size = new Size(125, 27);
            txtNomInscription.TabIndex = 6;
            // 
            // txtPrenomInscription
            // 
            txtPrenomInscription.Location = new Point(355, 131);
            txtPrenomInscription.Name = "txtPrenomInscription";
            txtPrenomInscription.Size = new Size(125, 27);
            txtPrenomInscription.TabIndex = 7;
            // 
            // numAgeInscription
            // 
            numAgeInscription.Location = new Point(355, 187);
            numAgeInscription.Name = "numAgeInscription";
            numAgeInscription.Size = new Size(150, 27);
            numAgeInscription.TabIndex = 8;
            // 
            // PageInscription1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numAgeInscription);
            Controls.Add(txtPrenomInscription);
            Controls.Add(txtNomInscription);
            Controls.Add(btnValiderInscription);
            Controls.Add(lblSexeInscription);
            Controls.Add(lblAgeInscription);
            Controls.Add(lblPrenomInscription);
            Controls.Add(lblNomInscription);
            Controls.Add(btnRetourInscription);
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
    }
}
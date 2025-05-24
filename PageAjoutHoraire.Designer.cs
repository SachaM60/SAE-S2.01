namespace SAE_S2._01
{
    partial class PageAjoutHoraire
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
            label1 = new Label();
            comboxArret = new ComboBox();
            comboBoxBus = new ComboBox();
            comboBoxLigne = new ComboBox();
            txtBoxHoraire = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnRetour = new Button();
            btnValider = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 25);
            label1.Name = "label1";
            label1.Size = new Size(250, 25);
            label1.TabIndex = 0;
            label1.Text = "Ajout d'un horaire de passage";
            // 
            // comboxArret
            // 
            comboxArret.FormattingEnabled = true;
            comboxArret.Location = new Point(315, 223);
            comboxArret.Name = "comboxArret";
            comboxArret.Size = new Size(182, 33);
            comboxArret.TabIndex = 1;
            // 
            // comboBoxBus
            // 
            comboBoxBus.FormattingEnabled = true;
            comboBoxBus.Location = new Point(315, 104);
            comboBoxBus.Name = "comboBoxBus";
            comboBoxBus.Size = new Size(182, 33);
            comboBoxBus.TabIndex = 2;
            // 
            // comboBoxLigne
            // 
            comboBoxLigne.FormattingEnabled = true;
            comboBoxLigne.Location = new Point(315, 167);
            comboBoxLigne.Name = "comboBoxLigne";
            comboBoxLigne.Size = new Size(182, 33);
            comboBoxLigne.TabIndex = 3;
            // 
            // txtBoxHoraire
            // 
            txtBoxHoraire.Location = new Point(315, 282);
            txtBoxHoraire.Name = "txtBoxHoraire";
            txtBoxHoraire.Size = new Size(182, 31);
            txtBoxHoraire.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 107);
            label2.Name = "label2";
            label2.Size = new Size(279, 25);
            label2.TabIndex = 5;
            label2.Text = "Quel bus se charge du ramassage";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 167);
            label3.Name = "label3";
            label3.Size = new Size(218, 25);
            label3.TabIndex = 6;
            label3.Text = "Quelle ligne est concernée";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 226);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 7;
            label4.Text = "Arrêt de départ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 282);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 8;
            label5.Text = "Horaire";
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(96, 404);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(269, 34);
            btnRetour.TabIndex = 9;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(443, 404);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(269, 34);
            btnValider.TabIndex = 10;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // PageAjoutHoraire
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValider);
            Controls.Add(btnRetour);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxHoraire);
            Controls.Add(comboBoxLigne);
            Controls.Add(comboBoxBus);
            Controls.Add(comboxArret);
            Controls.Add(label1);
            Name = "PageAjoutHoraire";
            Text = "PageAjoutHoraire";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboxArret;
        private ComboBox comboBoxBus;
        private ComboBox comboBoxLigne;
        private TextBox txtBoxHoraire;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRetour;
        private Button btnValider;
    }
}
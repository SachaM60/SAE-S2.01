namespace SAE_S2._01
{
    partial class PageAjoutLigne
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
            label2 = new Label();
            txtBoxNom = new TextBox();
            numericUpDownNbArret = new NumericUpDown();
            label3 = new Label();
            lbArret = new Label();
            flpArret = new FlowLayoutPanel();
            btnRetour = new Button();
            btnValider = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNbArret).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 18);
            label1.Name = "label1";
            label1.Size = new Size(241, 25);
            label1.TabIndex = 0;
            label1.Text = "Création d'une nouvelle ligne";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 64);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 1;
            label2.Text = "Nom de la ligne : ";
            // 
            // txtBoxNom
            // 
            txtBoxNom.Location = new Point(238, 64);
            txtBoxNom.Name = "txtBoxNom";
            txtBoxNom.Size = new Size(183, 31);
            txtBoxNom.TabIndex = 2;
            // 
            // numericUpDownNbArret
            // 
            numericUpDownNbArret.Location = new Point(311, 145);
            numericUpDownNbArret.Name = "numericUpDownNbArret";
            numericUpDownNbArret.Size = new Size(110, 31);
            numericUpDownNbArret.TabIndex = 3;
            numericUpDownNbArret.ValueChanged += numericUpDownNbArret_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 145);
            label3.Name = "label3";
            label3.Size = new Size(271, 25);
            label3.TabIndex = 4;
            label3.Text = "Par combien d'arrêt passe-t-elle :";
            // 
            // lbArret
            // 
            lbArret.AutoSize = true;
            lbArret.Location = new Point(30, 204);
            lbArret.Name = "lbArret";
            lbArret.Size = new Size(155, 25);
            lbArret.TabIndex = 5;
            lbArret.Text = "Choisir les arrêts : ";
            // 
            // flpArret
            // 
            flpArret.Location = new Point(191, 208);
            flpArret.Name = "flpArret";
            flpArret.Size = new Size(532, 192);
            flpArret.TabIndex = 6;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(82, 404);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(289, 34);
            btnRetour.TabIndex = 7;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(434, 404);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(289, 34);
            btnValider.TabIndex = 8;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // PageAjoutLigne
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValider);
            Controls.Add(btnRetour);
            Controls.Add(flpArret);
            Controls.Add(lbArret);
            Controls.Add(label3);
            Controls.Add(numericUpDownNbArret);
            Controls.Add(txtBoxNom);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PageAjoutLigne";
            Text = "PageAjoutLigne";
            ((System.ComponentModel.ISupportInitialize)numericUpDownNbArret).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBoxNom;
        private NumericUpDown numericUpDownNbArret;
        private Label label3;
        private Label lbArret;
        private FlowLayoutPanel flpArret;
        private Button btnRetour;
        private Button btnValider;
    }
}
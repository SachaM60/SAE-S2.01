namespace SAE_S2._01
{
    partial class PageAjoutArret
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
            btnRetour = new Button();
            btnValider = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbLigne = new Label();
            numericUpDownNbLigne = new NumericUpDown();
            txtBoxNom = new TextBox();
            flpLigne = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNbLigne).BeginInit();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(139, 516);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(327, 34);
            btnRetour.TabIndex = 0;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(556, 516);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(327, 34);
            btnValider.TabIndex = 1;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 36);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 2;
            label1.Text = "Création d'un arrêt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 125);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 3;
            label2.Text = "Nom de l'arrêt : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 199);
            label3.Name = "label3";
            label3.Size = new Size(300, 25);
            label3.TabIndex = 4;
            label3.Text = "Combien de lignes sont desservies : ";
            // 
            // lbLigne
            // 
            lbLigne.AutoSize = true;
            lbLigne.Location = new Point(139, 268);
            lbLigne.Name = "lbLigne";
            lbLigne.Size = new Size(101, 25);
            lbLigne.TabIndex = 5;
            lbLigne.Text = "Lesquelles :";
            // 
            // numericUpDownNbLigne
            // 
            numericUpDownNbLigne.Location = new Point(498, 197);
            numericUpDownNbLigne.Name = "numericUpDownNbLigne";
            numericUpDownNbLigne.Size = new Size(180, 31);
            numericUpDownNbLigne.TabIndex = 6;
            numericUpDownNbLigne.ValueChanged += numericUpDownNbLigne_ValueChanged;
            // 
            // txtBoxNom
            // 
            txtBoxNom.Location = new Point(316, 125);
            txtBoxNom.Name = "txtBoxNom";
            txtBoxNom.Size = new Size(227, 31);
            txtBoxNom.TabIndex = 7;
            // 
            // flpLigne
            // 
            flpLigne.Location = new Point(316, 268);
            flpLigne.Name = "flpLigne";
            flpLigne.Size = new Size(362, 242);
            flpLigne.TabIndex = 8;
            // 
            // PageAjoutArret
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(flpLigne);
            Controls.Add(txtBoxNom);
            Controls.Add(numericUpDownNbLigne);
            Controls.Add(lbLigne);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnValider);
            Controls.Add(btnRetour);
            Margin = new Padding(4);
            Name = "PageAjoutArret";
            Text = "Ajout de données";
            ((System.ComponentModel.ISupportInitialize)numericUpDownNbLigne).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetour;
        private Button btnValider;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbLigne;
        private NumericUpDown numericUpDownNbLigne;
        private TextBox txtBoxNom;
        private FlowLayoutPanel flpLigne;
    }
}
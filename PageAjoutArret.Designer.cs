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
            txtBoxNom = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtBoxLatitude = new TextBox();
            txtBoxLongitude = new TextBox();
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
            label2.Location = new Point(296, 167);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 3;
            label2.Text = "Nom de l'arrêt : ";
            // 
            // txtBoxNom
            // 
            txtBoxNom.Location = new Point(479, 161);
            txtBoxNom.Name = "txtBoxNom";
            txtBoxNom.Size = new Size(227, 31);
            txtBoxNom.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 238);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 8;
            label3.Text = "Latitude de l'arrêt : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 319);
            label4.Name = "label4";
            label4.Size = new Size(180, 25);
            label4.TabIndex = 9;
            label4.Text = "Longitude de l'arrêt : ";
            // 
            // txtBoxLatitude
            // 
            txtBoxLatitude.Location = new Point(479, 238);
            txtBoxLatitude.Name = "txtBoxLatitude";
            txtBoxLatitude.Size = new Size(227, 31);
            txtBoxLatitude.TabIndex = 10;
            // 
            // txtBoxLongitude
            // 
            txtBoxLongitude.Location = new Point(479, 319);
            txtBoxLongitude.Name = "txtBoxLongitude";
            txtBoxLongitude.Size = new Size(227, 31);
            txtBoxLongitude.TabIndex = 11;
            // 
            // PageAjoutArret
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(txtBoxLongitude);
            Controls.Add(txtBoxLatitude);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBoxNom);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnValider);
            Controls.Add(btnRetour);
            Margin = new Padding(4);
            Name = "PageAjoutArret";
            Text = "Ajout de données";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetour;
        private Button btnValider;
        private Label label1;
        private Label label2;
        private TextBox txtBoxNom;
        private Label label3;
        private Label label4;
        private TextBox txtBoxLatitude;
        private TextBox txtBoxLongitude;
    }
}
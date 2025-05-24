namespace SAE_S2._01
{
    partial class PageSuppressionArret
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
            btnSupprimer = new Button();
            btnRetour = new Button();
            lstBoxArret = new ListBox();
            lbArret = new Label();
            lbLigne = new Label();
            flpLigne = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(531, 402);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(245, 34);
            btnSupprimer.TabIndex = 5;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(241, 402);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(245, 34);
            btnRetour.TabIndex = 4;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // lstBoxArret
            // 
            lstBoxArret.FormattingEnabled = true;
            lstBoxArret.ItemHeight = 25;
            lstBoxArret.Location = new Point(24, 11);
            lstBoxArret.Name = "lstBoxArret";
            lstBoxArret.Size = new Size(180, 429);
            lstBoxArret.TabIndex = 3;
            lstBoxArret.SelectedIndexChanged += lstBoxArret_SelectedIndexChanged;
            // 
            // lbArret
            // 
            lbArret.AutoSize = true;
            lbArret.Location = new Point(217, 79);
            lbArret.Name = "lbArret";
            lbArret.Size = new Size(269, 25);
            lbArret.TabIndex = 6;
            lbArret.Text = "Arrêt sélectionné : nom de l'arrêt";
            // 
            // lbLigne
            // 
            lbLigne.AutoSize = true;
            lbLigne.Location = new Point(224, 166);
            lbLigne.Name = "lbLigne";
            lbLigne.Size = new Size(141, 25);
            lbLigne.TabIndex = 7;
            lbLigne.Text = "Ligne désservie :";
            // 
            // flpLigne
            // 
            flpLigne.Location = new Point(381, 166);
            flpLigne.Name = "flpLigne";
            flpLigne.Size = new Size(395, 150);
            flpLigne.TabIndex = 8;
            // 
            // PageSuppressionArret
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpLigne);
            Controls.Add(lbLigne);
            Controls.Add(lbArret);
            Controls.Add(btnSupprimer);
            Controls.Add(btnRetour);
            Controls.Add(lstBoxArret);
            Name = "PageSuppressionArret";
            Text = "PageSuppressionArret";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSupprimer;
        private Button btnRetour;
        private ListBox lstBoxArret;
        private Label lbArret;
        private Label lbLigne;
        private FlowLayoutPanel flpLigne;
    }
}
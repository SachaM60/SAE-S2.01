namespace SAE_S2._01
{
    partial class PageCalculItineraire
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
            btnPlan = new Button();
            btnCalculItinéraire = new Button();
            btnFavoris = new Button();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // btnPlan
            // 
            btnPlan.Location = new Point(597, 422);
            btnPlan.Name = "btnPlan";
            btnPlan.Size = new Size(201, 29);
            btnPlan.TabIndex = 8;
            btnPlan.Text = "Plan du réseau";
            btnPlan.UseVisualStyleBackColor = true;
            btnPlan.Click += btnPlan_Click;
            // 
            // btnCalculItinéraire
            // 
            btnCalculItinéraire.BackColor = SystemColors.Highlight;
            btnCalculItinéraire.Location = new Point(380, 422);
            btnCalculItinéraire.Name = "btnCalculItinéraire";
            btnCalculItinéraire.Size = new Size(220, 29);
            btnCalculItinéraire.TabIndex = 7;
            btnCalculItinéraire.Text = "Calcul d'itinéraire";
            btnCalculItinéraire.UseVisualStyleBackColor = false;
            // 
            // btnFavoris
            // 
            btnFavoris.Location = new Point(189, 422);
            btnFavoris.Name = "btnFavoris";
            btnFavoris.Size = new Size(194, 29);
            btnFavoris.TabIndex = 6;
            btnFavoris.Text = "Trajets favoris";
            btnFavoris.UseVisualStyleBackColor = true;
            btnFavoris.Click += btnFavoris_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.White;
            btnMenu.Location = new Point(-4, 422);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(197, 29);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // PageCalculItineraire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPlan);
            Controls.Add(btnCalculItinéraire);
            Controls.Add(btnFavoris);
            Controls.Add(btnMenu);
            Name = "PageCalculItineraire";
            Text = "Calcul d'itinéraire";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlan;
        private Button btnCalculItinéraire;
        private Button btnFavoris;
        private Button btnMenu;
    }
}
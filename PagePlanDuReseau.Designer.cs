namespace SAE_S2._01
{
    partial class PagePlanDuReseau
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
            picPlan = new PictureBox();
            lblTitrePlan = new Label();
            cboxChoixLigne = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picPlan).BeginInit();
            SuspendLayout();
            // 
            // btnPlan
            // 
            btnPlan.BackColor = SystemColors.Highlight;
            btnPlan.Location = new Point(596, 421);
            btnPlan.Name = "btnPlan";
            btnPlan.Size = new Size(201, 29);
            btnPlan.TabIndex = 8;
            btnPlan.Text = "Plan du réseau";
            btnPlan.UseVisualStyleBackColor = false;
            // 
            // btnCalculItinéraire
            // 
            btnCalculItinéraire.Location = new Point(379, 421);
            btnCalculItinéraire.Name = "btnCalculItinéraire";
            btnCalculItinéraire.Size = new Size(220, 29);
            btnCalculItinéraire.TabIndex = 7;
            btnCalculItinéraire.Text = "Calcul d'itinéraire";
            btnCalculItinéraire.UseVisualStyleBackColor = true;
            btnCalculItinéraire.Click += btnCalculItinéraire_Click;
            // 
            // btnFavoris
            // 
            btnFavoris.Location = new Point(188, 421);
            btnFavoris.Name = "btnFavoris";
            btnFavoris.Size = new Size(194, 29);
            btnFavoris.TabIndex = 6;
            btnFavoris.Text = "Trajets favoris";
            btnFavoris.UseVisualStyleBackColor = true;
            btnFavoris.Click += btnFavoris_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.Location = new Point(-5, 421);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(197, 29);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // picPlan
            // 
            picPlan.Image = Properties.Resources.plan_general_2024;
            picPlan.Location = new Point(173, 101);
            picPlan.Name = "picPlan";
            picPlan.Size = new Size(461, 294);
            picPlan.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlan.TabIndex = 9;
            picPlan.TabStop = false;
            // 
            // lblTitrePlan
            // 
            lblTitrePlan.AutoSize = true;
            lblTitrePlan.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            lblTitrePlan.ForeColor = SystemColors.HotTrack;
            lblTitrePlan.Location = new Point(160, 9);
            lblTitrePlan.Name = "lblTitrePlan";
            lblTitrePlan.Size = new Size(516, 89);
            lblTitrePlan.TabIndex = 10;
            lblTitrePlan.Text = "Plan du réseau ";
            // 
            // cboxChoixLigne
            // 
            cboxChoixLigne.FormattingEnabled = true;
            cboxChoixLigne.Items.AddRange(new object[] { "Ligne 9", "Ligne 10", "Ligne 11", "Ligne 11 Express", "Ligne 12", "Ligne 13", "Ligne 14", "Ligne 15", "Ligne 16", "Ligne 17", "Ligne 18", "Ligne 19", "Ligne 21", "Plan complet" });
            cboxChoixLigne.Location = new Point(16, 200);
            cboxChoixLigne.Name = "cboxChoixLigne";
            cboxChoixLigne.Size = new Size(151, 28);
            cboxChoixLigne.TabIndex = 11;
            cboxChoixLigne.Text = "Plan complet";
            cboxChoixLigne.SelectedIndexChanged += cboxChoixLigne_SelectedIndexChanged;
            // 
            // PagePlanDuReseau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboxChoixLigne);
            Controls.Add(lblTitrePlan);
            Controls.Add(picPlan);
            Controls.Add(btnPlan);
            Controls.Add(btnCalculItinéraire);
            Controls.Add(btnFavoris);
            Controls.Add(btnMenu);
            Name = "PagePlanDuReseau";
            Text = "Plan du réseau";
            Load += PagePlanDuReseau_Load;
            ((System.ComponentModel.ISupportInitialize)picPlan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlan;
        private Button btnCalculItinéraire;
        private Button btnFavoris;
        private Button btnMenu;
        private PictureBox picPlan;
        private Label lblTitrePlan;
        private ComboBox cboxChoixLigne;
    }
}
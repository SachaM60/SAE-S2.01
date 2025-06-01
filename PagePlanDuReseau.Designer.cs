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
            btnPlan.Location = new Point(745, 526);
            btnPlan.Margin = new Padding(4, 4, 4, 4);
            btnPlan.Name = "btnPlan";
            btnPlan.Size = new Size(251, 36);
            btnPlan.TabIndex = 8;
            btnPlan.Text = "Plan du réseau";
            btnPlan.UseVisualStyleBackColor = false;
            // 
            // btnCalculItinéraire
            // 
            btnCalculItinéraire.Location = new Point(474, 526);
            btnCalculItinéraire.Margin = new Padding(4, 4, 4, 4);
            btnCalculItinéraire.Name = "btnCalculItinéraire";
            btnCalculItinéraire.Size = new Size(275, 36);
            btnCalculItinéraire.TabIndex = 7;
            btnCalculItinéraire.Text = "Calcul d'itinéraire";
            btnCalculItinéraire.UseVisualStyleBackColor = true;
            btnCalculItinéraire.Click += btnCalculItinéraire_Click;
            // 
            // btnFavoris
            // 
            btnFavoris.Location = new Point(235, 526);
            btnFavoris.Margin = new Padding(4, 4, 4, 4);
            btnFavoris.Name = "btnFavoris";
            btnFavoris.Size = new Size(242, 36);
            btnFavoris.TabIndex = 6;
            btnFavoris.Text = "Trajets favoris";
            btnFavoris.UseVisualStyleBackColor = true;
            btnFavoris.Click += btnFavoris_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.Location = new Point(-6, 526);
            btnMenu.Margin = new Padding(4, 4, 4, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(246, 36);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // picPlan
            // 
            picPlan.Image = Properties.Resources.plan_general_2024;
            picPlan.Location = new Point(216, 126);
            picPlan.Margin = new Padding(4, 4, 4, 4);
            picPlan.Name = "picPlan";
            picPlan.Size = new Size(576, 368);
            picPlan.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlan.TabIndex = 9;
            picPlan.TabStop = false;
            // 
            // lblTitrePlan
            // 
            lblTitrePlan.AutoSize = true;
            lblTitrePlan.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            lblTitrePlan.ForeColor = SystemColors.HotTrack;
            lblTitrePlan.Location = new Point(200, 11);
            lblTitrePlan.Margin = new Padding(4, 0, 4, 0);
            lblTitrePlan.Name = "lblTitrePlan";
            lblTitrePlan.Size = new Size(616, 106);
            lblTitrePlan.TabIndex = 10;
            lblTitrePlan.Text = "Plan du réseau ";
            // 
            // cboxChoixLigne
            // 
            cboxChoixLigne.FormattingEnabled = true;
            cboxChoixLigne.Location = new Point(20, 250);
            cboxChoixLigne.Margin = new Padding(4, 4, 4, 4);
            cboxChoixLigne.Name = "cboxChoixLigne";
            cboxChoixLigne.Size = new Size(188, 33);
            cboxChoixLigne.TabIndex = 11;
            cboxChoixLigne.Text = "Plan complet";
            cboxChoixLigne.SelectedIndexChanged += cboxChoixLigne_SelectedIndexChanged;
            // 
            // PagePlanDuReseau
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(cboxChoixLigne);
            Controls.Add(lblTitrePlan);
            Controls.Add(picPlan);
            Controls.Add(btnPlan);
            Controls.Add(btnCalculItinéraire);
            Controls.Add(btnFavoris);
            Controls.Add(btnMenu);
            Margin = new Padding(4, 4, 4, 4);
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
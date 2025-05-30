namespace SAE_S2._01
{
    partial class PageTrajetsFavoris
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
            lblDispo = new Label();
            lblFavs = new Label();
            listDispo = new ListBox();
            listFav = new ListBox();
            SuspendLayout();
            // 
            // btnPlan
            // 
            btnPlan.Location = new Point(750, 526);
            btnPlan.Margin = new Padding(4);
            btnPlan.Name = "btnPlan";
            btnPlan.Size = new Size(251, 36);
            btnPlan.TabIndex = 8;
            btnPlan.Text = "Plan du réseau";
            btnPlan.UseVisualStyleBackColor = true;
            btnPlan.Click += btnPlan_Click;
            // 
            // btnCalculItinéraire
            // 
            btnCalculItinéraire.Location = new Point(479, 526);
            btnCalculItinéraire.Margin = new Padding(4);
            btnCalculItinéraire.Name = "btnCalculItinéraire";
            btnCalculItinéraire.Size = new Size(275, 36);
            btnCalculItinéraire.TabIndex = 7;
            btnCalculItinéraire.Text = "Calcul d'itinéraire";
            btnCalculItinéraire.UseVisualStyleBackColor = true;
            btnCalculItinéraire.Click += btnCalculItinéraire_Click;
            // 
            // btnFavoris
            // 
            btnFavoris.BackColor = SystemColors.Highlight;
            btnFavoris.Location = new Point(240, 526);
            btnFavoris.Margin = new Padding(4);
            btnFavoris.Name = "btnFavoris";
            btnFavoris.Size = new Size(242, 36);
            btnFavoris.TabIndex = 6;
            btnFavoris.Text = "Trajets favoris";
            btnFavoris.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.White;
            btnMenu.Location = new Point(-1, 526);
            btnMenu.Margin = new Padding(4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(246, 36);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // lblDispo
            // 
            lblDispo.AutoSize = true;
            lblDispo.Location = new Point(78, 51);
            lblDispo.Name = "lblDispo";
            lblDispo.Size = new Size(158, 25);
            lblDispo.TabIndex = 9;
            lblDispo.Text = "Lignes disponibles";
            // 
            // lblFavs
            // 
            lblFavs.AutoSize = true;
            lblFavs.Location = new Point(714, 51);
            lblFavs.Name = "lblFavs";
            lblFavs.Size = new Size(135, 25);
            lblFavs.TabIndex = 10;
            lblFavs.Text = "Lignes favorites";
            lblFavs.Click += label2_Click;
            // 
            // listDispo
            // 
            listDispo.FormattingEnabled = true;
            listDispo.ItemHeight = 25;
            listDispo.Location = new Point(78, 97);
            listDispo.Name = "listDispo";
            listDispo.Size = new Size(180, 379);
            listDispo.TabIndex = 11;
            // 
            // listFav
            // 
            listFav.FormattingEnabled = true;
            listFav.ItemHeight = 25;
            listFav.Location = new Point(714, 97);
            listFav.Name = "listFav";
            listFav.Size = new Size(180, 379);
            listFav.TabIndex = 12;
            // 
            // PageTrajetsFavoris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(listFav);
            Controls.Add(listDispo);
            Controls.Add(lblFavs);
            Controls.Add(lblDispo);
            Controls.Add(btnPlan);
            Controls.Add(btnCalculItinéraire);
            Controls.Add(btnFavoris);
            Controls.Add(btnMenu);
            Margin = new Padding(4);
            Name = "PageTrajetsFavoris";
            Text = "Trajets favoris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlan;
        private Button btnCalculItinéraire;
        private Button btnFavoris;
        private Button btnMenu;
        private Label lblDispo;
        private Label lblFavs;
        private ListBox listDispo;
        private ListBox listFav;
    }
}
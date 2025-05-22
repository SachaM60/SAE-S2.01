namespace SAE_S2._01
{
    partial class PageMenuPrincipal
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
            picAccueilMenu = new PictureBox();
            btnMenu = new Button();
            btnFavoris = new Button();
            btnCalculItinéraire = new Button();
            btnPlan = new Button();
            lblHavgo = new Label();
            picMenuPrincipal = new PictureBox();
            picAdmin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picAccueilMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMenuPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAdmin).BeginInit();
            SuspendLayout();
            // 
            // picAccueilMenu
            // 
            picAccueilMenu.Cursor = Cursors.Hand;
            picAccueilMenu.Image = Properties.Resources.house_icon_187945;
            picAccueilMenu.Location = new Point(751, 12);
            picAccueilMenu.Name = "picAccueilMenu";
            picAccueilMenu.Size = new Size(37, 34);
            picAccueilMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            picAccueilMenu.TabIndex = 0;
            picAccueilMenu.TabStop = false;
            picAccueilMenu.Click += picAccueilMenu_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.Highlight;
            btnMenu.Location = new Point(1, 422);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(197, 29);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnFavoris
            // 
            btnFavoris.Location = new Point(194, 422);
            btnFavoris.Name = "btnFavoris";
            btnFavoris.Size = new Size(194, 29);
            btnFavoris.TabIndex = 2;
            btnFavoris.Text = "Trajets favoris";
            btnFavoris.UseVisualStyleBackColor = true;
            btnFavoris.Click += btnFavoris_Click;
            // 
            // btnCalculItinéraire
            // 
            btnCalculItinéraire.Location = new Point(385, 422);
            btnCalculItinéraire.Name = "btnCalculItinéraire";
            btnCalculItinéraire.Size = new Size(220, 29);
            btnCalculItinéraire.TabIndex = 3;
            btnCalculItinéraire.Text = "Calcul d'itinéraire";
            btnCalculItinéraire.UseVisualStyleBackColor = true;
            btnCalculItinéraire.Click += btnCalculItinéraire_Click;
            // 
            // btnPlan
            // 
            btnPlan.Location = new Point(602, 422);
            btnPlan.Name = "btnPlan";
            btnPlan.Size = new Size(201, 29);
            btnPlan.TabIndex = 4;
            btnPlan.Text = "Plan du réseau";
            btnPlan.UseVisualStyleBackColor = true;
            btnPlan.Click += btnPlan_Click;
            // 
            // lblHavgo
            // 
            lblHavgo.AutoSize = true;
            lblHavgo.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHavgo.ForeColor = SystemColors.HotTrack;
            lblHavgo.Location = new Point(264, 12);
            lblHavgo.Name = "lblHavgo";
            lblHavgo.Size = new Size(275, 89);
            lblHavgo.TabIndex = 5;
            lblHavgo.Text = "HAVGO";
            // 
            // picMenuPrincipal
            // 
            picMenuPrincipal.Image = Properties.Resources.image_menu;
            picMenuPrincipal.Location = new Point(118, 104);
            picMenuPrincipal.Name = "picMenuPrincipal";
            picMenuPrincipal.Size = new Size(587, 281);
            picMenuPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;
            picMenuPrincipal.TabIndex = 6;
            picMenuPrincipal.TabStop = false;
            // 
            // picAdmin
            // 
            picAdmin.Cursor = Cursors.Hand;
            picAdmin.Image = Properties.Resources.gear;
            picAdmin.Location = new Point(15, 14);
            picAdmin.Name = "picAdmin";
            picAdmin.Size = new Size(43, 32);
            picAdmin.SizeMode = PictureBoxSizeMode.StretchImage;
            picAdmin.TabIndex = 7;
            picAdmin.TabStop = false;
            picAdmin.Click += picAdmin_Click;
            // 
            // PageMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picAdmin);
            Controls.Add(picMenuPrincipal);
            Controls.Add(lblHavgo);
            Controls.Add(btnPlan);
            Controls.Add(btnCalculItinéraire);
            Controls.Add(btnFavoris);
            Controls.Add(btnMenu);
            Controls.Add(picAccueilMenu);
            Name = "PageMenuPrincipal";
            Text = "Menu principal";
            ((System.ComponentModel.ISupportInitialize)picAccueilMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMenuPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAccueilMenu;
        private Button btnMenu;
        private Button btnFavoris;
        private Button btnCalculItinéraire;
        private Button btnPlan;
        private Label lblHavgo;
        private PictureBox picMenuPrincipal;
        private PictureBox picAdmin;
    }
}
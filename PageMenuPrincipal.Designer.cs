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
            picAccueilMenu.Location = new Point(939, 15);
            picAccueilMenu.Margin = new Padding(4, 4, 4, 4);
            picAccueilMenu.Name = "picAccueilMenu";
            picAccueilMenu.Size = new Size(46, 42);
            picAccueilMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            picAccueilMenu.TabIndex = 0;
            picAccueilMenu.TabStop = false;
            picAccueilMenu.Click += picAccueilMenu_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.Highlight;
            btnMenu.Location = new Point(1, 528);
            btnMenu.Margin = new Padding(4, 4, 4, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(246, 36);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnFavoris
            // 
            btnFavoris.Location = new Point(242, 528);
            btnFavoris.Margin = new Padding(4, 4, 4, 4);
            btnFavoris.Name = "btnFavoris";
            btnFavoris.Size = new Size(242, 36);
            btnFavoris.TabIndex = 2;
            btnFavoris.Text = "Trajets favoris";
            btnFavoris.UseVisualStyleBackColor = true;
            btnFavoris.Click += btnFavoris_Click;
            // 
            // btnCalculItinéraire
            // 
            btnCalculItinéraire.Location = new Point(481, 528);
            btnCalculItinéraire.Margin = new Padding(4, 4, 4, 4);
            btnCalculItinéraire.Name = "btnCalculItinéraire";
            btnCalculItinéraire.Size = new Size(275, 36);
            btnCalculItinéraire.TabIndex = 3;
            btnCalculItinéraire.Text = "Calcul d'itinéraire";
            btnCalculItinéraire.UseVisualStyleBackColor = true;
            btnCalculItinéraire.Click += btnCalculItinéraire_Click;
            // 
            // btnPlan
            // 
            btnPlan.Location = new Point(752, 528);
            btnPlan.Margin = new Padding(4, 4, 4, 4);
            btnPlan.Name = "btnPlan";
            btnPlan.Size = new Size(251, 36);
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
            lblHavgo.Location = new Point(348, 9);
            lblHavgo.Margin = new Padding(4, 0, 4, 0);
            lblHavgo.Name = "lblHavgo";
            lblHavgo.Size = new Size(331, 108);
            lblHavgo.TabIndex = 5;
            lblHavgo.Text = "HAVGO";
            // 
            // picMenuPrincipal
            // 
            picMenuPrincipal.Image = Properties.Resources.image_menu;
            picMenuPrincipal.Location = new Point(87, 105);
            picMenuPrincipal.Margin = new Padding(4, 4, 4, 4);
            picMenuPrincipal.Name = "picMenuPrincipal";
            picMenuPrincipal.Size = new Size(851, 415);
            picMenuPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;
            picMenuPrincipal.TabIndex = 6;
            picMenuPrincipal.TabStop = false;
            // 
            // picAdmin
            // 
            picAdmin.Cursor = Cursors.Hand;
            picAdmin.Image = Properties.Resources.gear;
            picAdmin.Location = new Point(19, 18);
            picAdmin.Margin = new Padding(4, 4, 4, 4);
            picAdmin.Name = "picAdmin";
            picAdmin.Size = new Size(54, 40);
            picAdmin.SizeMode = PictureBoxSizeMode.StretchImage;
            picAdmin.TabIndex = 7;
            picAdmin.TabStop = false;
            picAdmin.Click += picAdmin_Click;
            // 
            // PageMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(picAdmin);
            Controls.Add(picMenuPrincipal);
            Controls.Add(lblHavgo);
            Controls.Add(btnPlan);
            Controls.Add(btnCalculItinéraire);
            Controls.Add(btnFavoris);
            Controls.Add(btnMenu);
            Controls.Add(picAccueilMenu);
            Margin = new Padding(4, 4, 4, 4);
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
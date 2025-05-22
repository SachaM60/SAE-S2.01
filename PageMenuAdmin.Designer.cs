namespace SAE_S2._01
{
    partial class PageMenuAdmin
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
            picMenu = new PictureBox();
            lblMenuAdmin = new Label();
            btnAccesBD = new Button();
            btnAccesAppli = new Button();
            ((System.ComponentModel.ISupportInitialize)picMenu).BeginInit();
            SuspendLayout();
            // 
            // picMenu
            // 
            picMenu.Cursor = Cursors.Hand;
            picMenu.Image = Properties.Resources.house_icon_187945;
            picMenu.Location = new Point(738, 12);
            picMenu.Name = "picMenu";
            picMenu.Size = new Size(50, 43);
            picMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            picMenu.TabIndex = 0;
            picMenu.TabStop = false;
            picMenu.Click += picMenu_Click;
            // 
            // lblMenuAdmin
            // 
            lblMenuAdmin.AutoSize = true;
            lblMenuAdmin.Location = new Point(221, 35);
            lblMenuAdmin.Name = "lblMenuAdmin";
            lblMenuAdmin.Size = new Size(384, 20);
            lblMenuAdmin.TabIndex = 1;
            lblMenuAdmin.Text = "Vous êtes maintenant connecté en tant qu'administrateur";
            // 
            // btnAccesBD
            // 
            btnAccesBD.Location = new Point(281, 258);
            btnAccesBD.Name = "btnAccesBD";
            btnAccesBD.Size = new Size(252, 29);
            btnAccesBD.TabIndex = 2;
            btnAccesBD.Text = "Accéder à la base de données";
            btnAccesBD.UseVisualStyleBackColor = true;
            btnAccesBD.Click += btnAccesBD_Click;
            // 
            // btnAccesAppli
            // 
            btnAccesAppli.Location = new Point(282, 317);
            btnAccesAppli.Name = "btnAccesAppli";
            btnAccesAppli.Size = new Size(251, 29);
            btnAccesAppli.TabIndex = 3;
            btnAccesAppli.Text = "Accéder à l'application";
            btnAccesAppli.UseVisualStyleBackColor = true;
            btnAccesAppli.Click += btnAccesAppli_Click;
            // 
            // PageMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAccesAppli);
            Controls.Add(btnAccesBD);
            Controls.Add(lblMenuAdmin);
            Controls.Add(picMenu);
            Name = "PageMenuAdmin";
            Text = "Menu principal administration";
            ((System.ComponentModel.ISupportInitialize)picMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picMenu;
        private Label lblMenuAdmin;
        private Button btnAccesBD;
        private Button btnAccesAppli;
    }
}
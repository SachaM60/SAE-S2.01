namespace SAE_S2._01
{
    partial class PageAccueil
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
            lblAccueil = new Label();
            label1 = new Label();
            btnSeConnecterAccueil = new Button();
            btnAccederAppli = new Button();
            SuspendLayout();
            // 
            // lblAccueil
            // 
            lblAccueil.AutoSize = true;
            lblAccueil.Location = new Point(200, 47);
            lblAccueil.Name = "lblAccueil";
            lblAccueil.Size = new Size(398, 20);
            lblAccueil.TabIndex = 0;
            lblAccueil.Text = "Bienvenue sur HavGo, votre application réseau tout en un.  ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 109);
            label1.Name = "label1";
            label1.Size = new Size(254, 20);
            label1.TabIndex = 1;
            label1.Text = "Quelle action voulez-vous effectuer ?";
            // 
            // btnSeConnecterAccueil
            // 
            btnSeConnecterAccueil.Location = new Point(78, 258);
            btnSeConnecterAccueil.Name = "btnSeConnecterAccueil";
            btnSeConnecterAccueil.Size = new Size(276, 59);
            btnSeConnecterAccueil.TabIndex = 2;
            btnSeConnecterAccueil.Text = "Se connecter à un compte ";
            btnSeConnecterAccueil.UseVisualStyleBackColor = true;
            btnSeConnecterAccueil.Click += btnSeConnecterAccueil_Click;
            // 
            // btnAccederAppli
            // 
            btnAccederAppli.Location = new Point(433, 258);
            btnAccederAppli.Name = "btnAccederAppli";
            btnAccederAppli.Size = new Size(276, 59);
            btnAccederAppli.TabIndex = 3;
            btnAccederAppli.Text = "Accéder à l'application";
            btnAccederAppli.UseVisualStyleBackColor = true;
            btnAccederAppli.Click += btnAccederAppli_Click;
            // 
            // PageAccueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAccederAppli);
            Controls.Add(btnSeConnecterAccueil);
            Controls.Add(label1);
            Controls.Add(lblAccueil);
            Name = "PageAccueil";
            Text = "Accueil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccueil;
        private Label label1;
        private Button btnSeConnecterAccueil;
        private Button btnAccederAppli;
    }
}
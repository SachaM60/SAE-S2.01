namespace SAE_S2._01
{
    partial class PageSuppressionLigne
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
            lstBoxLigne = new ListBox();
            btnRetour = new Button();
            btnSupprimer = new Button();
            lbInfo = new Label();
            lbId = new Label();
            lbNom = new Label();
            lbDepart = new Label();
            lbTerminus = new Label();
            SuspendLayout();
            // 
            // lstBoxLigne
            // 
            lstBoxLigne.FormattingEnabled = true;
            lstBoxLigne.ItemHeight = 25;
            lstBoxLigne.Location = new Point(12, 12);
            lstBoxLigne.Name = "lstBoxLigne";
            lstBoxLigne.Size = new Size(180, 429);
            lstBoxLigne.TabIndex = 0;
            lstBoxLigne.SelectedIndexChanged += lstBoxLigne_SelectedIndexChanged;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(229, 403);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(245, 34);
            btnRetour.TabIndex = 1;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(519, 403);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(245, 34);
            btnSupprimer.TabIndex = 2;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Location = new Point(229, 81);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(201, 25);
            lbInfo.TabIndex = 3;
            lbInfo.Text = "Information de la ligne :";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(419, 136);
            lbId.Name = "lbId";
            lbId.Size = new Size(41, 25);
            lbId.TabIndex = 4;
            lbId.Text = "id : ";
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Location = new Point(419, 190);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(66, 25);
            lbNom.TabIndex = 5;
            lbNom.Text = "Nom : ";
            // 
            // lbDepart
            // 
            lbDepart.AutoSize = true;
            lbDepart.Location = new Point(419, 245);
            lbDepart.Name = "lbDepart";
            lbDepart.Size = new Size(80, 25);
            lbDepart.TabIndex = 6;
            lbDepart.Text = "Départ : ";
            // 
            // lbTerminus
            // 
            lbTerminus.AutoSize = true;
            lbTerminus.Location = new Point(419, 297);
            lbTerminus.Name = "lbTerminus";
            lbTerminus.Size = new Size(96, 25);
            lbTerminus.TabIndex = 7;
            lbTerminus.Text = "Terminus : ";
            // 
            // PageSuppressionLigne
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTerminus);
            Controls.Add(lbDepart);
            Controls.Add(lbNom);
            Controls.Add(lbId);
            Controls.Add(lbInfo);
            Controls.Add(btnSupprimer);
            Controls.Add(btnRetour);
            Controls.Add(lstBoxLigne);
            Name = "PageSuppressionLigne";
            Text = "PageSuppressionLigne";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstBoxLigne;
        private Button btnRetour;
        private Button btnSupprimer;
        private Label lbInfo;
        private Label lbId;
        private Label lbNom;
        private Label lbDepart;
        private Label lbTerminus;
    }
}
namespace SAE_S2._01
{
    partial class PageModificationLigne
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
            lbNomLigne = new Label();
            LbArret = new Label();
            NumUpADownNbArret = new NumericUpDown();
            flpArrets = new FlowLayoutPanel();
            BtnRetour = new Button();
            BtnValider = new Button();
            label1 = new Label();
            txtBoxNom = new TextBox();
            lstBoxLigne = new ListBox();
            ((System.ComponentModel.ISupportInitialize)NumUpADownNbArret).BeginInit();
            SuspendLayout();
            // 
            // lbNomLigne
            // 
            lbNomLigne.AutoSize = true;
            lbNomLigne.Location = new Point(432, 116);
            lbNomLigne.Margin = new Padding(4, 0, 4, 0);
            lbNomLigne.Name = "lbNomLigne";
            lbNomLigne.Size = new Size(147, 25);
            lbNomLigne.TabIndex = 0;
            lbNomLigne.Text = "Nom de la ligne :";
            // 
            // LbArret
            // 
            LbArret.AutoSize = true;
            LbArret.Location = new Point(347, 174);
            LbArret.Margin = new Padding(4, 0, 4, 0);
            LbArret.Name = "LbArret";
            LbArret.Size = new Size(241, 25);
            LbArret.TabIndex = 2;
            LbArret.Text = "Arrêts présent dans la ligne : ";
            // 
            // NumUpADownNbArret
            // 
            NumUpADownNbArret.Location = new Point(595, 174);
            NumUpADownNbArret.Margin = new Padding(4);
            NumUpADownNbArret.Name = "NumUpADownNbArret";
            NumUpADownNbArret.Size = new Size(217, 31);
            NumUpADownNbArret.TabIndex = 3;
            NumUpADownNbArret.ValueChanged += NumUpADownNbArret_ValueChanged;
            // 
            // flpArrets
            // 
            flpArrets.Location = new Point(260, 232);
            flpArrets.Margin = new Padding(4);
            flpArrets.Name = "flpArrets";
            flpArrets.Size = new Size(663, 188);
            flpArrets.TabIndex = 4;
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(260, 500);
            BtnRetour.Margin = new Padding(4);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(283, 36);
            BtnRetour.TabIndex = 6;
            BtnRetour.Text = "Retour";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // BtnValider
            // 
            BtnValider.Location = new Point(640, 500);
            BtnValider.Margin = new Padding(4);
            BtnValider.Name = "BtnValider";
            BtnValider.Size = new Size(283, 36);
            BtnValider.TabIndex = 7;
            BtnValider.Text = "Valider";
            BtnValider.UseVisualStyleBackColor = true;
            BtnValider.Click += BtnValider_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(772, 113);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 8;
            // 
            // txtBoxNom
            // 
            txtBoxNom.Location = new Point(595, 110);
            txtBoxNom.Name = "txtBoxNom";
            txtBoxNom.Size = new Size(217, 31);
            txtBoxNom.TabIndex = 9;
            // 
            // lstBoxLigne
            // 
            lstBoxLigne.FormattingEnabled = true;
            lstBoxLigne.ItemHeight = 25;
            lstBoxLigne.Location = new Point(16, 16);
            lstBoxLigne.Name = "lstBoxLigne";
            lstBoxLigne.Size = new Size(180, 529);
            lstBoxLigne.TabIndex = 10;
            lstBoxLigne.SelectedIndexChanged += lstBoxLigne_SelectedIndexChanged;
            // 
            // PageModificationLigne
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(lstBoxLigne);
            Controls.Add(txtBoxNom);
            Controls.Add(label1);
            Controls.Add(BtnValider);
            Controls.Add(BtnRetour);
            Controls.Add(flpArrets);
            Controls.Add(NumUpADownNbArret);
            Controls.Add(LbArret);
            Controls.Add(lbNomLigne);
            Margin = new Padding(4);
            Name = "PageModificationLigne";
            Text = "PageModificationLigne";
            ((System.ComponentModel.ISupportInitialize)NumUpADownNbArret).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNomLigne;
        private Label LbArret;
        private NumericUpDown NumUpADownNbArret;
        private FlowLayoutPanel flpArrets;
        private Button BtnRetour;
        private Button BtnValider;
        private Label label1;
        private TextBox txtBoxNom;
        private ListBox lstBoxLigne;
    }
}
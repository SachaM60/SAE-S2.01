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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            labelAffTempsTra = new Label();
            lblChemin = new Label();
            SuspendLayout();
            // 
            // btnPlan
            // 
            btnPlan.Location = new Point(522, 317);
            btnPlan.Margin = new Padding(3, 2, 3, 2);
            btnPlan.Name = "btnPlan";
            btnPlan.Size = new Size(176, 22);
            btnPlan.TabIndex = 8;
            btnPlan.Text = "Plan du réseau";
            btnPlan.UseVisualStyleBackColor = true;
            btnPlan.Click += btnPlan_Click;
            // 
            // btnCalculItinéraire
            // 
            btnCalculItinéraire.BackColor = SystemColors.Highlight;
            btnCalculItinéraire.Location = new Point(332, 317);
            btnCalculItinéraire.Margin = new Padding(3, 2, 3, 2);
            btnCalculItinéraire.Name = "btnCalculItinéraire";
            btnCalculItinéraire.Size = new Size(192, 22);
            btnCalculItinéraire.TabIndex = 7;
            btnCalculItinéraire.Text = "Calcul d'itinéraire";
            btnCalculItinéraire.UseVisualStyleBackColor = false;
            // 
            // btnFavoris
            // 
            btnFavoris.Location = new Point(165, 317);
            btnFavoris.Margin = new Padding(3, 2, 3, 2);
            btnFavoris.Name = "btnFavoris";
            btnFavoris.Size = new Size(169, 22);
            btnFavoris.TabIndex = 6;
            btnFavoris.Text = "Trajets favoris";
            btnFavoris.UseVisualStyleBackColor = true;
            btnFavoris.Click += btnFavoris_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.White;
            btnMenu.Location = new Point(-4, 317);
            btnMenu.Margin = new Padding(3, 2, 3, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(172, 22);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 63);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 9;
            label1.Text = "Entrez votre arret de départ : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 110);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 10;
            label2.Text = "Entrez votre arret de fin : ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 193);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 11;
            label3.Text = "Votre trajet durera environ : ";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(287, 157);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(83, 22);
            button1.TabIndex = 13;
            button1.Text = "Valider";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 218);
            label4.Name = "label4";
            label4.Size = new Size(178, 15);
            label4.TabIndex = 14;
            label4.Text = "Il vous fera passer par les arrêts : ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(267, 61);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(267, 110);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 16;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // labelAffTempsTra
            // 
            labelAffTempsTra.AutoSize = true;
            labelAffTempsTra.Location = new Point(255, 193);
            labelAffTempsTra.Name = "labelAffTempsTra";
            labelAffTempsTra.Size = new Size(97, 15);
            labelAffTempsTra.TabIndex = 17;
            labelAffTempsTra.Text = "\"Temps de trajet\"";
            // 
            // lblChemin
            // 
            lblChemin.AutoSize = true;
            lblChemin.Location = new Point(257, 220);
            lblChemin.Name = "lblChemin";
            lblChemin.Size = new Size(49, 15);
            lblChemin.TabIndex = 18;
            lblChemin.Text = "Chemin";
            // 
            // PageCalculItineraire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 337);
            Controls.Add(lblChemin);
            Controls.Add(labelAffTempsTra);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPlan);
            Controls.Add(btnCalculItinéraire);
            Controls.Add(btnFavoris);
            Controls.Add(btnMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PageCalculItineraire";
            Text = "Calcul d'itinéraire";
            Load += PageCalculItineraire_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlan;
        private Button btnCalculItinéraire;
        private Button btnFavoris;
        private Button btnMenu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label labelAffTempsTra;
        private Label lblChemin;
    }
}
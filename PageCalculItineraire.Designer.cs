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
            btnPlan.Location = new Point(746, 528);
            btnPlan.Margin = new Padding(4, 3, 4, 3);
            btnPlan.Name = "btnPlan";
            btnPlan.Size = new Size(251, 37);
            btnPlan.TabIndex = 8;
            btnPlan.Text = "Plan du réseau";
            btnPlan.UseVisualStyleBackColor = true;
            btnPlan.Click += btnPlan_Click;
            // 
            // btnCalculItinéraire
            // 
            btnCalculItinéraire.BackColor = SystemColors.Highlight;
            btnCalculItinéraire.Location = new Point(474, 528);
            btnCalculItinéraire.Margin = new Padding(4, 3, 4, 3);
            btnCalculItinéraire.Name = "btnCalculItinéraire";
            btnCalculItinéraire.Size = new Size(274, 37);
            btnCalculItinéraire.TabIndex = 7;
            btnCalculItinéraire.Text = "Calcul d'itinéraire";
            btnCalculItinéraire.UseVisualStyleBackColor = false;
            // 
            // btnFavoris
            // 
            btnFavoris.Location = new Point(236, 528);
            btnFavoris.Margin = new Padding(4, 3, 4, 3);
            btnFavoris.Name = "btnFavoris";
            btnFavoris.Size = new Size(241, 37);
            btnFavoris.TabIndex = 6;
            btnFavoris.Text = "Trajets favoris";
            btnFavoris.UseVisualStyleBackColor = true;
            btnFavoris.Click += btnFavoris_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.White;
            btnMenu.Location = new Point(-6, 528);
            btnMenu.Margin = new Padding(4, 3, 4, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(246, 37);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 25);
            label1.TabIndex = 9;
            label1.Text = "Entrez votre arret de départ : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(211, 25);
            label2.TabIndex = 10;
            label2.Text = "Entrez votre arret de fin : ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 229);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(233, 25);
            label3.TabIndex = 11;
            label3.Text = "Votre trajet durera environ : ";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(421, 153);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(119, 37);
            button1.TabIndex = 13;
            button1.Text = "Valider";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 292);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(275, 25);
            label4.TabIndex = 14;
            label4.Text = "Il vous fera passer par les arrêts : ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(381, 38);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 33);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(381, 83);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(188, 33);
            comboBox2.TabIndex = 16;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // labelAffTempsTra
            // 
            labelAffTempsTra.AutoSize = true;
            labelAffTempsTra.Location = new Point(346, 229);
            labelAffTempsTra.Margin = new Padding(4, 0, 4, 0);
            labelAffTempsTra.Name = "labelAffTempsTra";
            labelAffTempsTra.Size = new Size(147, 25);
            labelAffTempsTra.TabIndex = 17;
            labelAffTempsTra.Text = "\"Temps de trajet\"";
            // 
            // lblChemin
            // 
            lblChemin.AutoSize = true;
            lblChemin.Location = new Point(346, 292);
            lblChemin.Margin = new Padding(4, 0, 4, 0);
            lblChemin.Name = "lblChemin";
            lblChemin.Size = new Size(72, 25);
            lblChemin.TabIndex = 18;
            lblChemin.Text = "Chemin";
            // 
            // PageCalculItineraire
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
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
            Margin = new Padding(4, 3, 4, 3);
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
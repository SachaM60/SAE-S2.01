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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            labelAffTempsTra = new Label();
            SuspendLayout();
            // 
            // btnPlan
            // 
            btnPlan.Location = new Point(597, 422);
            btnPlan.Name = "btnPlan";
            btnPlan.Size = new Size(201, 29);
            btnPlan.TabIndex = 8;
            btnPlan.Text = "Plan du réseau";
            btnPlan.UseVisualStyleBackColor = true;
            btnPlan.Click += btnPlan_Click;
            // 
            // btnCalculItinéraire
            // 
            btnCalculItinéraire.BackColor = SystemColors.Highlight;
            btnCalculItinéraire.Location = new Point(380, 422);
            btnCalculItinéraire.Name = "btnCalculItinéraire";
            btnCalculItinéraire.Size = new Size(220, 29);
            btnCalculItinéraire.TabIndex = 7;
            btnCalculItinéraire.Text = "Calcul d'itinéraire";
            btnCalculItinéraire.UseVisualStyleBackColor = false;
            // 
            // btnFavoris
            // 
            btnFavoris.Location = new Point(189, 422);
            btnFavoris.Name = "btnFavoris";
            btnFavoris.Size = new Size(194, 29);
            btnFavoris.TabIndex = 6;
            btnFavoris.Text = "Trajets favoris";
            btnFavoris.UseVisualStyleBackColor = true;
            btnFavoris.Click += btnFavoris_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.White;
            btnMenu.Location = new Point(-4, 422);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(197, 29);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 84);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 9;
            label1.Text = "Entrez votre arret de départ : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 147);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 10;
            label2.Text = "Entrez votre arret de fin : ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 257);
            label3.Name = "label3";
            label3.Size = new Size(194, 20);
            label3.TabIndex = 11;
            label3.Text = "Votre trajet durera environ : ";
            label3.Click += label3_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(291, 291);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(287, 116);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(328, 209);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Valider";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 291);
            label4.Name = "label4";
            label4.Size = new Size(227, 20);
            label4.TabIndex = 14;
            label4.Text = "Il vous fera passer par les arrêts : ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(305, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(305, 147);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 16;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // labelAffTempsTra
            // 
            labelAffTempsTra.AutoSize = true;
            labelAffTempsTra.Location = new Point(291, 257);
            labelAffTempsTra.Name = "labelAffTempsTra";
            labelAffTempsTra.Size = new Size(124, 20);
            labelAffTempsTra.TabIndex = 17;
            labelAffTempsTra.Text = "\"Temps de trajet\"";
            // 
            // PageCalculItineraire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelAffTempsTra);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPlan);
            Controls.Add(btnCalculItinéraire);
            Controls.Add(btnFavoris);
            Controls.Add(btnMenu);
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
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label labelAffTempsTra;
    }
}
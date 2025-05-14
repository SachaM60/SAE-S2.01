namespace SAE_S2._01
{
    partial class PageValidationConnexion
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
            lblValidation = new Label();
            btnAccèsAppli = new Button();
            SuspendLayout();
            // 
            // lblValidation
            // 
            lblValidation.AutoSize = true;
            lblValidation.Location = new Point(293, 110);
            lblValidation.Name = "lblValidation";
            lblValidation.Size = new Size(240, 20);
            lblValidation.TabIndex = 0;
            lblValidation.Text = "Vous êtes connecté à votre compte";
            // 
            // btnAccèsAppli
            // 
            btnAccèsAppli.Location = new Point(320, 258);
            btnAccèsAppli.Name = "btnAccèsAppli";
            btnAccèsAppli.Size = new Size(196, 29);
            btnAccèsAppli.TabIndex = 1;
            btnAccèsAppli.Text = "Accéder à l'application";
            btnAccèsAppli.UseVisualStyleBackColor = true;
            btnAccèsAppli.Click += btnAccèsAppli_Click;
            // 
            // PageValidationConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAccèsAppli);
            Controls.Add(lblValidation);
            Name = "PageValidationConnexion";
            Text = "Validation de connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValidation;
        private Button btnAccèsAppli;
    }
}
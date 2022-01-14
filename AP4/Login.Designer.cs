namespace AP4
{
    partial class Login
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
            this.lbConnexion = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbMotDePasse = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConnexion
            // 
            this.lbConnexion.AutoSize = true;
            this.lbConnexion.Font = new System.Drawing.Font("Liberation Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnexion.Location = new System.Drawing.Point(254, 39);
            this.lbConnexion.Name = "lbConnexion";
            this.lbConnexion.Size = new System.Drawing.Size(324, 71);
            this.lbConnexion.TabIndex = 0;
            this.lbConnexion.Text = "Connexion";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Liberation Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(81, 152);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(188, 32);
            this.lbMail.TabIndex = 1;
            this.lbMail.Text = "Adresse mail :";
            // 
            // lbMotDePasse
            // 
            this.lbMotDePasse.AutoSize = true;
            this.lbMotDePasse.Font = new System.Drawing.Font("Liberation Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotDePasse.Location = new System.Drawing.Point(81, 274);
            this.lbMotDePasse.Name = "lbMotDePasse";
            this.lbMotDePasse.Size = new System.Drawing.Size(192, 32);
            this.lbMotDePasse.TabIndex = 2;
            this.lbMotDePasse.Text = "Mot de passe :";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(288, 164);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(335, 20);
            this.tbMail.TabIndex = 3;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(288, 286);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.PasswordChar = '*';
            this.tbMdp.Size = new System.Drawing.Size(335, 20);
            this.tbMdp.TabIndex = 4;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Font = new System.Drawing.Font("Liberation Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(266, 363);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(176, 45);
            this.btnConnexion.TabIndex = 5;
            this.btnConnexion.Text = "SE CONNECTER";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Liberation Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(447, 363);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(176, 45);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "QUITTER";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.lbMotDePasse);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbConnexion);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConnexion;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbMotDePasse;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnQuitter;
    }
}
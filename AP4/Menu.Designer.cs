namespace AP4
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnGestionInscrits = new System.Windows.Forms.Button();
            this.btnGestionServices = new System.Windows.Forms.Button();
            this.btnGestionReponses = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.btnGestionMessages = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGestionInscrits
            // 
            this.btnGestionInscrits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionInscrits.Location = new System.Drawing.Point(177, 311);
            this.btnGestionInscrits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionInscrits.Name = "btnGestionInscrits";
            this.btnGestionInscrits.Size = new System.Drawing.Size(269, 95);
            this.btnGestionInscrits.TabIndex = 0;
            this.btnGestionInscrits.Text = "GESTION DES INSCRITS";
            this.btnGestionInscrits.UseVisualStyleBackColor = true;
            this.btnGestionInscrits.Click += new System.EventHandler(this.BtnGestionInscrits_Click);
            // 
            // btnGestionServices
            // 
            this.btnGestionServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionServices.Location = new System.Drawing.Point(177, 176);
            this.btnGestionServices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionServices.Name = "btnGestionServices";
            this.btnGestionServices.Size = new System.Drawing.Size(269, 95);
            this.btnGestionServices.TabIndex = 1;
            this.btnGestionServices.Text = "GESTION DES SERVICES";
            this.btnGestionServices.UseVisualStyleBackColor = true;
            this.btnGestionServices.Click += new System.EventHandler(this.btnGestionServices_Click);
            // 
            // btnGestionReponses
            // 
            this.btnGestionReponses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionReponses.Location = new System.Drawing.Point(663, 176);
            this.btnGestionReponses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionReponses.Name = "btnGestionReponses";
            this.btnGestionReponses.Size = new System.Drawing.Size(269, 95);
            this.btnGestionReponses.TabIndex = 2;
            this.btnGestionReponses.Text = "GESTION DES RÉPONSES AUX SERVICES";
            this.btnGestionReponses.UseVisualStyleBackColor = true;
            this.btnGestionReponses.Click += new System.EventHandler(this.btnGestionReponses_Click);
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.Location = new System.Drawing.Point(472, 74);
            this.lbMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(165, 54);
            this.lbMenu.TabIndex = 3;
            this.lbMenu.Text = "MENU";
            // 
            // btnGestionMessages
            // 
            this.btnGestionMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionMessages.Location = new System.Drawing.Point(663, 311);
            this.btnGestionMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionMessages.Name = "btnGestionMessages";
            this.btnGestionMessages.Size = new System.Drawing.Size(269, 95);
            this.btnGestionMessages.TabIndex = 4;
            this.btnGestionMessages.Text = "GESTION DES MESSAGES D\'AIDE";
            this.btnGestionMessages.UseVisualStyleBackColor = true;
            this.btnGestionMessages.Click += new System.EventHandler(this.btnGestionMessages_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(784, 457);
            this.btnDeconnexion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(235, 59);
            this.btnDeconnexion.TabIndex = 5;
            this.btnDeconnexion.Text = "DÉCONNEXION";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.BtnDeconnexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(763, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(763, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom :";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenom.Location = new System.Drawing.Point(881, 38);
            this.lbPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(118, 29);
            this.lbPrenom.TabIndex = 8;
            this.lbPrenom.Text = "lePrenom";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(847, 94);
            this.lbNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(85, 29);
            this.lbNom.TabIndex = 9;
            this.lbNom.Text = "leNom";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnGestionMessages);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.btnGestionReponses);
            this.Controls.Add(this.btnGestionServices);
            this.Controls.Add(this.btnGestionInscrits);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGestionInscrits;
        private System.Windows.Forms.Button btnGestionServices;
        private System.Windows.Forms.Button btnGestionReponses;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Button btnGestionMessages;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


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
            this.BtnGestionInscrits = new System.Windows.Forms.Button();
            this.BtnGestionServices = new System.Windows.Forms.Button();
            this.BtnGestionReponses = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.BtnGestionMessages = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGestionInscrits
            // 
            this.BtnGestionInscrits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionInscrits.Location = new System.Drawing.Point(133, 253);
            this.BtnGestionInscrits.Name = "BtnGestionInscrits";
            this.BtnGestionInscrits.Size = new System.Drawing.Size(202, 77);
            this.BtnGestionInscrits.TabIndex = 0;
            this.BtnGestionInscrits.Text = "GESTION DES INSCRITS";
            this.BtnGestionInscrits.UseVisualStyleBackColor = true;
            this.BtnGestionInscrits.Click += new System.EventHandler(this.BtnGestionInscrits_Click);
            // 
            // BtnGestionServices
            // 
            this.BtnGestionServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionServices.Location = new System.Drawing.Point(133, 143);
            this.BtnGestionServices.Name = "BtnGestionServices";
            this.BtnGestionServices.Size = new System.Drawing.Size(202, 77);
            this.BtnGestionServices.TabIndex = 1;
            this.BtnGestionServices.Text = "GESTION DES SERVICES";
            this.BtnGestionServices.UseVisualStyleBackColor = true;
            this.BtnGestionServices.Click += new System.EventHandler(this.BtnGestionServices_Click);
            // 
            // BtnGestionReponses
            // 
            this.BtnGestionReponses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionReponses.Location = new System.Drawing.Point(497, 143);
            this.BtnGestionReponses.Name = "BtnGestionReponses";
            this.BtnGestionReponses.Size = new System.Drawing.Size(202, 77);
            this.BtnGestionReponses.TabIndex = 2;
            this.BtnGestionReponses.Text = "GESTION DES RÉPONSES AUX SERVICES";
            this.BtnGestionReponses.UseVisualStyleBackColor = true;
            this.BtnGestionReponses.Click += new System.EventHandler(this.BtnGestionReponses_Click);
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.Location = new System.Drawing.Point(354, 60);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(132, 42);
            this.lbMenu.TabIndex = 3;
            this.lbMenu.Text = "MENU";
            // 
            // BtnGestionMessages
            // 
            this.BtnGestionMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionMessages.Location = new System.Drawing.Point(497, 253);
            this.BtnGestionMessages.Name = "BtnGestionMessages";
            this.BtnGestionMessages.Size = new System.Drawing.Size(202, 77);
            this.BtnGestionMessages.TabIndex = 4;
            this.BtnGestionMessages.Text = "GESTION DES MESSAGES D\'AIDE";
            this.BtnGestionMessages.UseVisualStyleBackColor = true;
            this.BtnGestionMessages.Click += new System.EventHandler(this.BtnGestionMessages_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(588, 371);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(176, 48);
            this.btnDeconnexion.TabIndex = 5;
            this.btnDeconnexion.Text = "DÉCONNEXION";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.BtnDeconnexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(572, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom :";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenom.Location = new System.Drawing.Point(661, 31);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(92, 24);
            this.lbPrenom.TabIndex = 8;
            this.lbPrenom.Text = "lePrenom";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(635, 76);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(66, 24);
            this.lbNom.TabIndex = 9;
            this.lbNom.Text = "leNom";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.BtnGestionMessages);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.BtnGestionReponses);
            this.Controls.Add(this.BtnGestionServices);
            this.Controls.Add(this.BtnGestionInscrits);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGestionInscrits;
        private System.Windows.Forms.Button BtnGestionServices;
        private System.Windows.Forms.Button BtnGestionReponses;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Button BtnGestionMessages;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


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
            this.btnGestionInscrits = new System.Windows.Forms.Button();
            this.btnGestionServices = new System.Windows.Forms.Button();
            this.btnGestionReponses = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.btnGestionMessages = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionInscrits
            // 
            this.btnGestionInscrits.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionInscrits.Location = new System.Drawing.Point(133, 253);
            this.btnGestionInscrits.Name = "btnGestionInscrits";
            this.btnGestionInscrits.Size = new System.Drawing.Size(202, 77);
            this.btnGestionInscrits.TabIndex = 0;
            this.btnGestionInscrits.Text = "GESTION DES INSCRITS";
            this.btnGestionInscrits.UseVisualStyleBackColor = true;
            this.btnGestionInscrits.Click += new System.EventHandler(this.BtnGestionInscrits_Click);
            // 
            // btnGestionServices
            // 
            this.btnGestionServices.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionServices.Location = new System.Drawing.Point(133, 143);
            this.btnGestionServices.Name = "btnGestionServices";
            this.btnGestionServices.Size = new System.Drawing.Size(202, 77);
            this.btnGestionServices.TabIndex = 1;
            this.btnGestionServices.Text = "GESTION DES SERVICES";
            this.btnGestionServices.UseVisualStyleBackColor = true;
            this.btnGestionServices.Click += new System.EventHandler(this.btnGestionServices_Click);
            // 
            // btnGestionReponses
            // 
            this.btnGestionReponses.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionReponses.Location = new System.Drawing.Point(497, 143);
            this.btnGestionReponses.Name = "btnGestionReponses";
            this.btnGestionReponses.Size = new System.Drawing.Size(202, 77);
            this.btnGestionReponses.TabIndex = 2;
            this.btnGestionReponses.Text = "GESTION DES RÉPONSES AUX SERVICES";
            this.btnGestionReponses.UseVisualStyleBackColor = true;
            this.btnGestionReponses.Click += new System.EventHandler(this.btnGestionReponses_Click);
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Liberation Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.Location = new System.Drawing.Point(354, 60);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(133, 41);
            this.lbMenu.TabIndex = 3;
            this.lbMenu.Text = "MENU";
            // 
            // btnGestionMessages
            // 
            this.btnGestionMessages.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionMessages.Location = new System.Drawing.Point(497, 253);
            this.btnGestionMessages.Name = "btnGestionMessages";
            this.btnGestionMessages.Size = new System.Drawing.Size(202, 77);
            this.btnGestionMessages.TabIndex = 4;
            this.btnGestionMessages.Text = "GESTION DES MESSAGES D\'AIDE";
            this.btnGestionMessages.UseVisualStyleBackColor = true;
            this.btnGestionMessages.Click += new System.EventHandler(this.btnGestionMessages_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(30, 31);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(179, 48);
            this.btnDeconnexion.TabIndex = 5;
            this.btnDeconnexion.Text = "DÉCONNEXION";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.BtnDeconnexion_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnGestionMessages);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.btnGestionReponses);
            this.Controls.Add(this.btnGestionServices);
            this.Controls.Add(this.btnGestionInscrits);
            this.Name = "Menu";
            this.Text = "Form1";
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
    }
}


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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGestionMessages = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionInscrits
            // 
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
            this.btnGestionReponses.Location = new System.Drawing.Point(497, 143);
            this.btnGestionReponses.Name = "btnGestionReponses";
            this.btnGestionReponses.Size = new System.Drawing.Size(202, 77);
            this.btnGestionReponses.TabIndex = 2;
            this.btnGestionReponses.Text = "GESTION DES RÉPONSES AUX SERVICES";
            this.btnGestionReponses.UseVisualStyleBackColor = true;
            this.btnGestionReponses.Click += new System.EventHandler(this.btnGestionReponses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU";
            // 
            // btnGestionMessages
            // 
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
            this.btnDeconnexion.Location = new System.Drawing.Point(39, 30);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnGestionMessages);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestionMessages;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}


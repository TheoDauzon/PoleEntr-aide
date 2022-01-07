namespace AP4
{
    partial class ListeInscrit
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
            this.components = new System.ComponentModel.Container();
            this.bsInscrits = new System.Windows.Forms.BindingSource(this.components);
            this.dgvInscrits = new System.Windows.Forms.DataGridView();
            this.lbTitre = new System.Windows.Forms.Label();
            this.btnAjouterInscrit = new System.Windows.Forms.Button();
            this.btnModifierInscrit = new System.Windows.Forms.Button();
            this.btnSupprimerInscrit = new System.Windows.Forms.Button();
            this.btnRetourMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsInscrits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscrits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInscrits
            // 
            this.dgvInscrits.AllowUserToAddRows = false;
            this.dgvInscrits.AllowUserToDeleteRows = false;
            this.dgvInscrits.AutoGenerateColumns = false;
            this.dgvInscrits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscrits.DataSource = this.bsInscrits;
            this.dgvInscrits.Location = new System.Drawing.Point(93, 128);
            this.dgvInscrits.Name = "dgvInscrits";
            this.dgvInscrits.ReadOnly = true;
            this.dgvInscrits.Size = new System.Drawing.Size(587, 225);
            this.dgvInscrits.TabIndex = 0;            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Location = new System.Drawing.Point(358, 58);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(84, 13);
            this.lbTitre.TabIndex = 1;
            this.lbTitre.Text = "Liste des inscrits";
            // 
            // btnAjouterInscrit
            // 
            this.btnAjouterInscrit.Location = new System.Drawing.Point(579, 387);
            this.btnAjouterInscrit.Name = "btnAjouterInscrit";
            this.btnAjouterInscrit.Size = new System.Drawing.Size(101, 26);
            this.btnAjouterInscrit.TabIndex = 2;
            this.btnAjouterInscrit.Text = "AJOUTER";
            this.btnAjouterInscrit.UseVisualStyleBackColor = true;
            // 
            // btnModifierInscrit
            // 
            this.btnModifierInscrit.Location = new System.Drawing.Point(361, 387);
            this.btnModifierInscrit.Name = "btnModifierInscrit";
            this.btnModifierInscrit.Size = new System.Drawing.Size(94, 26);
            this.btnModifierInscrit.TabIndex = 3;
            this.btnModifierInscrit.Text = "MODIFIER";
            this.btnModifierInscrit.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerInscrit
            // 
            this.btnSupprimerInscrit.Location = new System.Drawing.Point(93, 389);
            this.btnSupprimerInscrit.Name = "btnSupprimerInscrit";
            this.btnSupprimerInscrit.Size = new System.Drawing.Size(115, 29);
            this.btnSupprimerInscrit.TabIndex = 4;
            this.btnSupprimerInscrit.Text = "SUPPRIMER";
            this.btnSupprimerInscrit.UseVisualStyleBackColor = true;
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Location = new System.Drawing.Point(26, 22);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(140, 49);
            this.btnRetourMenu.TabIndex = 5;
            this.btnRetourMenu.Text = "RETOUR AU MENU";
            this.btnRetourMenu.UseVisualStyleBackColor = true;
            this.btnRetourMenu.Click += new System.EventHandler(this.BtnRetourMenu_Click);
            // 
            // ListeInscrit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetourMenu);
            this.Controls.Add(this.btnSupprimerInscrit);
            this.Controls.Add(this.btnModifierInscrit);
            this.Controls.Add(this.btnAjouterInscrit);
            this.Controls.Add(this.lbTitre);
            this.Controls.Add(this.dgvInscrits);
            this.Name = "ListeInscrit";
            this.Text = "ListeInscrit";
            this.Load += new System.EventHandler(this.ListeInscrit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsInscrits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscrits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsInscrits;
        private System.Windows.Forms.DataGridView dgvInscrits;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.Button btnAjouterInscrit;
        private System.Windows.Forms.Button btnModifierInscrit;
        private System.Windows.Forms.Button btnSupprimerInscrit;
        private System.Windows.Forms.Button btnRetourMenu;
    }
}
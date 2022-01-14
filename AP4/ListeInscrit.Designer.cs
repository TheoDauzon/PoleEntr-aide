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
            this.lbTitre = new System.Windows.Forms.Label();
            this.btnAjouterInscrit = new System.Windows.Forms.Button();
            this.btnModifierInscrit = new System.Windows.Forms.Button();
            this.btnSupprimerInscrit = new System.Windows.Forms.Button();
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.bsInscrit = new System.Windows.Forms.BindingSource(this.components);
            this.dgvInscrit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bsInscrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscrit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Liberation Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(283, 18);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(209, 30);
            this.lbTitre.TabIndex = 1;
            this.lbTitre.Text = "Liste des inscrits";
            // 
            // btnAjouterInscrit
            // 
            this.btnAjouterInscrit.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterInscrit.Location = new System.Drawing.Point(25, 398);
            this.btnAjouterInscrit.Name = "btnAjouterInscrit";
            this.btnAjouterInscrit.Size = new System.Drawing.Size(116, 40);
            this.btnAjouterInscrit.TabIndex = 2;
            this.btnAjouterInscrit.Text = "AJOUTER";
            this.btnAjouterInscrit.UseVisualStyleBackColor = true;
            // 
            // btnModifierInscrit
            // 
            this.btnModifierInscrit.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierInscrit.Location = new System.Drawing.Point(207, 398);
            this.btnModifierInscrit.Name = "btnModifierInscrit";
            this.btnModifierInscrit.Size = new System.Drawing.Size(116, 40);
            this.btnModifierInscrit.TabIndex = 3;
            this.btnModifierInscrit.Text = "MODIFIER";
            this.btnModifierInscrit.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerInscrit
            // 
            this.btnSupprimerInscrit.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerInscrit.Location = new System.Drawing.Point(390, 398);
            this.btnSupprimerInscrit.Name = "btnSupprimerInscrit";
            this.btnSupprimerInscrit.Size = new System.Drawing.Size(116, 40);
            this.btnSupprimerInscrit.TabIndex = 4;
            this.btnSupprimerInscrit.Text = "SUPPRIMER";
            this.btnSupprimerInscrit.UseVisualStyleBackColor = true;
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourMenu.Location = new System.Drawing.Point(12, 12);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(163, 49);
            this.btnRetourMenu.TabIndex = 5;
            this.btnRetourMenu.Text = "RETOUR AU MENU";
            this.btnRetourMenu.UseVisualStyleBackColor = true;
            this.btnRetourMenu.Click += new System.EventHandler(this.BtnRetourMenu_Click);
            // 
            // dgvInscrit
            // 
            this.dgvInscrit.AllowUserToAddRows = false;
            this.dgvInscrit.AllowUserToDeleteRows = false;
            this.dgvInscrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscrit.Location = new System.Drawing.Point(25, 159);
            this.dgvInscrit.Name = "dgvInscrit";
            this.dgvInscrit.ReadOnly = true;
            this.dgvInscrit.Size = new System.Drawing.Size(750, 233);
            this.dgvInscrit.TabIndex = 6;
            // 
            // ListeInscrit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvInscrit);
            this.Controls.Add(this.btnRetourMenu);
            this.Controls.Add(this.btnSupprimerInscrit);
            this.Controls.Add(this.btnModifierInscrit);
            this.Controls.Add(this.btnAjouterInscrit);
            this.Controls.Add(this.lbTitre);
            this.Name = "ListeInscrit";
            this.Text = "ListeInscrit";
            this.Load += new System.EventHandler(this.ListeInscrit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsInscrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscrit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.Button btnAjouterInscrit;
        private System.Windows.Forms.Button btnModifierInscrit;
        private System.Windows.Forms.Button btnSupprimerInscrit;
        private System.Windows.Forms.Button btnRetourMenu;
        private System.Windows.Forms.BindingSource bsInscrit;
        private System.Windows.Forms.DataGridView dgvInscrit;
    }
}
﻿namespace AP4
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
            this.btnModifierInscrit = new System.Windows.Forms.Button();
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.bsInscrit = new System.Windows.Forms.BindingSource(this.components);
            this.dgvInscrit = new System.Windows.Forms.DataGridView();
            this.btnSupprimerMessage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsInscrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscrit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(377, 22);
            this.lbTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(286, 39);
            this.lbTitre.TabIndex = 1;
            this.lbTitre.Text = "Liste des inscrits";
            // 
            // btnModifierInscrit
            // 
            this.btnModifierInscrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierInscrit.Location = new System.Drawing.Point(33, 490);
            this.btnModifierInscrit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifierInscrit.Name = "btnModifierInscrit";
            this.btnModifierInscrit.Size = new System.Drawing.Size(155, 49);
            this.btnModifierInscrit.TabIndex = 3;
            this.btnModifierInscrit.Text = "MODIFIER";
            this.btnModifierInscrit.UseVisualStyleBackColor = true;
            this.btnModifierInscrit.Click += new System.EventHandler(this.btnModifierInscrit_Click);
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourMenu.Location = new System.Drawing.Point(16, 15);
            this.btnRetourMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(217, 60);
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
            this.dgvInscrit.Location = new System.Drawing.Point(33, 196);
            this.dgvInscrit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInscrit.Name = "dgvInscrit";
            this.dgvInscrit.ReadOnly = true;
            this.dgvInscrit.RowHeadersWidth = 51;
            this.dgvInscrit.Size = new System.Drawing.Size(1000, 287);
            this.dgvInscrit.TabIndex = 6;
            // 
            // btnSupprimerMessage
            // 
            this.btnSupprimerMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerMessage.Location = new System.Drawing.Point(206, 491);
            this.btnSupprimerMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerMessage.Name = "btnSupprimerMessage";
            this.btnSupprimerMessage.Size = new System.Drawing.Size(155, 48);
            this.btnSupprimerMessage.TabIndex = 11;
            this.btnSupprimerMessage.Text = "SUPPRIMER";
            this.btnSupprimerMessage.UseVisualStyleBackColor = true;
            this.btnSupprimerMessage.Click += new System.EventHandler(this.btnSupprimerMessage_Click);
            // 
            // ListeInscrit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSupprimerMessage);
            this.Controls.Add(this.dgvInscrit);
            this.Controls.Add(this.btnRetourMenu);
            this.Controls.Add(this.btnModifierInscrit);
            this.Controls.Add(this.lbTitre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnModifierInscrit;
        private System.Windows.Forms.Button btnRetourMenu;
        private System.Windows.Forms.BindingSource bsInscrit;
        private System.Windows.Forms.DataGridView dgvInscrit;
        private System.Windows.Forms.Button btnSupprimerMessage;
    }
}
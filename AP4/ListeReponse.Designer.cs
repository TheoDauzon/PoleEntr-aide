﻿
namespace AP4
{
    partial class ListeReponse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeReponse));
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.lbListeReponse = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvReponse = new System.Windows.Forms.DataGridView();
            this.bsReponse = new System.Windows.Forms.BindingSource(this.components);
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbDateReponse = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbService = new System.Windows.Forms.TextBox();
            this.mstDateServFin = new System.Windows.Forms.MaskedTextBox();
            this.mstDateServDeb = new System.Windows.Forms.MaskedTextBox();
            this.lbFinRep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourMenu.ForeColor = System.Drawing.Color.Black;
            this.btnRetourMenu.Location = new System.Drawing.Point(16, 15);
            this.btnRetourMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(217, 60);
            this.btnRetourMenu.TabIndex = 0;
            this.btnRetourMenu.Text = "RETOUR AU MENU";
            this.btnRetourMenu.UseVisualStyleBackColor = true;
            this.btnRetourMenu.Click += new System.EventHandler(this.BtnRetourMenu_Click);
            // 
            // lbListeReponse
            // 
            this.lbListeReponse.AutoSize = true;
            this.lbListeReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListeReponse.ForeColor = System.Drawing.Color.Black;
            this.lbListeReponse.Location = new System.Drawing.Point(377, 22);
            this.lbListeReponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListeReponse.Name = "lbListeReponse";
            this.lbListeReponse.Size = new System.Drawing.Size(411, 39);
            this.lbListeReponse.TabIndex = 1;
            this.lbListeReponse.Text = "LISTE DES RÉPONSES";
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.Location = new System.Drawing.Point(33, 490);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(155, 49);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dgvReponse
            // 
            this.dgvReponse.AllowUserToAddRows = false;
            this.dgvReponse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReponse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReponse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReponse.Location = new System.Drawing.Point(33, 196);
            this.dgvReponse.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReponse.Name = "dgvReponse";
            this.dgvReponse.ReadOnly = true;
            this.dgvReponse.RowHeadersWidth = 51;
            this.dgvReponse.Size = new System.Drawing.Size(1000, 287);
            this.dgvReponse.TabIndex = 5;
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(225, 102);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(133, 30);
            this.tbNumero.TabIndex = 30;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(16, 105);
            this.lbNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(187, 25);
            this.lbNumero.TabIndex = 29;
            this.lbNumero.Text = "Numéro  de l\'inscrit :";
            // 
            // lbDateReponse
            // 
            this.lbDateReponse.AutoSize = true;
            this.lbDateReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateReponse.Location = new System.Drawing.Point(16, 153);
            this.lbDateReponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateReponse.Name = "lbDateReponse";
            this.lbDateReponse.Size = new System.Drawing.Size(172, 25);
            this.lbDateReponse.TabIndex = 27;
            this.lbDateReponse.Text = "Date réponse  de :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(824, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(856, 140);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(177, 38);
            this.btnRechercher.TabIndex = 45;
            this.btnRechercher.Text = "RECHERCHER";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Numéro du service :";
            // 
            // tbService
            // 
            this.tbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbService.Location = new System.Drawing.Point(571, 102);
            this.tbService.Name = "tbService";
            this.tbService.Size = new System.Drawing.Size(111, 30);
            this.tbService.TabIndex = 48;
            // 
            // mstDateServFin
            // 
            this.mstDateServFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstDateServFin.Location = new System.Drawing.Point(409, 150);
            this.mstDateServFin.Mask = "00/00/0000";
            this.mstDateServFin.Name = "mstDateServFin";
            this.mstDateServFin.Size = new System.Drawing.Size(156, 30);
            this.mstDateServFin.TabIndex = 61;
            // 
            // mstDateServDeb
            // 
            this.mstDateServDeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstDateServDeb.Location = new System.Drawing.Point(202, 150);
            this.mstDateServDeb.Mask = "00/00/0000";
            this.mstDateServDeb.Name = "mstDateServDeb";
            this.mstDateServDeb.Size = new System.Drawing.Size(156, 30);
            this.mstDateServDeb.TabIndex = 60;
            // 
            // lbFinRep
            // 
            this.lbFinRep.AutoSize = true;
            this.lbFinRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinRep.Location = new System.Drawing.Point(365, 153);
            this.lbFinRep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFinRep.Name = "lbFinRep";
            this.lbFinRep.Size = new System.Drawing.Size(37, 25);
            this.lbFinRep.TabIndex = 59;
            this.lbFinRep.Text = "À :";
            // 
            // ListeReponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1068, 554);
            this.Controls.Add(this.mstDateServFin);
            this.Controls.Add(this.mstDateServDeb);
            this.Controls.Add(this.lbFinRep);
            this.Controls.Add(this.tbService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbDateReponse);
            this.Controls.Add(this.dgvReponse);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lbListeReponse);
            this.Controls.Add(this.btnRetourMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListeReponse";
            this.Text = "ListeReponse";
            this.Load += new System.EventHandler(this.ListeReponse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetourMenu;
        private System.Windows.Forms.Label lbListeReponse;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView dgvReponse;
        private System.Windows.Forms.BindingSource bsReponse;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbDateReponse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbService;
        private System.Windows.Forms.MaskedTextBox mstDateServFin;
        private System.Windows.Forms.MaskedTextBox mstDateServDeb;
        private System.Windows.Forms.Label lbFinRep;
    }
}
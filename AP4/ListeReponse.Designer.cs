
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeReponse));
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.lbListeReponse = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvReponse = new System.Windows.Forms.DataGridView();
            this.bsReponse = new System.Windows.Forms.BindingSource(this.components);
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbDateRepDebut = new System.Windows.Forms.TextBox();
            this.lbDateReponse = new System.Windows.Forms.Label();
            this.tbDateRepFin = new System.Windows.Forms.TextBox();
            this.lbFinRep = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTous = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourMenu.ForeColor = System.Drawing.Color.Black;
            this.btnRetourMenu.Location = new System.Drawing.Point(12, 12);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(163, 49);
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
            this.lbListeReponse.Location = new System.Drawing.Point(283, 18);
            this.lbListeReponse.Name = "lbListeReponse";
            this.lbListeReponse.Size = new System.Drawing.Size(329, 31);
            this.lbListeReponse.TabIndex = 1;
            this.lbListeReponse.Text = "LISTE DES RÉPONSES";
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.Location = new System.Drawing.Point(25, 398);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(116, 40);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // dgvReponse
            // 
            this.dgvReponse.AllowUserToAddRows = false;
            this.dgvReponse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReponse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReponse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReponse.Location = new System.Drawing.Point(25, 159);
            this.dgvReponse.Name = "dgvReponse";
            this.dgvReponse.ReadOnly = true;
            this.dgvReponse.Size = new System.Drawing.Size(750, 233);
            this.dgvReponse.TabIndex = 5;
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(91, 82);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(149, 26);
            this.tbNumero.TabIndex = 30;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(12, 85);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(73, 20);
            this.lbNumero.TabIndex = 29;
            this.lbNumero.Text = "Numéro :";
            // 
            // tbDateRepDebut
            // 
            this.tbDateRepDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateRepDebut.Location = new System.Drawing.Point(158, 121);
            this.tbDateRepDebut.Name = "tbDateRepDebut";
            this.tbDateRepDebut.Size = new System.Drawing.Size(149, 26);
            this.tbDateRepDebut.TabIndex = 28;
            // 
            // lbDateReponse
            // 
            this.lbDateReponse.AutoSize = true;
            this.lbDateReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateReponse.Location = new System.Drawing.Point(12, 124);
            this.lbDateReponse.Name = "lbDateReponse";
            this.lbDateReponse.Size = new System.Drawing.Size(140, 20);
            this.lbDateReponse.TabIndex = 27;
            this.lbDateReponse.Text = "Date réponse  de :";
            // 
            // tbDateRepFin
            // 
            this.tbDateRepFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateRepFin.Location = new System.Drawing.Point(348, 121);
            this.tbDateRepFin.Name = "tbDateRepFin";
            this.tbDateRepFin.Size = new System.Drawing.Size(149, 26);
            this.tbDateRepFin.TabIndex = 31;
            // 
            // lbFinRep
            // 
            this.lbFinRep.AutoSize = true;
            this.lbFinRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinRep.Location = new System.Drawing.Point(313, 124);
            this.lbFinRep.Name = "lbFinRep";
            this.lbFinRep.Size = new System.Drawing.Size(28, 20);
            this.lbFinRep.TabIndex = 32;
            this.lbFinRep.Text = "À :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(618, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnTous
            // 
            this.btnTous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTous.Location = new System.Drawing.Point(642, 115);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(133, 29);
            this.btnTous.TabIndex = 46;
            this.btnTous.Text = "TOUS";
            this.btnTous.UseVisualStyleBackColor = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(642, 82);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(133, 31);
            this.btnRechercher.TabIndex = 45;
            this.btnRechercher.Text = "RECHERCHER";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // ListeReponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTous);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbFinRep);
            this.Controls.Add(this.tbDateRepFin);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.tbDateRepDebut);
            this.Controls.Add(this.lbDateReponse);
            this.Controls.Add(this.dgvReponse);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lbListeReponse);
            this.Controls.Add(this.btnRetourMenu);
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
        private System.Windows.Forms.TextBox tbDateRepDebut;
        private System.Windows.Forms.Label lbDateReponse;
        private System.Windows.Forms.TextBox tbDateRepFin;
        private System.Windows.Forms.Label lbFinRep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Button btnRechercher;
    }
}
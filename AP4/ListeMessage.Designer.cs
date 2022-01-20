
namespace AP4
{
    partial class ListeMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeMessage));
            this.dgvMessage = new System.Windows.Forms.DataGridView();
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.btnModifierMessage = new System.Windows.Forms.Button();
            this.lbTitre = new System.Windows.Forms.Label();
            this.bsMessage = new System.Windows.Forms.BindingSource(this.components);
            this.lbLibelle = new System.Windows.Forms.Label();
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.lbTraite = new System.Windows.Forms.Label();
            this.tbTraiter = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.btnTous = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMessage
            // 
            this.dgvMessage.AllowUserToAddRows = false;
            this.dgvMessage.AllowUserToDeleteRows = false;
            this.dgvMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessage.Location = new System.Drawing.Point(32, 148);
            this.dgvMessage.Name = "dgvMessage";
            this.dgvMessage.ReadOnly = true;
            this.dgvMessage.RowHeadersWidth = 51;
            this.dgvMessage.Size = new System.Drawing.Size(750, 244);
            this.dgvMessage.TabIndex = 12;
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourMenu.Location = new System.Drawing.Point(19, 12);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(163, 49);
            this.btnRetourMenu.TabIndex = 11;
            this.btnRetourMenu.Text = "RETOUR AU MENU";
            this.btnRetourMenu.UseVisualStyleBackColor = true;
            this.btnRetourMenu.Click += new System.EventHandler(this.BtnRetourMenu_Click);
            // 
            // btnModifierMessage
            // 
            this.btnModifierMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierMessage.Location = new System.Drawing.Point(32, 398);
            this.btnModifierMessage.Name = "btnModifierMessage";
            this.btnModifierMessage.Size = new System.Drawing.Size(116, 40);
            this.btnModifierMessage.TabIndex = 9;
            this.btnModifierMessage.Text = "MODIFIER";
            this.btnModifierMessage.UseVisualStyleBackColor = true;
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(290, 18);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(272, 31);
            this.lbTitre.TabIndex = 7;
            this.lbTitre.Text = "Liste des messages";
            // 
            // lbLibelle
            // 
            this.lbLibelle.AutoSize = true;
            this.lbLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibelle.Location = new System.Drawing.Point(39, 111);
            this.lbLibelle.Name = "lbLibelle";
            this.lbLibelle.Size = new System.Drawing.Size(62, 20);
            this.lbLibelle.TabIndex = 13;
            this.lbLibelle.Text = "Libellé :";
            // 
            // tbLibelle
            // 
            this.tbLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLibelle.Location = new System.Drawing.Point(107, 108);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(149, 26);
            this.tbLibelle.TabIndex = 14;
            // 
            // lbTraite
            // 
            this.lbTraite.AutoSize = true;
            this.lbTraite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTraite.Location = new System.Drawing.Point(280, 72);
            this.lbTraite.Name = "lbTraite";
            this.lbTraite.Size = new System.Drawing.Size(57, 20);
            this.lbTraite.TabIndex = 17;
            this.lbTraite.Text = "Traité :";
            // 
            // tbTraiter
            // 
            this.tbTraiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTraiter.Location = new System.Drawing.Point(343, 69);
            this.tbTraiter.Name = "tbTraiter";
            this.tbTraiter.Size = new System.Drawing.Size(149, 26);
            this.tbTraiter.TabIndex = 18;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(28, 72);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(73, 20);
            this.lbNumero.TabIndex = 22;
            this.lbNumero.Text = "Numéro :";
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(107, 69);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(149, 26);
            this.tbNumero.TabIndex = 24;
            // 
            // btnTous
            // 
            this.btnTous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTous.Location = new System.Drawing.Point(649, 103);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(133, 31);
            this.btnTous.TabIndex = 42;
            this.btnTous.Text = "TOUS";
            this.btnTous.UseVisualStyleBackColor = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(649, 67);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(133, 31);
            this.btnRechercher.TabIndex = 41;
            this.btnRechercher.Text = "RECHERCHER";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(600, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // ListeMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTous);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.tbTraiter);
            this.Controls.Add(this.lbTraite);
            this.Controls.Add(this.tbLibelle);
            this.Controls.Add(this.lbLibelle);
            this.Controls.Add(this.dgvMessage);
            this.Controls.Add(this.btnRetourMenu);
            this.Controls.Add(this.btnModifierMessage);
            this.Controls.Add(this.lbTitre);
            this.Name = "ListeMessage";
            this.Text = "ListeMessage";
            this.Load += new System.EventHandler(this.ListeMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMessage;
        private System.Windows.Forms.Button btnRetourMenu;
        private System.Windows.Forms.Button btnModifierMessage;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.BindingSource bsMessage;
        private System.Windows.Forms.Label lbLibelle;
        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.Label lbTraite;
        private System.Windows.Forms.TextBox tbTraiter;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
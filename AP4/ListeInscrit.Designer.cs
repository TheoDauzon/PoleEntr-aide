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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeInscrit));
            this.lbTitre = new System.Windows.Forms.Label();
            this.btnModifierInscrit = new System.Windows.Forms.Button();
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.bsInscrit = new System.Windows.Forms.BindingSource(this.components);
            this.dgvInscrit = new System.Windows.Forms.DataGridView();
            this.btnSupprimerMessage = new System.Windows.Forms.Button();
            this.btnAjouterInscrit = new System.Windows.Forms.Button();
            this.btnTous = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbStatut = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbStatut = new System.Windows.Forms.Label();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.tbAdmin = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsInscrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(283, 18);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(234, 31);
            this.lbTitre.TabIndex = 1;
            this.lbTitre.Text = "Liste des inscrits";
            // 
            // btnModifierInscrit
            // 
            this.btnModifierInscrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierInscrit.Location = new System.Drawing.Point(25, 398);
            this.btnModifierInscrit.Name = "btnModifierInscrit";
            this.btnModifierInscrit.Size = new System.Drawing.Size(116, 40);
            this.btnModifierInscrit.TabIndex = 3;
            this.btnModifierInscrit.Text = "MODIFIER";
            this.btnModifierInscrit.UseVisualStyleBackColor = true;
            this.btnModifierInscrit.Click += new System.EventHandler(this.BtnModifierInscrit_Click);
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvInscrit.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInscrit.Location = new System.Drawing.Point(25, 159);
            this.dgvInscrit.Name = "dgvInscrit";
            this.dgvInscrit.ReadOnly = true;
            this.dgvInscrit.RowHeadersWidth = 51;
            this.dgvInscrit.Size = new System.Drawing.Size(750, 233);
            this.dgvInscrit.TabIndex = 6;
            // 
            // btnSupprimerMessage
            // 
            this.btnSupprimerMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerMessage.Location = new System.Drawing.Point(157, 399);
            this.btnSupprimerMessage.Name = "btnSupprimerMessage";
            this.btnSupprimerMessage.Size = new System.Drawing.Size(116, 39);
            this.btnSupprimerMessage.TabIndex = 11;
            this.btnSupprimerMessage.Text = "SUPPRIMER";
            this.btnSupprimerMessage.UseVisualStyleBackColor = true;
            this.btnSupprimerMessage.Click += new System.EventHandler(this.BtnSupprimerMessage_Click);
            // 
            // btnAjouterInscrit
            // 
            this.btnAjouterInscrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterInscrit.Location = new System.Drawing.Point(289, 399);
            this.btnAjouterInscrit.Name = "btnAjouterInscrit";
            this.btnAjouterInscrit.Size = new System.Drawing.Size(116, 39);
            this.btnAjouterInscrit.TabIndex = 12;
            this.btnAjouterInscrit.Text = "AJOUTER";
            this.btnAjouterInscrit.UseVisualStyleBackColor = true;
            // 
            // btnTous
            // 
            this.btnTous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTous.Location = new System.Drawing.Point(656, 108);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(133, 31);
            this.btnTous.TabIndex = 40;
            this.btnTous.Text = "TOUS";
            this.btnTous.UseVisualStyleBackColor = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(656, 75);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(133, 31);
            this.btnRechercher.TabIndex = 39;
            this.btnRechercher.Text = "RECHERCHER";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(91, 77);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(149, 26);
            this.tbNumero.TabIndex = 38;
            // 
            // tbStatut
            // 
            this.tbStatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatut.Location = new System.Drawing.Point(544, 77);
            this.tbStatut.Name = "tbStatut";
            this.tbStatut.Size = new System.Drawing.Size(100, 26);
            this.tbStatut.TabIndex = 37;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(12, 80);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(73, 20);
            this.lbNumero.TabIndex = 36;
            this.lbNumero.Text = "Numéro :";
            // 
            // lbStatut
            // 
            this.lbStatut.AutoSize = true;
            this.lbStatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatut.Location = new System.Drawing.Point(477, 80);
            this.lbStatut.Name = "lbStatut";
            this.lbStatut.Size = new System.Drawing.Size(61, 20);
            this.lbStatut.TabIndex = 35;
            this.lbStatut.Text = "Statut :";
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmin.Location = new System.Drawing.Point(476, 116);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(62, 20);
            this.lbAdmin.TabIndex = 34;
            this.lbAdmin.Text = "Admin :";
            // 
            // tbAdmin
            // 
            this.tbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdmin.Location = new System.Drawing.Point(544, 113);
            this.tbAdmin.Name = "tbAdmin";
            this.tbAdmin.Size = new System.Drawing.Size(100, 26);
            this.tbAdmin.TabIndex = 33;
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.Location = new System.Drawing.Point(313, 113);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(149, 26);
            this.tbMail.TabIndex = 32;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(262, 116);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(45, 20);
            this.lbMail.TabIndex = 31;
            this.lbMail.Text = "Mail :";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenom.Location = new System.Drawing.Point(13, 116);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(72, 20);
            this.lbPrenom.TabIndex = 30;
            this.lbPrenom.Text = "Prénom :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(91, 113);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(149, 26);
            this.tbPrenom.TabIndex = 29;
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(313, 77);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(149, 26);
            this.tbNom.TabIndex = 28;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(257, 80);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(50, 20);
            this.lbNom.TabIndex = 27;
            this.lbNom.Text = "Nom :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(607, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // ListeInscrit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTous);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbStatut);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbStatut);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.tbAdmin);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.btnAjouterInscrit);
            this.Controls.Add(this.btnSupprimerMessage);
            this.Controls.Add(this.dgvInscrit);
            this.Controls.Add(this.btnRetourMenu);
            this.Controls.Add(this.btnModifierInscrit);
            this.Controls.Add(this.lbTitre);
            this.Name = "ListeInscrit";
            this.Text = "ListeInscrit";
            this.Load += new System.EventHandler(this.ListeInscrit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsInscrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnAjouterInscrit;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbStatut;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbStatut;
        private System.Windows.Forms.Label lbAdmin;
        private System.Windows.Forms.TextBox tbAdmin;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
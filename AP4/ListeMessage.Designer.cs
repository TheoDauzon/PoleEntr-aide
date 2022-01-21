
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
            this.btnRechercher = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbObjet = new System.Windows.Forms.TextBox();
            this.tbCorps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.dgvMessage.Location = new System.Drawing.Point(43, 182);
            this.dgvMessage.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMessage.Name = "dgvMessage";
            this.dgvMessage.ReadOnly = true;
            this.dgvMessage.RowHeadersWidth = 51;
            this.dgvMessage.Size = new System.Drawing.Size(1000, 300);
            this.dgvMessage.TabIndex = 12;
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourMenu.Location = new System.Drawing.Point(25, 15);
            this.btnRetourMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(217, 60);
            this.btnRetourMenu.TabIndex = 11;
            this.btnRetourMenu.Text = "RETOUR AU MENU";
            this.btnRetourMenu.UseVisualStyleBackColor = true;
            this.btnRetourMenu.Click += new System.EventHandler(this.BtnRetourMenu_Click);
            // 
            // btnModifierMessage
            // 
            this.btnModifierMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierMessage.Location = new System.Drawing.Point(43, 490);
            this.btnModifierMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierMessage.Name = "btnModifierMessage";
            this.btnModifierMessage.Size = new System.Drawing.Size(155, 49);
            this.btnModifierMessage.TabIndex = 9;
            this.btnModifierMessage.Text = "MODIFIER";
            this.btnModifierMessage.UseVisualStyleBackColor = true;
            this.btnModifierMessage.Click += new System.EventHandler(this.btnModifierMessage_Click);
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(387, 22);
            this.lbTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(325, 38);
            this.lbTitre.TabIndex = 7;
            this.lbTitre.Text = "Liste des messages";
            // 
            // lbLibelle
            // 
            this.lbLibelle.AutoSize = true;
            this.lbLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibelle.Location = new System.Drawing.Point(52, 137);
            this.lbLibelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLibelle.Name = "lbLibelle";
            this.lbLibelle.Size = new System.Drawing.Size(79, 25);
            this.lbLibelle.TabIndex = 13;
            this.lbLibelle.Text = "Libellé :";
            // 
            // tbLibelle
            // 
            this.tbLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLibelle.Location = new System.Drawing.Point(143, 133);
            this.tbLibelle.Margin = new System.Windows.Forms.Padding(4);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(501, 30);
            this.tbLibelle.TabIndex = 14;
            // 
            // lbTraite
            // 
            this.lbTraite.AutoSize = true;
            this.lbTraite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTraite.Location = new System.Drawing.Point(447, 89);
            this.lbTraite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTraite.Name = "lbTraite";
            this.lbTraite.Size = new System.Drawing.Size(73, 25);
            this.lbTraite.TabIndex = 17;
            this.lbTraite.Text = "Traité :";
            // 
            // tbTraiter
            // 
            this.tbTraiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTraiter.Location = new System.Drawing.Point(528, 86);
            this.tbTraiter.Margin = new System.Windows.Forms.Padding(4);
            this.tbTraiter.Name = "tbTraiter";
            this.tbTraiter.Size = new System.Drawing.Size(116, 30);
            this.tbTraiter.TabIndex = 18;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(37, 89);
            this.lbNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(182, 25);
            this.lbNumero.TabIndex = 22;
            this.lbNumero.Text = "Numéro de l\'inscrit :";
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(227, 86);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(197, 30);
            this.tbNumero.TabIndex = 24;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(866, 124);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(177, 38);
            this.btnRechercher.TabIndex = 41;
            this.btnRechercher.Text = "RECHERCHER";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(804, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyer.Location = new System.Drawing.Point(1261, 490);
            this.btnEnvoyer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(155, 49);
            this.btnEnvoyer.TabIndex = 44;
            this.btnEnvoyer.Text = "ENVOYER";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.Location = new System.Drawing.Point(1202, 134);
            this.tbMail.Margin = new System.Windows.Forms.Padding(4);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(339, 30);
            this.tbMail.TabIndex = 45;
            // 
            // tbObjet
            // 
            this.tbObjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObjet.Location = new System.Drawing.Point(1202, 185);
            this.tbObjet.Margin = new System.Windows.Forms.Padding(4);
            this.tbObjet.Name = "tbObjet";
            this.tbObjet.Size = new System.Drawing.Size(339, 30);
            this.tbObjet.TabIndex = 46;
            // 
            // tbCorps
            // 
            this.tbCorps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorps.Location = new System.Drawing.Point(1202, 235);
            this.tbCorps.Margin = new System.Windows.Forms.Padding(4);
            this.tbCorps.Name = "tbCorps";
            this.tbCorps.Size = new System.Drawing.Size(339, 30);
            this.tbCorps.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1124, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Objet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1152, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = " À :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1051, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Corps du mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1122, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(395, 38);
            this.label4.TabIndex = 51;
            this.label4.Text = "Répondre à un message";
            // 
            // ListeMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1554, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCorps);
            this.Controls.Add(this.tbObjet);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbObjet;
        private System.Windows.Forms.TextBox tbCorps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
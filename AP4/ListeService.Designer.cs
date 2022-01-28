
namespace AP4
{
    partial class ListeService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeService));
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.lbListeService = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.bsService = new System.Windows.Forms.BindingSource(this.components);
            this.btnRechercher = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbExecute = new System.Windows.Forms.TextBox();
            this.lbExecute = new System.Windows.Forms.Label();
            this.tbDescriptif = new System.Windows.Forms.TextBox();
            this.lbDescriptif = new System.Windows.Forms.Label();
            this.lbFinRep = new System.Windows.Forms.Label();
            this.lbDateReponse = new System.Windows.Forms.Label();
            this.mstDateServDeb = new System.Windows.Forms.MaskedTextBox();
            this.mstDateServFin = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourMenu.Location = new System.Drawing.Point(16, 15);
            this.btnRetourMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(217, 60);
            this.btnRetourMenu.TabIndex = 0;
            this.btnRetourMenu.Text = "RETOUR AU MENU";
            this.btnRetourMenu.UseVisualStyleBackColor = true;
            this.btnRetourMenu.Click += new System.EventHandler(this.BtnRetourMenu_Click);
            // 
            // lbListeService
            // 
            this.lbListeService.AutoSize = true;
            this.lbListeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListeService.Location = new System.Drawing.Point(377, 22);
            this.lbListeService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListeService.Name = "lbListeService";
            this.lbListeService.Size = new System.Drawing.Size(395, 39);
            this.lbListeService.TabIndex = 1;
            this.lbListeService.Text = "LISTE DES SERVICES";
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(33, 490);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(155, 49);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(33, 196);
            this.dgvService.Margin = new System.Windows.Forms.Padding(4);
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.RowHeadersWidth = 51;
            this.dgvService.Size = new System.Drawing.Size(1000, 287);
            this.dgvService.TabIndex = 5;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(856, 139);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(177, 30);
            this.btnRechercher.TabIndex = 35;
            this.btnRechercher.Text = "RECHERCHER";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(807, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(217, 99);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(197, 30);
            this.tbNumero.TabIndex = 52;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(28, 102);
            this.lbNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(182, 25);
            this.lbNumero.TabIndex = 51;
            this.lbNumero.Text = "Numéro de l\'inscrit :";
            // 
            // tbExecute
            // 
            this.tbExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExecute.Location = new System.Drawing.Point(739, 139);
            this.tbExecute.Margin = new System.Windows.Forms.Padding(4);
            this.tbExecute.Name = "tbExecute";
            this.tbExecute.Size = new System.Drawing.Size(93, 30);
            this.tbExecute.TabIndex = 50;
            // 
            // lbExecute
            // 
            this.lbExecute.AutoSize = true;
            this.lbExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExecute.Location = new System.Drawing.Point(637, 142);
            this.lbExecute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbExecute.Name = "lbExecute";
            this.lbExecute.Size = new System.Drawing.Size(94, 25);
            this.lbExecute.TabIndex = 49;
            this.lbExecute.Text = "Exécuté :";
            // 
            // tbDescriptif
            // 
            this.tbDescriptif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescriptif.Location = new System.Drawing.Point(544, 99);
            this.tbDescriptif.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescriptif.Name = "tbDescriptif";
            this.tbDescriptif.Size = new System.Drawing.Size(489, 30);
            this.tbDescriptif.TabIndex = 46;
            // 
            // lbDescriptif
            // 
            this.lbDescriptif.AutoSize = true;
            this.lbDescriptif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescriptif.Location = new System.Drawing.Point(433, 102);
            this.lbDescriptif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescriptif.Name = "lbDescriptif";
            this.lbDescriptif.Size = new System.Drawing.Size(103, 25);
            this.lbDescriptif.TabIndex = 45;
            this.lbDescriptif.Text = "Descriptif :";
            // 
            // lbFinRep
            // 
            this.lbFinRep.AutoSize = true;
            this.lbFinRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinRep.Location = new System.Drawing.Point(353, 143);
            this.lbFinRep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFinRep.Name = "lbFinRep";
            this.lbFinRep.Size = new System.Drawing.Size(37, 25);
            this.lbFinRep.TabIndex = 56;
            this.lbFinRep.Text = "À :";
            // 
            // lbDateReponse
            // 
            this.lbDateReponse.AutoSize = true;
            this.lbDateReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateReponse.Location = new System.Drawing.Point(28, 143);
            this.lbDateReponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateReponse.Name = "lbDateReponse";
            this.lbDateReponse.Size = new System.Drawing.Size(150, 25);
            this.lbDateReponse.TabIndex = 53;
            this.lbDateReponse.Text = "Date dépot  de :";
            // 
            // mstDateServDeb
            // 
            this.mstDateServDeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstDateServDeb.Location = new System.Drawing.Point(190, 140);
            this.mstDateServDeb.Mask = "00/00/0000";
            this.mstDateServDeb.Name = "mstDateServDeb";
            this.mstDateServDeb.Size = new System.Drawing.Size(156, 30);
            this.mstDateServDeb.TabIndex = 57;
            // 
            // mstDateServFin
            // 
            this.mstDateServFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstDateServFin.Location = new System.Drawing.Point(397, 140);
            this.mstDateServFin.Mask = "00/00/0000";
            this.mstDateServFin.Name = "mstDateServFin";
            this.mstDateServFin.Size = new System.Drawing.Size(156, 30);
            this.mstDateServFin.TabIndex = 58;
            // 
            // ListeService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mstDateServFin);
            this.Controls.Add(this.mstDateServDeb);
            this.Controls.Add(this.lbFinRep);
            this.Controls.Add(this.lbDateReponse);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.tbExecute);
            this.Controls.Add(this.lbExecute);
            this.Controls.Add(this.tbDescriptif);
            this.Controls.Add(this.lbDescriptif);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lbListeService);
            this.Controls.Add(this.btnRetourMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListeService";
            this.Text = "ListeService";
            this.Load += new System.EventHandler(this.ListeService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetourMenu;
        private System.Windows.Forms.Label lbListeService;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.BindingSource bsService;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox tbExecute;
        private System.Windows.Forms.Label lbExecute;
        private System.Windows.Forms.TextBox tbDescriptif;
        private System.Windows.Forms.Label lbDescriptif;
        private System.Windows.Forms.Label lbFinRep;
        private System.Windows.Forms.Label lbDateReponse;
        private System.Windows.Forms.MaskedTextBox mstDateServDeb;
        private System.Windows.Forms.MaskedTextBox mstDateServFin;
    }
}
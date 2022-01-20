
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
            this.btnTous = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbExecute = new System.Windows.Forms.TextBox();
            this.lbExecute = new System.Windows.Forms.Label();
            this.tbDescriptif = new System.Windows.Forms.TextBox();
            this.lbDescriptif = new System.Windows.Forms.Label();
            this.lbFinRep = new System.Windows.Forms.Label();
            this.tbDateDebFin = new System.Windows.Forms.TextBox();
            this.tbDateDebDebut = new System.Windows.Forms.TextBox();
            this.lbDateReponse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourMenu.Location = new System.Drawing.Point(12, 12);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(163, 49);
            this.btnRetourMenu.TabIndex = 0;
            this.btnRetourMenu.Text = "RETOUR AU MENU";
            this.btnRetourMenu.UseVisualStyleBackColor = true;
            this.btnRetourMenu.Click += new System.EventHandler(this.BtnRetourMenu_Click);
            // 
            // lbListeService
            // 
            this.lbListeService.AutoSize = true;
            this.lbListeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListeService.Location = new System.Drawing.Point(283, 18);
            this.lbListeService.Name = "lbListeService";
            this.lbListeService.Size = new System.Drawing.Size(316, 31);
            this.lbListeService.TabIndex = 1;
            this.lbListeService.Text = "LISTE DES SERVICES";
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(25, 398);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(116, 40);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = true;
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
            this.dgvService.Location = new System.Drawing.Point(25, 159);
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.Size = new System.Drawing.Size(750, 233);
            this.dgvService.TabIndex = 5;
            // 
            // btnTous
            // 
            this.btnTous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTous.Location = new System.Drawing.Point(642, 111);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(133, 31);
            this.btnTous.TabIndex = 36;
            this.btnTous.Text = "TOUS";
            this.btnTous.UseVisualStyleBackColor = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(642, 78);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(133, 31);
            this.btnRechercher.TabIndex = 35;
            this.btnRechercher.Text = "RECHERCHER";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(605, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(100, 80);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(149, 26);
            this.tbNumero.TabIndex = 52;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(21, 83);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(73, 20);
            this.lbNumero.TabIndex = 51;
            this.lbNumero.Text = "Numéro :";
            // 
            // tbExecute
            // 
            this.tbExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExecute.Location = new System.Drawing.Point(509, 113);
            this.tbExecute.Name = "tbExecute";
            this.tbExecute.Size = new System.Drawing.Size(116, 26);
            this.tbExecute.TabIndex = 50;
            // 
            // lbExecute
            // 
            this.lbExecute.AutoSize = true;
            this.lbExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExecute.Location = new System.Drawing.Point(428, 116);
            this.lbExecute.Name = "lbExecute";
            this.lbExecute.Size = new System.Drawing.Size(75, 20);
            this.lbExecute.TabIndex = 49;
            this.lbExecute.Text = "Exécuté :";
            // 
            // tbDescriptif
            // 
            this.tbDescriptif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescriptif.Location = new System.Drawing.Point(345, 80);
            this.tbDescriptif.Name = "tbDescriptif";
            this.tbDescriptif.Size = new System.Drawing.Size(280, 26);
            this.tbDescriptif.TabIndex = 46;
            // 
            // lbDescriptif
            // 
            this.lbDescriptif.AutoSize = true;
            this.lbDescriptif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescriptif.Location = new System.Drawing.Point(255, 83);
            this.lbDescriptif.Name = "lbDescriptif";
            this.lbDescriptif.Size = new System.Drawing.Size(84, 20);
            this.lbDescriptif.TabIndex = 45;
            this.lbDescriptif.Text = "Descriptif :";
            // 
            // lbFinRep
            // 
            this.lbFinRep.AutoSize = true;
            this.lbFinRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinRep.Location = new System.Drawing.Point(265, 116);
            this.lbFinRep.Name = "lbFinRep";
            this.lbFinRep.Size = new System.Drawing.Size(28, 20);
            this.lbFinRep.TabIndex = 56;
            this.lbFinRep.Text = "À :";
            // 
            // tbDateDebFin
            // 
            this.tbDateDebFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateDebFin.Location = new System.Drawing.Point(299, 113);
            this.tbDateDebFin.Name = "tbDateDebFin";
            this.tbDateDebFin.Size = new System.Drawing.Size(121, 26);
            this.tbDateDebFin.TabIndex = 55;
            // 
            // tbDateDebDebut
            // 
            this.tbDateDebDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateDebDebut.Location = new System.Drawing.Point(154, 113);
            this.tbDateDebDebut.Name = "tbDateDebDebut";
            this.tbDateDebDebut.Size = new System.Drawing.Size(105, 26);
            this.tbDateDebDebut.TabIndex = 54;
            // 
            // lbDateReponse
            // 
            this.lbDateReponse.AutoSize = true;
            this.lbDateReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateReponse.Location = new System.Drawing.Point(8, 116);
            this.lbDateReponse.Name = "lbDateReponse";
            this.lbDateReponse.Size = new System.Drawing.Size(140, 20);
            this.lbDateReponse.TabIndex = 53;
            this.lbDateReponse.Text = "Date réponse  de :";
            // 
            // ListeService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbFinRep);
            this.Controls.Add(this.tbDateDebFin);
            this.Controls.Add(this.tbDateDebDebut);
            this.Controls.Add(this.lbDateReponse);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.tbExecute);
            this.Controls.Add(this.lbExecute);
            this.Controls.Add(this.tbDescriptif);
            this.Controls.Add(this.lbDescriptif);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTous);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lbListeService);
            this.Controls.Add(this.btnRetourMenu);
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
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox tbExecute;
        private System.Windows.Forms.Label lbExecute;
        private System.Windows.Forms.TextBox tbDescriptif;
        private System.Windows.Forms.Label lbDescriptif;
        private System.Windows.Forms.Label lbFinRep;
        private System.Windows.Forms.TextBox tbDateDebFin;
        private System.Windows.Forms.TextBox tbDateDebDebut;
        private System.Windows.Forms.Label lbDateReponse;
    }
}
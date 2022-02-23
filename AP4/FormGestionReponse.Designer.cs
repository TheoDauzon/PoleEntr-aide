
namespace AP4
{
    partial class FormGestionReponse
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifierM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbService = new System.Windows.Forms.TextBox();
            this.lbService = new System.Windows.Forms.Label();
            this.lbTitre = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.dtpReponse = new System.Windows.Forms.DateTimePicker();
            this.tbAttribuer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(391, 353);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(155, 49);
            this.btnAnnuler.TabIndex = 56;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifierM
            // 
            this.btnModifierM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierM.Location = new System.Drawing.Point(131, 353);
            this.btnModifierM.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierM.Name = "btnModifierM";
            this.btnModifierM.Size = new System.Drawing.Size(155, 49);
            this.btnModifierM.TabIndex = 55;
            this.btnModifierM.Text = "MODIFIER";
            this.btnModifierM.UseVisualStyleBackColor = true;
            this.btnModifierM.Click += new System.EventHandler(this.btnModifierM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Date de réponse :";
            // 
            // tbService
            // 
            this.tbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbService.Location = new System.Drawing.Point(316, 185);
            this.tbService.Margin = new System.Windows.Forms.Padding(4);
            this.tbService.Multiline = true;
            this.tbService.Name = "tbService";
            this.tbService.ReadOnly = true;
            this.tbService.Size = new System.Drawing.Size(330, 30);
            this.tbService.TabIndex = 52;
            this.tbService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbService_KeyPress);
            this.tbService.Leave += new System.EventHandler(this.tbService_Leave);
            // 
            // lbService
            // 
            this.lbService.AutoSize = true;
            this.lbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService.Location = new System.Drawing.Point(126, 188);
            this.lbService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbService.Name = "lbService";
            this.lbService.Size = new System.Drawing.Size(186, 25);
            this.lbService.TabIndex = 51;
            this.lbService.Text = "Numéro du service :";
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(188, 41);
            this.lbTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(422, 38);
            this.lbTitre.TabIndex = 50;
            this.lbTitre.Text = "Modification de la réponse";
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(316, 117);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.ReadOnly = true;
            this.tbNumero.Size = new System.Drawing.Size(330, 30);
            this.tbNumero.TabIndex = 49;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(126, 120);
            this.lbNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(182, 25);
            this.lbNumero.TabIndex = 48;
            this.lbNumero.Text = "Numéro de l\'inscrit :";
            // 
            // dtpReponse
            // 
            this.dtpReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReponse.Location = new System.Drawing.Point(316, 249);
            this.dtpReponse.Name = "dtpReponse";
            this.dtpReponse.Size = new System.Drawing.Size(330, 30);
            this.dtpReponse.TabIndex = 57;
            this.dtpReponse.Leave += new System.EventHandler(this.dtpReponse_Leave);
            // 
            // tbAttribuer
            // 
            this.tbAttribuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAttribuer.Location = new System.Drawing.Point(316, 304);
            this.tbAttribuer.Margin = new System.Windows.Forms.Padding(4);
            this.tbAttribuer.Multiline = true;
            this.tbAttribuer.Name = "tbAttribuer";
            this.tbAttribuer.Size = new System.Drawing.Size(330, 30);
            this.tbAttribuer.TabIndex = 59;
            this.tbAttribuer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAttribuer_KeyPress);
            this.tbAttribuer.Leave += new System.EventHandler(this.tbAttribuer_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 307);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Attribuer :";
            // 
            // FormGestionReponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAttribuer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpReponse);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifierM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbService);
            this.Controls.Add(this.lbService);
            this.Controls.Add(this.lbTitre);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lbNumero);
            this.Name = "FormGestionReponse";
            this.Text = "FormGestionReponse";
            this.Load += new System.EventHandler(this.FormGestionReponse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifierM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbService;
        private System.Windows.Forms.Label lbService;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.DateTimePicker dtpReponse;
        private System.Windows.Forms.TextBox tbAttribuer;
        private System.Windows.Forms.Label label1;
    }
}
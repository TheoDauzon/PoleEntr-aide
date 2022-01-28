
namespace AP4
{
    partial class FormGestionMessage
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
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbTitre = new System.Windows.Forms.Label();
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.lbLibelle = new System.Windows.Forms.Label();
            this.tbTraite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModifierM = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumero
            // 
            this.tbNumero.Enabled = false;
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(406, 116);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.ReadOnly = true;
            this.tbNumero.Size = new System.Drawing.Size(112, 30);
            this.tbNumero.TabIndex = 40;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(216, 119);
            this.lbNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(182, 25);
            this.lbNumero.TabIndex = 39;
            this.lbNumero.Text = "Numéro de l\'inscrit :";
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(214, 38);
            this.lbTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(400, 38);
            this.lbTitre.TabIndex = 41;
            this.lbTitre.Text = "Modification du message";
            // 
            // tbLibelle
            // 
            this.tbLibelle.Enabled = false;
            this.tbLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLibelle.Location = new System.Drawing.Point(303, 156);
            this.tbLibelle.Margin = new System.Windows.Forms.Padding(4);
            this.tbLibelle.Multiline = true;
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(311, 144);
            this.tbLibelle.TabIndex = 43;
            // 
            // lbLibelle
            // 
            this.lbLibelle.AutoSize = true;
            this.lbLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibelle.Location = new System.Drawing.Point(216, 159);
            this.lbLibelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLibelle.Name = "lbLibelle";
            this.lbLibelle.Size = new System.Drawing.Size(79, 25);
            this.lbLibelle.TabIndex = 42;
            this.lbLibelle.Text = "Libellé :";
            // 
            // tbTraite
            // 
            this.tbTraite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTraite.Location = new System.Drawing.Point(303, 308);
            this.tbTraite.Margin = new System.Windows.Forms.Padding(4);
            this.tbTraite.Name = "tbTraite";
            this.tbTraite.Size = new System.Drawing.Size(112, 30);
            this.tbTraite.TabIndex = 45;
            this.tbTraite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTraite_KeyPress);
            this.tbTraite.Leave += new System.EventHandler(this.tbTraite_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Traité :";
            // 
            // btnModifierM
            // 
            this.btnModifierM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierM.Location = new System.Drawing.Point(221, 372);
            this.btnModifierM.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierM.Name = "btnModifierM";
            this.btnModifierM.Size = new System.Drawing.Size(155, 49);
            this.btnModifierM.TabIndex = 46;
            this.btnModifierM.Text = "MODIFIER";
            this.btnModifierM.UseVisualStyleBackColor = true;
            this.btnModifierM.Click += new System.EventHandler(this.btnModifierM_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(459, 372);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(155, 49);
            this.btnAnnuler.TabIndex = 47;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FormGestionMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifierM);
            this.Controls.Add(this.tbTraite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLibelle);
            this.Controls.Add(this.lbLibelle);
            this.Controls.Add(this.lbTitre);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lbNumero);
            this.Name = "FormGestionMessage";
            this.Text = "FormGestionMessage";
            this.Load += new System.EventHandler(this.FormGestionMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.Label lbLibelle;
        private System.Windows.Forms.TextBox tbTraite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModifierM;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox tbNumero;
    }
}
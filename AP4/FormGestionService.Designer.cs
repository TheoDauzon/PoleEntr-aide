
namespace AP4
{
    partial class FormGestionService
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
            this.dtpReponse = new System.Windows.Forms.DateTimePicker();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifierM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhoto = new System.Windows.Forms.TextBox();
            this.lbPhoto = new System.Windows.Forms.Label();
            this.lbTitre = new System.Windows.Forms.Label();
            this.tbDescriptif = new System.Windows.Forms.TextBox();
            this.lbDescriptif = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lbDateDebut = new System.Windows.Forms.Label();
            this.lbPrix = new System.Windows.Forms.Label();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.tbDuree = new System.Windows.Forms.TextBox();
            this.lbDuree = new System.Windows.Forms.Label();
            this.tbRealiser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpReponse
            // 
            this.dtpReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReponse.Location = new System.Drawing.Point(173, 246);
            this.dtpReponse.Name = "dtpReponse";
            this.dtpReponse.Size = new System.Drawing.Size(330, 30);
            this.dtpReponse.TabIndex = 66;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(348, 388);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(155, 49);
            this.btnAnnuler.TabIndex = 65;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifierM
            // 
            this.btnModifierM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierM.Location = new System.Drawing.Point(173, 388);
            this.btnModifierM.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierM.Name = "btnModifierM";
            this.btnModifierM.Size = new System.Drawing.Size(155, 49);
            this.btnModifierM.TabIndex = 64;
            this.btnModifierM.Text = "MODIFIER";
            this.btnModifierM.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Département :";
            // 
            // tbPhoto
            // 
            this.tbPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoto.Location = new System.Drawing.Point(173, 205);
            this.tbPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhoto.Multiline = true;
            this.tbPhoto.Name = "tbPhoto";
            this.tbPhoto.Size = new System.Drawing.Size(521, 30);
            this.tbPhoto.TabIndex = 62;
            // 
            // lbPhoto
            // 
            this.lbPhoto.AutoSize = true;
            this.lbPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoto.Location = new System.Drawing.Point(31, 205);
            this.lbPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhoto.Name = "lbPhoto";
            this.lbPhoto.Size = new System.Drawing.Size(74, 25);
            this.lbPhoto.TabIndex = 61;
            this.lbPhoto.Text = "Photo :";
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(139, 57);
            this.lbTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(372, 38);
            this.lbTitre.TabIndex = 60;
            this.lbTitre.Text = "Modification du service";
            // 
            // tbDescriptif
            // 
            this.tbDescriptif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescriptif.Location = new System.Drawing.Point(173, 119);
            this.tbDescriptif.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescriptif.Multiline = true;
            this.tbDescriptif.Name = "tbDescriptif";
            this.tbDescriptif.ReadOnly = true;
            this.tbDescriptif.Size = new System.Drawing.Size(521, 78);
            this.tbDescriptif.TabIndex = 59;
            // 
            // lbDescriptif
            // 
            this.lbDescriptif.AutoSize = true;
            this.lbDescriptif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescriptif.Location = new System.Drawing.Point(31, 122);
            this.lbDescriptif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescriptif.Name = "lbDescriptif";
            this.lbDescriptif.Size = new System.Drawing.Size(103, 25);
            this.lbDescriptif.TabIndex = 58;
            this.lbDescriptif.Text = "Descriptif :";
            // 
            // cbDepartment
            // 
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(173, 331);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(330, 33);
            this.cbDepartment.TabIndex = 67;
            // 
            // lbDateDebut
            // 
            this.lbDateDebut.AutoSize = true;
            this.lbDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateDebut.Location = new System.Drawing.Point(31, 246);
            this.lbDateDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateDebut.Name = "lbDateDebut";
            this.lbDateDebut.Size = new System.Drawing.Size(118, 25);
            this.lbDateDebut.TabIndex = 68;
            this.lbDateDebut.Text = "Date début :";
            // 
            // lbPrix
            // 
            this.lbPrix.AutoSize = true;
            this.lbPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrix.Location = new System.Drawing.Point(317, 291);
            this.lbPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrix.Name = "lbPrix";
            this.lbPrix.Size = new System.Drawing.Size(56, 25);
            this.lbPrix.TabIndex = 69;
            this.lbPrix.Text = "Prix :";
            // 
            // tbPrix
            // 
            this.tbPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrix.Location = new System.Drawing.Point(381, 288);
            this.tbPrix.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrix.Multiline = true;
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(122, 30);
            this.tbPrix.TabIndex = 70;
            // 
            // tbDuree
            // 
            this.tbDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuree.Location = new System.Drawing.Point(173, 288);
            this.tbDuree.Margin = new System.Windows.Forms.Padding(4);
            this.tbDuree.Multiline = true;
            this.tbDuree.Name = "tbDuree";
            this.tbDuree.Size = new System.Drawing.Size(116, 30);
            this.tbDuree.TabIndex = 72;
            // 
            // lbDuree
            // 
            this.lbDuree.AutoSize = true;
            this.lbDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuree.Location = new System.Drawing.Point(31, 288);
            this.lbDuree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDuree.Name = "lbDuree";
            this.lbDuree.Size = new System.Drawing.Size(140, 25);
            this.lbDuree.TabIndex = 71;
            this.lbDuree.Text = "Durée en jour :";
            // 
            // tbRealiser
            // 
            this.tbRealiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRealiser.Location = new System.Drawing.Point(621, 288);
            this.tbRealiser.Margin = new System.Windows.Forms.Padding(4);
            this.tbRealiser.Multiline = true;
            this.tbRealiser.Name = "tbRealiser";
            this.tbRealiser.Size = new System.Drawing.Size(73, 30);
            this.tbRealiser.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "Réaliser :";
            // 
            // FormGestionService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbRealiser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDuree);
            this.Controls.Add(this.lbDuree);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.lbPrix);
            this.Controls.Add(this.lbDateDebut);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.dtpReponse);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifierM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPhoto);
            this.Controls.Add(this.lbPhoto);
            this.Controls.Add(this.lbTitre);
            this.Controls.Add(this.tbDescriptif);
            this.Controls.Add(this.lbDescriptif);
            this.Name = "FormGestionService";
            this.Text = "FormGestionService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpReponse;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifierM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhoto;
        private System.Windows.Forms.Label lbPhoto;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.TextBox tbDescriptif;
        private System.Windows.Forms.Label lbDescriptif;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lbDateDebut;
        private System.Windows.Forms.Label lbPrix;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.TextBox tbDuree;
        private System.Windows.Forms.Label lbDuree;
        private System.Windows.Forms.TextBox tbRealiser;
        private System.Windows.Forms.Label label1;
    }
}
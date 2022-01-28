
namespace AP4
{
    partial class FormGestionInscrit
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
            this.gbSuperAdmin = new System.Windows.Forms.GroupBox();
            this.rbtnOui = new System.Windows.Forms.RadioButton();
            this.rbtnNon = new System.Windows.Forms.RadioButton();
            this.lbGestionUtilisateur = new System.Windows.Forms.Label();
            this.lbMdp = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPeutPasToutFaire = new System.Windows.Forms.RadioButton();
            this.rbPeutToutFaire = new System.Windows.Forms.RadioButton();
            this.rbPeutPasAccepter = new System.Windows.Forms.RadioButton();
            this.rbPeutAccepter = new System.Windows.Forms.RadioButton();
            this.rbPeutPoster = new System.Windows.Forms.RadioButton();
            this.rbPeutPasPoster = new System.Windows.Forms.RadioButton();
            this.tbCredit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifierM = new System.Windows.Forms.Button();
            this.gbSuperAdmin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSuperAdmin
            // 
            this.gbSuperAdmin.Controls.Add(this.rbtnOui);
            this.gbSuperAdmin.Controls.Add(this.rbtnNon);
            this.gbSuperAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSuperAdmin.Location = new System.Drawing.Point(966, 239);
            this.gbSuperAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.gbSuperAdmin.Name = "gbSuperAdmin";
            this.gbSuperAdmin.Padding = new System.Windows.Forms.Padding(4);
            this.gbSuperAdmin.Size = new System.Drawing.Size(207, 123);
            this.gbSuperAdmin.TabIndex = 31;
            this.gbSuperAdmin.TabStop = false;
            this.gbSuperAdmin.Text = "Super Administrateur";
            // 
            // rbtnOui
            // 
            this.rbtnOui.AutoSize = true;
            this.rbtnOui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOui.Location = new System.Drawing.Point(61, 34);
            this.rbtnOui.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnOui.Name = "rbtnOui";
            this.rbtnOui.Size = new System.Drawing.Size(59, 24);
            this.rbtnOui.TabIndex = 15;
            this.rbtnOui.TabStop = true;
            this.rbtnOui.Text = "OUI";
            this.rbtnOui.UseVisualStyleBackColor = true;
            // 
            // rbtnNon
            // 
            this.rbtnNon.AutoSize = true;
            this.rbtnNon.Checked = true;
            this.rbtnNon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNon.Location = new System.Drawing.Point(61, 79);
            this.rbtnNon.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnNon.Name = "rbtnNon";
            this.rbtnNon.Size = new System.Drawing.Size(67, 24);
            this.rbtnNon.TabIndex = 16;
            this.rbtnNon.TabStop = true;
            this.rbtnNon.Text = "NON";
            this.rbtnNon.UseVisualStyleBackColor = true;
            // 
            // lbGestionUtilisateur
            // 
            this.lbGestionUtilisateur.AutoSize = true;
            this.lbGestionUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGestionUtilisateur.Location = new System.Drawing.Point(364, 23);
            this.lbGestionUtilisateur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGestionUtilisateur.Name = "lbGestionUtilisateur";
            this.lbGestionUtilisateur.Size = new System.Drawing.Size(381, 38);
            this.lbGestionUtilisateur.TabIndex = 27;
            this.lbGestionUtilisateur.Text = "Gestion des utilisateurs";
            // 
            // lbMdp
            // 
            this.lbMdp.AutoSize = true;
            this.lbMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMdp.Location = new System.Drawing.Point(-274, 361);
            this.lbMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMdp.Name = "lbMdp";
            this.lbMdp.Size = new System.Drawing.Size(120, 20);
            this.lbMdp.TabIndex = 21;
            this.lbMdp.Text = "Mot de passe :";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(-210, 294);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(61, 20);
            this.lbEmail.TabIndex = 20;
            this.lbEmail.Text = "Email :";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenom.Location = new System.Drawing.Point(-228, 220);
            this.lbPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(77, 20);
            this.lbPrenom.TabIndex = 19;
            this.lbPrenom.Text = "Prénom :";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(-204, 145);
            this.lbNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(54, 20);
            this.lbNom.TabIndex = 18;
            this.lbNom.Text = "Nom :";
            // 
            // tbMdp
            // 
            this.tbMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMdp.Location = new System.Drawing.Point(147, 324);
            this.tbMdp.Margin = new System.Windows.Forms.Padding(4);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(299, 30);
            this.tbMdp.TabIndex = 39;
            this.tbMdp.UseSystemPasswordChar = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(147, 250);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(299, 30);
            this.tbEmail.TabIndex = 38;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(147, 168);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(299, 30);
            this.tbPrenom.TabIndex = 37;
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(147, 91);
            this.tbNom.Margin = new System.Windows.Forms.Padding(4);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(299, 30);
            this.tbNom.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 327);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mot de passe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nom :";
            // 
            // tbAdresse
            // 
            this.tbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresse.Location = new System.Drawing.Point(644, 250);
            this.tbAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(315, 30);
            this.tbAdresse.TabIndex = 43;
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTel.Location = new System.Drawing.Point(643, 91);
            this.tbTel.Margin = new System.Windows.Forms.Padding(4);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(315, 30);
            this.tbTel.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(544, 253);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Adresse :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(522, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Téléphone :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPeutPasToutFaire);
            this.groupBox1.Controls.Add(this.rbPeutToutFaire);
            this.groupBox1.Controls.Add(this.rbPeutPasAccepter);
            this.groupBox1.Controls.Add(this.rbPeutAccepter);
            this.groupBox1.Controls.Add(this.rbPeutPoster);
            this.groupBox1.Controls.Add(this.rbPeutPasPoster);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(965, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(207, 218);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statut";
            // 
            // rbPeutPasToutFaire
            // 
            this.rbPeutPasToutFaire.AutoSize = true;
            this.rbPeutPasToutFaire.Location = new System.Drawing.Point(12, 182);
            this.rbPeutPasToutFaire.Name = "rbPeutPasToutFaire";
            this.rbPeutPasToutFaire.Size = new System.Drawing.Size(135, 24);
            this.rbPeutPasToutFaire.TabIndex = 20;
            this.rbPeutPasToutFaire.Text = "Peut rien faire";
            this.rbPeutPasToutFaire.UseVisualStyleBackColor = true;
            // 
            // rbPeutToutFaire
            // 
            this.rbPeutToutFaire.AutoSize = true;
            this.rbPeutToutFaire.Checked = true;
            this.rbPeutToutFaire.Location = new System.Drawing.Point(12, 152);
            this.rbPeutToutFaire.Name = "rbPeutToutFaire";
            this.rbPeutToutFaire.Size = new System.Drawing.Size(135, 24);
            this.rbPeutToutFaire.TabIndex = 19;
            this.rbPeutToutFaire.TabStop = true;
            this.rbPeutToutFaire.Text = "Peut tout faire";
            this.rbPeutToutFaire.UseVisualStyleBackColor = true;
            // 
            // rbPeutPasAccepter
            // 
            this.rbPeutPasAccepter.AutoSize = true;
            this.rbPeutPasAccepter.Location = new System.Drawing.Point(12, 122);
            this.rbPeutPasAccepter.Name = "rbPeutPasAccepter";
            this.rbPeutPasAccepter.Size = new System.Drawing.Size(190, 24);
            this.rbPeutPasAccepter.TabIndex = 18;
            this.rbPeutPasAccepter.Text = "Ne peut pas accepter";
            this.rbPeutPasAccepter.UseVisualStyleBackColor = true;
            // 
            // rbPeutAccepter
            // 
            this.rbPeutAccepter.AutoSize = true;
            this.rbPeutAccepter.Location = new System.Drawing.Point(12, 92);
            this.rbPeutAccepter.Name = "rbPeutAccepter";
            this.rbPeutAccepter.Size = new System.Drawing.Size(134, 24);
            this.rbPeutAccepter.TabIndex = 17;
            this.rbPeutAccepter.Text = "Peut accepter";
            this.rbPeutAccepter.UseVisualStyleBackColor = true;
            // 
            // rbPeutPoster
            // 
            this.rbPeutPoster.AutoSize = true;
            this.rbPeutPoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPeutPoster.Location = new System.Drawing.Point(12, 28);
            this.rbPeutPoster.Margin = new System.Windows.Forms.Padding(4);
            this.rbPeutPoster.Name = "rbPeutPoster";
            this.rbPeutPoster.Size = new System.Drawing.Size(116, 24);
            this.rbPeutPoster.TabIndex = 15;
            this.rbPeutPoster.Text = "Peut poster";
            this.rbPeutPoster.UseVisualStyleBackColor = true;
            // 
            // rbPeutPasPoster
            // 
            this.rbPeutPasPoster.AutoSize = true;
            this.rbPeutPasPoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPeutPasPoster.Location = new System.Drawing.Point(12, 60);
            this.rbPeutPasPoster.Margin = new System.Windows.Forms.Padding(4);
            this.rbPeutPasPoster.Name = "rbPeutPasPoster";
            this.rbPeutPasPoster.Size = new System.Drawing.Size(172, 24);
            this.rbPeutPasPoster.TabIndex = 16;
            this.rbPeutPasPoster.Text = "Ne peut pas poster";
            this.rbPeutPasPoster.UseVisualStyleBackColor = true;
            // 
            // tbCredit
            // 
            this.tbCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCredit.Location = new System.Drawing.Point(644, 324);
            this.tbCredit.Margin = new System.Windows.Forms.Padding(4);
            this.tbCredit.Name = "tbCredit";
            this.tbCredit.Size = new System.Drawing.Size(315, 30);
            this.tbCredit.TabIndex = 46;
            this.tbCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCredit_KeyPress);
            this.tbCredit.Leave += new System.EventHandler(this.tbCredit_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(565, 327);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Crédit :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "Date de naissance :";
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNaissance.Location = new System.Drawing.Point(644, 166);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(315, 30);
            this.dtpNaissance.TabIndex = 49;
            this.dtpNaissance.Leave += new System.EventHandler(this.dtpNaissance_Leave);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(643, 384);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(263, 49);
            this.btnAnnuler.TabIndex = 51;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifierM
            // 
            this.btnModifierM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierM.Location = new System.Drawing.Point(183, 384);
            this.btnModifierM.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierM.Name = "btnModifierM";
            this.btnModifierM.Size = new System.Drawing.Size(263, 49);
            this.btnModifierM.TabIndex = 50;
            this.btnModifierM.Text = "MODIFIER/AJOUTER";
            this.btnModifierM.UseVisualStyleBackColor = true;
            this.btnModifierM.Click += new System.EventHandler(this.btnModifierM_Click);
            // 
            // FormGestionInscrit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1186, 446);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifierM);
            this.Controls.Add(this.dtpNaissance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCredit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbSuperAdmin);
            this.Controls.Add(this.lbGestionUtilisateur);
            this.Controls.Add(this.lbMdp);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.lbNom);
            this.Name = "FormGestionInscrit";
            this.Text = "FormGestionInscrit";
            this.Load += new System.EventHandler(this.FormGestionInscrit_Load);
            this.gbSuperAdmin.ResumeLayout(false);
            this.gbSuperAdmin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSuperAdmin;
        private System.Windows.Forms.RadioButton rbtnOui;
        private System.Windows.Forms.RadioButton rbtnNon;
        private System.Windows.Forms.Label lbGestionUtilisateur;
        private System.Windows.Forms.Label lbMdp;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPeutPoster;
        private System.Windows.Forms.RadioButton rbPeutPasPoster;
        private System.Windows.Forms.TextBox tbCredit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.RadioButton rbPeutPasToutFaire;
        private System.Windows.Forms.RadioButton rbPeutToutFaire;
        private System.Windows.Forms.RadioButton rbPeutPasAccepter;
        private System.Windows.Forms.RadioButton rbPeutAccepter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifierM;
    }
}
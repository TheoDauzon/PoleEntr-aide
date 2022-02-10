
namespace AP4
{
    partial class ListeStatistique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeStatistique));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbListeReponse = new System.Windows.Forms.Label();
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.BtnNbRepTheme = new System.Windows.Forms.Button();
            this.BtnNb = new System.Windows.Forms.Button();
            this.BtnServiceTheme = new System.Windows.Forms.Button();
            this.BtnNbInscrit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(821, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // lbListeReponse
            // 
            this.lbListeReponse.AutoSize = true;
            this.lbListeReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListeReponse.ForeColor = System.Drawing.Color.Black;
            this.lbListeReponse.Location = new System.Drawing.Point(394, 43);
            this.lbListeReponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListeReponse.Name = "lbListeReponse";
            this.lbListeReponse.Size = new System.Drawing.Size(278, 39);
            this.lbListeReponse.TabIndex = 46;
            this.lbListeReponse.Text = "STATISTIQUES";
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourMenu.ForeColor = System.Drawing.Color.Black;
            this.btnRetourMenu.Location = new System.Drawing.Point(13, 22);
            this.btnRetourMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(217, 60);
            this.btnRetourMenu.TabIndex = 45;
            this.btnRetourMenu.Text = "RETOUR AU MENU";
            this.btnRetourMenu.UseVisualStyleBackColor = true;
            this.btnRetourMenu.Click += new System.EventHandler(this.btnRetourMenu_Click);
            // 
            // BtnNbRepTheme
            // 
            this.BtnNbRepTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNbRepTheme.Location = new System.Drawing.Point(403, 162);
            this.BtnNbRepTheme.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNbRepTheme.Name = "BtnNbRepTheme";
            this.BtnNbRepTheme.Size = new System.Drawing.Size(269, 95);
            this.BtnNbRepTheme.TabIndex = 51;
            this.BtnNbRepTheme.Text = "NOMBRE DE REPONSES AUX SERVICES";
            this.BtnNbRepTheme.UseVisualStyleBackColor = true;
            this.BtnNbRepTheme.Click += new System.EventHandler(this.BtnNbRepTheme_Click);
            // 
            // BtnNb
            // 
            this.BtnNb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNb.Location = new System.Drawing.Point(235, 326);
            this.BtnNb.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNb.Name = "BtnNb";
            this.BtnNb.Size = new System.Drawing.Size(269, 95);
            this.BtnNb.TabIndex = 50;
            this.BtnNb.Text = "NOMBRE DE SERVICES SUR LA PLATEFORME";
            this.BtnNb.UseVisualStyleBackColor = true;
            this.BtnNb.Click += new System.EventHandler(this.BtnNb_Click);
            // 
            // BtnServiceTheme
            // 
            this.BtnServiceTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServiceTheme.Location = new System.Drawing.Point(55, 162);
            this.BtnServiceTheme.Margin = new System.Windows.Forms.Padding(4);
            this.BtnServiceTheme.Name = "BtnServiceTheme";
            this.BtnServiceTheme.Size = new System.Drawing.Size(269, 95);
            this.BtnServiceTheme.TabIndex = 49;
            this.BtnServiceTheme.Text = "NOMBRE DE SERVICES PAR THEME";
            this.BtnServiceTheme.UseVisualStyleBackColor = true;
            this.BtnServiceTheme.Click += new System.EventHandler(this.BtnServiceTheme_Click);
            // 
            // BtnNbInscrit
            // 
            this.BtnNbInscrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNbInscrit.Location = new System.Drawing.Point(591, 326);
            this.BtnNbInscrit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNbInscrit.Name = "BtnNbInscrit";
            this.BtnNbInscrit.Size = new System.Drawing.Size(269, 95);
            this.BtnNbInscrit.TabIndex = 48;
            this.BtnNbInscrit.Text = "NOMBRE D\'INSCRITS SUR LA PLATEFORME";
            this.BtnNbInscrit.UseVisualStyleBackColor = true;
            this.BtnNbInscrit.Click += new System.EventHandler(this.BtnNbInscrit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(748, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 95);
            this.button1.TabIndex = 52;
            this.button1.Text = "NOMBRE DE MESSAGES D\'AIDE MOYEN PAR INSCRIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListeStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1068, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnNbRepTheme);
            this.Controls.Add(this.BtnNb);
            this.Controls.Add(this.BtnServiceTheme);
            this.Controls.Add(this.BtnNbInscrit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbListeReponse);
            this.Controls.Add(this.btnRetourMenu);
            this.Name = "ListeStatistique";
            this.Text = "ListeStatistique";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbListeReponse;
        private System.Windows.Forms.Button btnRetourMenu;
        private System.Windows.Forms.Button BtnNbRepTheme;
        private System.Windows.Forms.Button BtnNb;
        private System.Windows.Forms.Button BtnServiceTheme;
        private System.Windows.Forms.Button BtnNbInscrit;
        private System.Windows.Forms.Button button1;
    }
}
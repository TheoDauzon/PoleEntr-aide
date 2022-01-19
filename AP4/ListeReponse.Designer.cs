
namespace AP4
{
    partial class ListeReponse
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
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.lbListeReponse = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvReponse = new System.Windows.Forms.DataGridView();
            this.bsReponse = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReponse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourMenu.ForeColor = System.Drawing.Color.Black;
            this.btnRetourMenu.Location = new System.Drawing.Point(12, 12);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(163, 49);
            this.btnRetourMenu.TabIndex = 0;
            this.btnRetourMenu.Text = "RETOUR AU MENU";
            this.btnRetourMenu.UseVisualStyleBackColor = true;
            this.btnRetourMenu.Click += new System.EventHandler(this.BtnRetourMenu_Click);
            // 
            // lbListeReponse
            // 
            this.lbListeReponse.AutoSize = true;
            this.lbListeReponse.Font = new System.Drawing.Font("Liberation Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListeReponse.ForeColor = System.Drawing.Color.Black;
            this.lbListeReponse.Location = new System.Drawing.Point(283, 18);
            this.lbListeReponse.Name = "lbListeReponse";
            this.lbListeReponse.Size = new System.Drawing.Size(303, 30);
            this.lbListeReponse.TabIndex = 1;
            this.lbListeReponse.Text = "LISTE DES RÉPONSES";
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.Location = new System.Drawing.Point(25, 398);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(116, 40);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // dgvReponse
            // 
            this.dgvReponse.AllowUserToAddRows = false;
            this.dgvReponse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReponse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReponse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReponse.Location = new System.Drawing.Point(25, 159);
            this.dgvReponse.Name = "dgvReponse";
            this.dgvReponse.ReadOnly = true;
            this.dgvReponse.Size = new System.Drawing.Size(750, 233);
            this.dgvReponse.TabIndex = 5;
            // 
            // ListeReponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReponse);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lbListeReponse);
            this.Controls.Add(this.btnRetourMenu);
            this.Name = "ListeReponse";
            this.Text = "ListeReponse";
            this.Load += new System.EventHandler(this.ListeReponse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReponse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetourMenu;
        private System.Windows.Forms.Label lbListeReponse;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView dgvReponse;
        private System.Windows.Forms.BindingSource bsReponse;
    }
}
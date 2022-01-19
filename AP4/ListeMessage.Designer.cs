
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
            this.dgvMessage = new System.Windows.Forms.DataGridView();
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.btnModifierMessage = new System.Windows.Forms.Button();
            this.lbTitre = new System.Windows.Forms.Label();
            this.bsMessage = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMessage
            // 
            this.dgvMessage.AllowUserToAddRows = false;
            this.dgvMessage.AllowUserToDeleteRows = false;
            this.dgvMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessage.Location = new System.Drawing.Point(43, 196);
            this.dgvMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMessage.Name = "dgvMessage";
            this.dgvMessage.ReadOnly = true;
            this.dgvMessage.RowHeadersWidth = 51;
            this.dgvMessage.Size = new System.Drawing.Size(1000, 287);
            this.dgvMessage.TabIndex = 12;
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourMenu.Location = new System.Drawing.Point(25, 15);
            this.btnRetourMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnModifierMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifierMessage.Name = "btnModifierMessage";
            this.btnModifierMessage.Size = new System.Drawing.Size(155, 49);
            this.btnModifierMessage.TabIndex = 9;
            this.btnModifierMessage.Text = "MODIFIER";
            this.btnModifierMessage.UseVisualStyleBackColor = true;
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(387, 22);
            this.lbTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(335, 39);
            this.lbTitre.TabIndex = 7;
            this.lbTitre.Text = "Liste des messages";
            // 
            // ListeMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvMessage);
            this.Controls.Add(this.btnRetourMenu);
            this.Controls.Add(this.btnModifierMessage);
            this.Controls.Add(this.lbTitre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListeMessage";
            this.Text = "ListeMessage";
            this.Load += new System.EventHandler(this.ListeMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMessage;
        private System.Windows.Forms.Button btnRetourMenu;
        private System.Windows.Forms.Button btnModifierMessage;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.BindingSource bsMessage;
    }
}
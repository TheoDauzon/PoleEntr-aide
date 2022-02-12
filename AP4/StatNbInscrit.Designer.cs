
namespace AP4
{
    partial class StatNbInscrit
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnServiceTheme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            series1.Legend = "Legend1";
            series1.Name = "Nombre d\'inscrits";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1067, 554);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // BtnServiceTheme
            // 
            this.BtnServiceTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServiceTheme.Location = new System.Drawing.Point(900, 430);
            this.BtnServiceTheme.Margin = new System.Windows.Forms.Padding(4);
            this.BtnServiceTheme.Name = "BtnServiceTheme";
            this.BtnServiceTheme.Size = new System.Drawing.Size(114, 63);
            this.BtnServiceTheme.TabIndex = 51;
            this.BtnServiceTheme.Text = "RETOUR";
            this.BtnServiceTheme.UseVisualStyleBackColor = true;
            this.BtnServiceTheme.Click += new System.EventHandler(this.BtnServiceTheme_Click);
            // 
            // StatNbInscrit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnServiceTheme);
            this.Controls.Add(this.chart1);
            this.Name = "StatNbInscrit";
            this.Text = "StatNbInscrit";
            this.Load += new System.EventHandler(this.StatNbInscrit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BtnServiceTheme;
    }
}
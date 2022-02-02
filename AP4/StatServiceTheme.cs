using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP4
{
    public partial class StatServiceTheme : Form
    {
        public StatServiceTheme()
        {
            InitializeComponent();
        }

        private void StatServiceTheme_Load(object sender, EventArgs e)
        {
            // titre
            chart1.Titles.Add("titre1").Text = "Services les plus proposés";
            chart1.Titles[0].Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);

            // série
            chart1.Series[0].Points.AddXY("Dell", 20);
            chart1.Series[0].Points.AddXY("Dell", 20);
            chart1.Series[0].Points.AddXY("Dell", 20);
            chart1.Series[0].Points.AddXY("Dell", 20);
            chart1.Series[0].Points.AddXY("Dell", 20);
        }

        private void BtnServiceTheme_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

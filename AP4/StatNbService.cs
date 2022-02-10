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
    public partial class StatNbService : Form
    {
        public StatNbService()
        {
            InitializeComponent();
        }

        private void BtnServiceTheme_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatNbService_Load(object sender, EventArgs e)
        {
            // titre
            chart1.Titles.Add("titre1").Text = "Nombre de services pubié sur plateforme au cours du temps";
            chart1.Titles[0].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);

            int nbService = Modele.ListeService().Count;

            // série
            chart1.Series[0].Points.AddXY(DateTime.Now, nbService);
        }
    }
}

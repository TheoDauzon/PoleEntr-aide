using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP4
{
    public partial class StatNbInscrit : Form
    {
        public StatNbInscrit()
        {
            InitializeComponent();
        }

        int nbInscrit = Modele.ListeInscrit().Count;
        private void BtnServiceTheme_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatNbInscrit_Load(object sender, EventArgs e)
        {
            // titre
            chart1.Titles.Add("titre1").Text = "Nombre d'inscrits à la plateforme au cours du temps";
            chart1.Titles[0].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);

            // récupération du nombre d'inscrits
            int nbInscrit = Modele.ListeInscrit().Count;

            // série
            chart1.Series[0].Points.AddXY("24-01-2022", nbInscrit);

            // récupération de la date du dernier ajout dans le graphique
            DateTime dateDernierGraphique = Convert.ToDateTime(chart1.Series[0].Points.Last().AxisLabel);
            label1.Text = dateDernierGraphique.ToString("dd-MM-yyyy");

            if (DateTime.Now.Day - dateDernierGraphique.Day <= 7)
            {
                chart1.Series[0].Points.AddXY(DateTime.Now.ToString("dd-MM-yyyy"), nbInscrit);
            }

        }
    }
}

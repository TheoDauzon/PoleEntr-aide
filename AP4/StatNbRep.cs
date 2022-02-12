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
    public partial class StatNbRep : Form
    {
        public StatNbRep()
        {
            InitializeComponent();
        }

        private void BtnServiceTheme_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatNbRep_Load(object sender, EventArgs e)
        {
            // titre
            chart1.Titles.Add("titre1").Text = "Nombre de réponses total pour tous les services publié sur la plateforme au cours du temps";
            chart1.Titles[0].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);

            int nbRep = Modele.ListeReponse().Count;

            // série
            for (int i = 0; i < Modele.maConnexion.nbReponsesTemps.Count(); i++) 
            {
                chart1.Series[0].Points.AddXY(Modele.ListeReponsesTemps()[i].DATENB.ToString("dd-MM-yyyy"), Modele.ListeReponsesTemps()[i].NBREPONSESTEMPS1);
            }

            // récupération de la date du dernier ajout dans le graphique
            DateTime dateDernierGraphique = Convert.ToDateTime(chart1.Series[0].Points.Last().AxisLabel);

            if (DateTime.Now.Day - dateDernierGraphique.Day >= 7)
            {
                Modele.ReponseTemps(DateTime.Now.ToString("dd-MM-yyyy"), nbRep);
                chart1.Series[0].Points.AddXY(DateTime.Now.ToString("dd-MM-yyyy"), nbRep);
            }
        }
    }
}

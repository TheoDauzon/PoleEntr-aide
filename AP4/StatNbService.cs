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
            chart1.Titles.Add("titre1").Text = "Nombre de services publiés sur la plateforme au cours du temps";
            chart1.Titles[0].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);

            int nbService = Modele.ListeService().Count;

            // série
            for (int i = 0; i < Modele.maConnexion.nbServicesTemps.Count(); i++)
            {
                chart1.Series[0].Points.AddXY(Modele.ListeServicesTemps()[i].DATENB.ToString("dd-MM-yyyy"), Modele.ListeServicesTemps()[i].NBSERVICESTEMPS1);
            }

            // récupération de la date du dernier ajout dans le graphique
            DateTime dateDernierGraphique = Convert.ToDateTime(chart1.Series[0].Points.Last().AxisLabel);

            if (DateTime.Now.Day - dateDernierGraphique.Day >= 7)
            {
                Modele.ServiceTemps(DateTime.Now.ToString("dd-MM-yyyy"), nbService);
                chart1.Series[0].Points.AddXY(DateTime.Now.ToString("dd-MM-yyyy"), nbService);
            }
        }
    }
}

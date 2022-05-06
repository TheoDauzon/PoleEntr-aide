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
    public partial class StatNbMessage : Form
    {
        public StatNbMessage()
        {
            InitializeComponent();
        }

        private void BtnServiceTheme_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatNbMessage_Load(object sender, EventArgs e)
        {
            // titre
            chart1.Titles.Add("titre1").Text = "Nombre de messages d'aide moyen envoyé par les inscrits au cours du temps";
            chart1.Titles[0].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);

            int nbMessage = Modele.ListeMessage().Count;
            int nbInscrit = Modele.ListeInscrit().Count;

            // série
            for (int i = 0; i < Modele.maConnexion.nbMessagesTemps.Count(); i++)
            {
                chart1.Series[0].Points.AddXY(Modele.ListeMessagesTemps()[i].DATENB.ToString("dd-MM-yyyy"), Modele.ListeMessagesTemps()[i].NBMESSAGESTEMPS1);
            }

            // récupération de la date du dernier ajout dans le graphique
            DateTime dateDernierGraphique = Convert.ToDateTime(chart1.Series[0].Points.Last().AxisLabel);
            DateTime jourJ = DateTime.Now;
            TimeSpan jour = jourJ.Subtract(dateDernierGraphique);

            if (jour.TotalDays >= 7)
            {
                Modele.MessageTemps(DateTime.Now.ToString("dd-MM-yyyy"), ((double)nbMessage /nbInscrit));
                chart1.Series[0].Points.AddXY(DateTime.Now.ToString("dd-MM-yyyy"), ((double)nbMessage /nbInscrit));
            }

        }
    }
}

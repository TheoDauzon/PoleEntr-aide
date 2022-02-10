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
            chart1.Titles.Add("titre1").Text = "Services les plus proposés par thème";
            chart1.Titles[0].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);

            int nbServiceTransport = Modele.ListeService().Count;
            int nbServiceCourse = Modele.ListeService().Count;
            int nbServiceFormation = Modele.ListeService().Count;
            int nbServiceLoisirs = Modele.ListeService().Count;
            int nbServiceTachesMenageres = Modele.ListeService().Count;

            // série
            chart1.Series[0].Points.AddXY("TRANSPORT", nbServiceTransport);
            chart1.Series[0].Points.AddXY("COURSE", nbServiceCourse);
            chart1.Series[0].Points.AddXY("FORMATION", nbServiceFormation);
            chart1.Series[0].Points.AddXY("LOISIRS", nbServiceLoisirs);
            chart1.Series[0].Points.AddXY("TACHES MENAGERES", nbServiceTachesMenageres);
        }

        private void BtnServiceTheme_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

            int nbService = Modele.ListeService().Count;
            int nbServiceTransport = Modele.ListeTransport().Count;
            int nbServiceCourse = Modele.ListeCourse().Count;
            int nbServiceFormation = Modele.ListeFormation().Count;
            int nbServiceLoisirs = Modele.ListeLoisirs().Count;
            int nbServiceTachesMenageres = Modele.ListeTache_Menagere().Count;

            // série
            chart1.Series[0].Points.AddXY("TRANSPORT", ((double)nbServiceTransport / nbService * 100));
            chart1.Series[0].Points.AddXY("COURSE", ((double)nbServiceCourse / nbService * 100));
            chart1.Series[0].Points.AddXY("FORMATION", ((double)nbServiceFormation / nbService * 100));
            chart1.Series[0].Points.AddXY("LOISIRS", ((double)nbServiceLoisirs / nbService * 100));
            chart1.Series[0].Points.AddXY("TACHES MENAGERES", ((double)nbServiceTachesMenageres / nbService * 100));
        }

        private void BtnServiceTheme_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

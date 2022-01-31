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
    public partial class Menu : Form
    {
        ListeInscrit LI;
        ListeService LS;
        ListeReponse LR;
        ListeMessage LM;
        ListeStatistique LST;
        readonly inscrit unInscrit;
        public Menu(inscrit unInscrit)
        {
            InitializeComponent();
            this.unInscrit = unInscrit;
        }

        private void BtnGestionInscrits_Click(object sender, EventArgs e)
        {
            LI = new ListeInscrit();
            LI.Show();
        }

        private void BtnGestionServices_Click(object sender, EventArgs e)
        {
            LS = new ListeService();
            LS.Show();
        }

        private void BtnGestionReponses_Click(object sender, EventArgs e)
        {
            LR = new ListeReponse();
            LR.Show();
        }

        private void BtnGestionMessages_Click(object sender, EventArgs e)
        {
            LM = new ListeMessage();
            LM.Show();
        }

        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbNom.Text = unInscrit.NOMINSCRIT;
            lbPrenom.Text = unInscrit.PRENOMINSCRIT;

        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            LST = new ListeStatistique();
            LST.Show();
        }
    }
}

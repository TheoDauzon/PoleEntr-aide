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
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnGestionInscrits_Click(object sender, EventArgs e)
        {
            LI = new ListeInscrit();
            LI.Show();
        }

        private void btnGestionServices_Click(object sender, EventArgs e)
        {
            LS = new ListeService();
            LS.Show();
        }

        private void btnGestionReponses_Click(object sender, EventArgs e)
        {
            LR = new ListeReponse();
            LR.Show();
        }

        private void btnGestionMessages_Click(object sender, EventArgs e)
        {
            LM = new ListeMessage();
            LM.Show();
        }
    }
}

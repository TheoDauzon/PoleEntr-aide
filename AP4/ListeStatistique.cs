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
    public partial class ListeStatistique : Form
    {
        StatServiceTheme SST;
        StatNbInscrit SNI;
        StatNbRep SNR;
        StatNbService SNP;
        StatNbMessage SNM;
        public ListeStatistique()
        {
            InitializeComponent(); 
        }

        private void btnRetourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnServiceTheme_Click(object sender, EventArgs e)
        {
            SST = new StatServiceTheme();
            SST.Show();
        }

        private void BtnNbInscrit_Click(object sender, EventArgs e)
        {
            SNI = new StatNbInscrit();
            SNI.Show();
        }

        private void BtnNbRepTheme_Click(object sender, EventArgs e)
        {
            SNR = new StatNbRep();
            SNR.Show();
        }

        private void BtnNb_Click(object sender, EventArgs e)
        {
            SNP = new StatNbService();
            SNP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SNM = new StatNbMessage();
            SNM.Show();
        }
    }
}

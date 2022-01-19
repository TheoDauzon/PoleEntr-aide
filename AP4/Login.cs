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
    public partial class Login : Form
    {
        Menu M;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            inscrit unInscrit = Modele.VerifInscrit(tbMail.Text, tbMdp.Text);
            if (unInscrit != null)
            {
                M = new Menu(unInscrit);
                M.Show();
                tbMail.Text = "";
                tbMdp.Text = "";
            }
            else
            {
                MessageBox.Show("Adresse mail ou mot de passe incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

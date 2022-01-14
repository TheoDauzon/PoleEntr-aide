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

    public partial class ListeInscrit : Form
    {
        public ListeInscrit()
        {
            InitializeComponent();
        }

        private void ListeInscrit_Load(object sender, EventArgs e)
        {
            bsInscrit.DataSource = Modele.listeInscrit(); // appel de la méthode listeClients
            dgvInscrit.DataSource = bsInscrit;
            dgvInscrit.Columns[11].Visible = false;
            dgvInscrit.Columns[12].Visible = false;
            dgvInscrit.Columns[13].Visible = false;
            dgvInscrit.Columns[14].Visible = false;
        }

        private void BtnRetourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

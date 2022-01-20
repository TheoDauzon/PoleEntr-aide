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
    public partial class ListeReponse : Form
    {
        public ListeReponse()
        {
            InitializeComponent();
        }

        private void BtnRetourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListeReponse_Load(object sender, EventArgs e)
        {
            bsReponse.DataSource = Modele.ListeReponse(); // appel de la méthode listeClients
            dgvReponse.DataSource = bsReponse;
            dgvReponse.Columns[3].Visible = false;
            dgvReponse.Columns[4].Visible = false;
        }
    }
}

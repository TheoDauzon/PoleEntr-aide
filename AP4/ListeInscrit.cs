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
            bsInscrits.DataSource = Modele.listeInscrit(); // appel de la méthode listeClients
            dgvInscrits.DataSource = bsInscrits;
        }
    }
}

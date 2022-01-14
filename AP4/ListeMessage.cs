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
    public partial class ListeMessage : Form
    {
        public ListeMessage()
        {
            InitializeComponent();
        }

        private void BtnRetourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListeMessage_Load(object sender, EventArgs e)
        {
            bsMessage.DataSource = Modele.listeMessage(); // appel de la méthode listeClients
            dgvMessage.DataSource = bsMessage;
            dgvMessage.Columns[3].Visible = false;
        }
    }
}

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
    public partial class ListeService : Form
    {
        public ListeService()
        {
            InitializeComponent();
        }

        private void BtnRetourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListeService_Load(object sender, EventArgs e)
        {
            bsService.DataSource = Modele.listeService(); // appel de la méthode listeClients
            dgvService.DataSource = bsService;
            dgvService.Columns[11].Visible = false;
            dgvService.Columns[12].Visible = false;
            dgvService.Columns[13].Visible = false;
            dgvService.Columns[14].Visible = false;
            dgvService.Columns[15].Visible = false;
            dgvService.Columns[16].Visible = false;
            dgvService.Columns[17].Visible = false;
            dgvService.Columns[18].Visible = false;
            dgvService.Columns[19].Visible = false;
        }
    }
}

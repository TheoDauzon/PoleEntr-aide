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
            bsService.DataSource = Modele.ListeService(); // appel de la méthode listeClients
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

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string num = tbNumero.Text;
            string descriptif = tbDescriptif.Text;
            string execute = tbExecute.Text;
            DateTime dateServDeb;
            DateTime dateServFin;
            if (mstDateServDeb.MaskFull==true && mstDateServFin.MaskFull == false)
            {
                dateServDeb = Convert.ToDateTime(mstDateServDeb.Text);
                dgvService.DataSource = (Modele.ListeService()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.DESCRIPTIFSERVICE.StartsWith(descriptif) && k.REALISER.ToString().StartsWith(execute) && k.DATEDEPOT >= dateServDeb).Select(p => new { IDSERVICE = p.IDSERVICE, IDINSCRIT = p.IDINSCRIT, IDDEPARTEMENT = p.IDINSCRIT, IDTYPE = p.IDTYPE, DESCRIPTIFSERVICE = p.DESCRIPTIFSERVICE, PHOTO = p.PHOTO, DATEDEBUT = p.DATEDEBUT, PRIX = p.PHOTO, DATEDEPOT = p.DATEDEPOT, REALISER = p.REALISER }).ToList();
            }
            else if (mstDateServFin.MaskFull == true && mstDateServDeb.MaskFull == false)
            {
                dateServFin = Convert.ToDateTime(mstDateServFin.Text);
                dgvService.DataSource = (Modele.ListeService()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.DESCRIPTIFSERVICE.StartsWith(descriptif) && k.REALISER.ToString().StartsWith(execute) && k.DATEDEPOT >= dateServFin).Select(p => new { IDSERVICE = p.IDSERVICE, IDINSCRIT = p.IDINSCRIT, IDDEPARTEMENT = p.IDINSCRIT, IDTYPE = p.IDTYPE, DESCRIPTIFSERVICE = p.DESCRIPTIFSERVICE, PHOTO = p.PHOTO, DATEDEBUT = p.DATEDEBUT, PRIX = p.PHOTO, DATEDEPOT = p.DATEDEPOT, REALISER = p.REALISER }).ToList();
            }
            else if (mstDateServFin.MaskFull == true && mstDateServDeb.MaskFull == true)
            {
                dateServDeb = Convert.ToDateTime(mstDateServDeb.Text);
                dateServFin = Convert.ToDateTime(mstDateServDeb.Text);
                dgvService.DataSource = (Modele.ListeService()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.DESCRIPTIFSERVICE.StartsWith(descriptif) && k.REALISER.ToString().StartsWith(execute) && k.DATEDEPOT <= dateServFin && k.DATEDEPOT >= dateServDeb).Select(p => new {IDSERVICE = p.IDSERVICE,  IDINSCRIT = p.IDINSCRIT, IDDEPARTEMENT = p.IDINSCRIT, IDTYPE = p.IDTYPE, DESCRIPTIFSERVICE = p.DESCRIPTIFSERVICE, PHOTO = p.PHOTO, DATEDEBUT = p.DATEDEBUT, PRIX = p.PHOTO, DATEDEPOT = p.DATEDEPOT, REALISER = p.REALISER}).ToList();
            }
            else
            {
                dgvService.DataSource = (Modele.ListeService()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.DESCRIPTIFSERVICE.StartsWith(descriptif) && k.REALISER.ToString().StartsWith(execute)).Select(p => new { IDSERVICE = p.IDSERVICE, IDINSCRIT = p.IDINSCRIT, IDDEPARTEMENT = p.IDINSCRIT, IDTYPE = p.IDTYPE, DESCRIPTIFSERVICE = p.DESCRIPTIFSERVICE, PHOTO = p.PHOTO, DATEDEBUT = p.DATEDEBUT, PRIX = p.PHOTO, DATEDEPOT = p.DATEDEPOT, REALISER = p.REALISER }).ToList();
            }
        }
    }
}

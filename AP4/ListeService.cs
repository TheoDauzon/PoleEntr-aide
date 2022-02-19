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
        FormGestionService FGS;
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
            if (mstDateServDeb.MaskFull == true && mstDateServFin.MaskFull == false)
            {
                dateServDeb = Convert.ToDateTime(mstDateServDeb.Text);
                dgvService.DataSource = (Modele.ListeService()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.DESCRIPTIFSERVICE.StartsWith(descriptif) && k.REALISER.ToString().StartsWith(execute) && k.DATEDEPOT >= dateServDeb).Select(p => new { IDSERVICE = p.IDSERVICE, IDINSCRIT = p.IDINSCRIT, IDDEPARTEMENT = p.IDINSCRIT, IDTYPE = p.IDTYPE, DESCRIPTIFSERVICE = p.DESCRIPTIFSERVICE, PHOTO = p.PHOTO, DATEDEBUT = p.DATEDEBUT, PRIX = p.PHOTO, DATEDEPOT = p.DATEDEPOT, REALISER = p.REALISER }).ToList();
            }
            else if (mstDateServFin.MaskFull == true && mstDateServDeb.MaskFull == false)
            {
                dateServFin = Convert.ToDateTime(mstDateServFin.Text);
                dgvService.DataSource = (Modele.ListeService()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.DESCRIPTIFSERVICE.StartsWith(descriptif) && k.REALISER.ToString().StartsWith(execute) && k.DATEDEPOT <= dateServFin).Select(p => new { IDSERVICE = p.IDSERVICE, IDINSCRIT = p.IDINSCRIT, IDDEPARTEMENT = p.IDINSCRIT, IDTYPE = p.IDTYPE, DESCRIPTIFSERVICE = p.DESCRIPTIFSERVICE, PHOTO = p.PHOTO, DATEDEBUT = p.DATEDEBUT, PRIX = p.PHOTO, DATEDEPOT = p.DATEDEPOT, REALISER = p.REALISER }).ToList();
            }
            else if (mstDateServFin.MaskFull == true && mstDateServDeb.MaskFull == true)
            {
                dateServDeb = Convert.ToDateTime(mstDateServDeb.Text);
                dateServFin = Convert.ToDateTime(mstDateServFin.Text);
                dgvService.DataSource = (Modele.ListeService()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.DESCRIPTIFSERVICE.StartsWith(descriptif) && k.REALISER.ToString().StartsWith(execute) && k.DATEDEPOT <= dateServFin && k.DATEDEPOT >= dateServDeb).Select(p => new { IDSERVICE = p.IDSERVICE, IDINSCRIT = p.IDINSCRIT, IDDEPARTEMENT = p.IDINSCRIT, IDTYPE = p.IDTYPE, DESCRIPTIFSERVICE = p.DESCRIPTIFSERVICE, PHOTO = p.PHOTO, DATEDEBUT = p.DATEDEBUT, PRIX = p.PHOTO, DATEDEPOT = p.DATEDEPOT, REALISER = p.REALISER }).ToList();
            }
            else
            {
                dgvService.DataSource = (Modele.ListeService()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.DESCRIPTIFSERVICE.StartsWith(descriptif) && k.REALISER.ToString().StartsWith(execute)).Select(p => new { IDSERVICE = p.IDSERVICE, IDINSCRIT = p.IDINSCRIT, IDDEPARTEMENT = p.IDINSCRIT, IDTYPE = p.IDTYPE, DESCRIPTIFSERVICE = p.DESCRIPTIFSERVICE, PHOTO = p.PHOTO, DATEDEBUT = p.DATEDEBUT, PRIX = p.PHOTO, DATEDEPOT = p.DATEDEPOT, REALISER = p.REALISER }).ToList();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            System.Type type = bsService.Current.GetType();
            int idService = (int)type.GetProperty("IDSERVICE").GetValue(bsService.Current, null);

            Modele.RecupererService(idService);

            string descriptif = Modele.RecupererService(idService).DESCRIPTIFSERVICE;
            string photo = Modele.RecupererService(idService).PHOTO;
            DateTime dateReponse = Modele.RecupererService(idService).DATEDEBUT;
            int duree = Modele.RecupererService(idService).DUREEJOURS;
            int prix = Modele.RecupererService(idService).PRIX;
            int realiser = Modele.RecupererService(idService).REALISER;
            int departement = Modele.RecupererService(idService).IDDEPARTEMENT;

            FGS = new FormGestionService(idService, descriptif, photo, dateReponse, duree, prix, realiser, departement);
            this.Close();
            FGS.Show();
        }

        private void tbNumero_Leave(object sender, EventArgs e)
        {
            if (tbNumero.Text.ToString() != "")
            {
                if (int.Parse(tbNumero.Text.ToString()) < 0)
                {
                    MessageBox.Show("Erreur, la valeur doit être strictement supérieur à 0", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNumero.Focus();
                }
            }
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void tbExecute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void tbExecute_Leave(object sender, EventArgs e)
        {
            if (tbExecute.Text.ToString() != "")
            {
                if (int.Parse(tbExecute.Text.ToString()) < 0 || int.Parse(tbExecute.Text.ToString()) > 2)
                {
                    MessageBox.Show("Erreur, la valeur doit être 0 ou 1 ou bien 2", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbExecute.Focus();
                }
            }
        }

        private void mstDateServDeb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void mstDateServFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void mstDateServDeb_Leave(object sender, EventArgs e)
        {
            if (mstDateServDeb.MaskFull == true)
            {
                if (Convert.ToDateTime(mstDateServDeb.Text) > DateTime.Today)
                {
                    MessageBox.Show("Erreur, la date doit être antérieur à celle du jour", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mstDateServDeb.Text = "";
                    mstDateServDeb.Focus();
                }
            }
        }

        private void mstDateServFin_Leave(object sender, EventArgs e)
        {
            if (mstDateServFin.MaskFull == true)
            {
                if (Convert.ToDateTime(mstDateServFin.Text) > DateTime.Today)
                {
                    MessageBox.Show("Erreur, la date doit être antérieur à celle du jour", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mstDateServFin.Text = "";
                    mstDateServFin.Focus();
                }
            }
        }
    }
}

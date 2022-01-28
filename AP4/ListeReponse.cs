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
        FormGestionReponse FGR;
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

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string num = tbNumero.Text;
            string numServ = tbService.Text;
            DateTime dateServDeb;
            DateTime dateServFin;
            if (mstDateServDeb.MaskFull == true && mstDateServFin.MaskFull == false)
            {
                dateServDeb = Convert.ToDateTime(mstDateServDeb.Text);
                dgvReponse.DataSource = (Modele.ListeReponse()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.IDSERVICE.ToString().StartsWith(numServ) && k.DATEREP >= dateServDeb).Select(p => new {IDINSCRIT = p.IDINSCRIT, IDSERVICE = p.IDSERVICE, DATEREP = p.DATEREP}).ToList();
            }
            else if (mstDateServFin.MaskFull == true && mstDateServDeb.MaskFull == false)
            {
                dateServFin = Convert.ToDateTime(mstDateServFin.Text);
                dgvReponse.DataSource = (Modele.ListeReponse()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.IDSERVICE.ToString().StartsWith(numServ) && k.DATEREP >= dateServFin).Select(p => new { IDINSCRIT = p.IDINSCRIT, IDSERVICE = p.IDSERVICE, DATEREP = p.DATEREP }).ToList();
            }
            else if (mstDateServFin.MaskFull == true && mstDateServDeb.MaskFull == true)
            {
                dateServDeb = Convert.ToDateTime(mstDateServDeb.Text);
                dateServFin = Convert.ToDateTime(mstDateServDeb.Text);
                dgvReponse.DataSource = (Modele.ListeReponse()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.IDSERVICE.ToString().StartsWith(numServ) && k.DATEREP <= dateServFin && k.DATEREP >= dateServDeb).Select(p => new { IDINSCRIT = p.IDINSCRIT, IDSERVICE = p.IDSERVICE, DATEREP = p.DATEREP }).ToList();
            }
            else
            {
                dgvReponse.DataSource = (Modele.ListeReponse()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.IDSERVICE.ToString().StartsWith(numServ)).Select(p => new { IDINSCRIT = p.IDINSCRIT, IDSERVICE = p.IDSERVICE, DATEREP = p.DATEREP }).ToList();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            System.Type type = bsReponse.Current.GetType();
            int idInscrit = (int)type.GetProperty("IDINSCRIT").GetValue(bsReponse.Current, null);

            Modele.RecupererReponse(idInscrit);

            int idService = Modele.RecupererReponse(idInscrit).IDSERVICE;
            DateTime dateReponse = Modele.RecupererReponse(idInscrit).DATEREP;

            FGR = new FormGestionReponse(idInscrit, idService, dateReponse);
            this.Close();
            FGR.Show();
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

        private void tbService_Leave(object sender, EventArgs e)
        {
            if (tbService.Text.ToString() != "")
            {
                if (int.Parse(tbService.Text.ToString()) < 0)
                {
                    MessageBox.Show("Erreur, la valeur doit être strictement supérieur à 0", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbService.Focus();
                }
            }
        }

        private void tbService_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
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
            if (Convert.ToDateTime(mstDateServDeb.Text) > Convert.ToDateTime(mstDateServFin.Text))
            {
                MessageBox.Show("Erreur, la date ne doit pas être supérieur à la deuxième date", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mstDateServDeb.Text = "";
                mstDateServDeb.Focus();
            }
            if (Convert.ToDateTime(mstDateServDeb.Text) < DateTime.Today)
            {
                MessageBox.Show("Erreur, la date ne doit pas être antérieur à celle du jour", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mstDateServDeb.Text = "";
                mstDateServDeb.Focus();
            }
        }

        private void mstDateServFin_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(mstDateServFin.Text) < Convert.ToDateTime(mstDateServDeb.Text))
            {
                MessageBox.Show("Erreur, la deuxième date ne doit pas être inférieur à la première date", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mstDateServFin.Text = "";
                mstDateServFin.Focus();
            }
            if (Convert.ToDateTime(mstDateServFin.Text) < DateTime.Today)
            {
                MessageBox.Show("Erreur, la date ne doit pas être antérieur à celle du jour", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mstDateServFin.Text = "";
                mstDateServFin.Focus();
            }
        }
    }
}

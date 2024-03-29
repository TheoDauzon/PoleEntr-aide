﻿using System;
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
            dgvReponse.Columns[4].Visible = false;
            dgvReponse.Columns[5].Visible = false;
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string num = tbNumero.Text;
            string numServ = tbService.Text;
            DateTime dateServDeb;
            DateTime dateServFin;
            string attribuer = tbAttribuer.Text;
            if (mstDateServDeb.MaskFull == true && mstDateServFin.MaskFull == false)
            {
                dateServDeb = Convert.ToDateTime(mstDateServDeb.Text);
                dgvReponse.DataSource = (Modele.ListeReponse()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.IDSERVICE.ToString().StartsWith(numServ) && k.DATEREP >= dateServDeb && k.ATTRIBUER.ToString().StartsWith(attribuer)).Select(p => new {IDINSCRIT = p.IDINSCRIT, IDSERVICE = p.IDSERVICE, DATEREP = p.DATEREP, ATTRIBUER = p.ATTRIBUER}).ToList();
            }
            else if (mstDateServFin.MaskFull == true && mstDateServDeb.MaskFull == false)
            {
                dateServFin = Convert.ToDateTime(mstDateServFin.Text);
                dgvReponse.DataSource = (Modele.ListeReponse()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.IDSERVICE.ToString().StartsWith(numServ) && k.DATEREP <= dateServFin && k.ATTRIBUER.ToString().StartsWith(attribuer)).Select(p => new { IDINSCRIT = p.IDINSCRIT, IDSERVICE = p.IDSERVICE, DATEREP = p.DATEREP, ATTRIBUER = p.ATTRIBUER }).ToList();
            }
            else if (mstDateServFin.MaskFull == true && mstDateServDeb.MaskFull == true)
            {
                dateServDeb = Convert.ToDateTime(mstDateServDeb.Text);
                dateServFin = Convert.ToDateTime(mstDateServFin.Text);
                dgvReponse.DataSource = (Modele.ListeReponse()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.IDSERVICE.ToString().StartsWith(numServ) && k.DATEREP <= dateServFin && k.DATEREP >= dateServDeb && k.ATTRIBUER.ToString().StartsWith(attribuer)).Select(p => new { IDINSCRIT = p.IDINSCRIT, IDSERVICE = p.IDSERVICE, DATEREP = p.DATEREP, ATTRIBUER = p.ATTRIBUER }).ToList();
            }
            else
            {
                dgvReponse.DataSource = (Modele.ListeReponse()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.IDSERVICE.ToString().StartsWith(numServ) && k.ATTRIBUER.ToString().StartsWith(attribuer)).Select(p => new { IDINSCRIT = p.IDINSCRIT, IDSERVICE = p.IDSERVICE, DATEREP = p.DATEREP, ATTRIBUER = p.ATTRIBUER }).ToList();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            System.Type type = bsReponse.Current.GetType();
            int idInscrit = (int)type.GetProperty("IDINSCRIT").GetValue(bsReponse.Current, null);

            Modele.RecupererReponse(idInscrit);

            int idService = Modele.RecupererReponse(idInscrit).IDSERVICE;
            DateTime dateReponse = Modele.RecupererReponse(idInscrit).DATEREP;
            int attribuer = (int)Modele.RecupererReponse(idInscrit).ATTRIBUER;

            FGR = new FormGestionReponse(idInscrit, idService, dateReponse, attribuer);
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

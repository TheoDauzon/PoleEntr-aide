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
        ListeInscrit LI;
        FormGestionInscrit FGI;
        public ListeInscrit()
        {
            InitializeComponent();
        }

        private void ListeInscrit_Load(object sender, EventArgs e)
        {
            bsInscrit.DataSource = Modele.ListeInscrit(); // appel de la méthode listeClients
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

        private void BtnSupprimerMessage_Click(object sender, EventArgs e)
        {
            System.Type type = bsInscrit.Current.GetType();
            int idInscrit = (int)type.GetProperty("IDINSCRIT").GetValue(bsInscrit.Current, null);

            if (MessageBox.Show("Etes vous sur de vouloir supprimer l'inscrit : " + idInscrit, "Suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Modele.SuppInscrit(idInscrit))
                {
                    MessageBox.Show("Suppression de l'inscrit réussi");
                    dgvInscrit.Refresh();
                    LI = new ListeInscrit();
                    this.Close();
                    LI.Show();
                }
                else
                    MessageBox.Show("Problème dans la suppression");
            }
        }

        private void BtnModifierInscrit_Click(object sender, EventArgs e)
        {
            System.Type type = bsInscrit.Current.GetType();
            int idInscrit = (int)type.GetProperty("IDINSCRIT").GetValue(bsInscrit.Current, null);

            Modele.RecupererInscrit(idInscrit);
            string nom = Modele.RecupererInscrit(idInscrit).NOMINSCRIT;
            string prenom = Modele.RecupererInscrit(idInscrit).PRENOMINSCRIT;
            string mail = Modele.RecupererInscrit(idInscrit).MAIL;
            string mdp = Modele.RecupererInscrit(idInscrit).MDPINSCRIT;
            string tel = Modele.RecupererInscrit(idInscrit).TELINSCRIT;
            DateTime dateNaiss = Modele.RecupererInscrit(idInscrit).DATENAISSANCE;
            string adresse = Modele.RecupererInscrit(idInscrit).ADRESSE;
            int credit = (int)Modele.RecupererInscrit(idInscrit).CREDIT;
            int admin = Modele.RecupererInscrit(idInscrit).ADMIN;
            int statut = Modele.RecupererInscrit(idInscrit).STATUT;

            FGI = new FormGestionInscrit(idInscrit, nom, prenom, mail, mdp, tel, dateNaiss, adresse, credit, admin, statut);
            this.Close();
            FGI.Show();

        }

        private void btnAjouterInscrit_Click(object sender, EventArgs e)
        {
            FGI = new FormGestionInscrit(-1, "", "", "", "", "", DateTime.Now, "", 100, 0, 5);
            FGI.Show();
            dgvInscrit.Refresh();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string num = tbNumero.Text;
            string prenom = tbPrenom.Text;
            string nom = tbNom.Text;
            string mail = tbMail.Text;
            string statut = tbStatut.Text;
            string admin = tbAdmin.Text;

            dgvInscrit.DataSource = (Modele.ListeInscrit()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.PRENOMINSCRIT.StartsWith(prenom) && k.NOMINSCRIT.StartsWith(nom) && k.MAIL.StartsWith(mail) && k.ADMIN.ToString().StartsWith(admin) && k.STATUT.ToString().StartsWith(statut)).Select(p => new { IDINSCRIT = p.IDINSCRIT, NOMINSCRIT = p.NOMINSCRIT, PRENOMINSCRIT = p.PRENOMINSCRIT, MAIL = p.MAIL, MDPINSCRIT = p.MDPINSCRIT, TELINSCRIT = p.TELINSCRIT, DATENAISSANCE = p.DATENAISSANCE, ADRESSE = p.ADRESSE, CREDIT = p.CREDIT, ADMIN = p.ADMIN, STATUT = p.STATUT }).ToList();
        }

        private void tbStatut_Leave(object sender, EventArgs e)
        {
            if (tbStatut.Text.ToString() != "")
            {
                if (int.Parse(tbStatut.Text.ToString()) < 0 || int.Parse(tbStatut.Text.ToString()) > 6)
                {
                    MessageBox.Show("Erreur, la valeur doit être comprise entre 0 et 6 inclus", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbStatut.Focus();
                }
            }
        }

        private void tbStatut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void tbAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void tbAdmin_Leave(object sender, EventArgs e)
        {
            if (tbAdmin.Text.ToString() != "")
            {
                if (int.Parse(tbAdmin.Text.ToString()) < 0 || int.Parse(tbAdmin.Text.ToString()) > 1)
                {
                    MessageBox.Show("Erreur, la valeur doit être comprise entre 0 et 1 inclus", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbAdmin.Focus();
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
            };
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
    }
}

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
    public partial class FormGestionReponse : Form
    {
        ListeReponse LR;
        private int idInscrit;
        private int idService;
        private DateTime dateReponse;
        private int attribuer;

        public FormGestionReponse(int idInscrit, int idService, DateTime dateReponse, int attribuer)
        {
            InitializeComponent();
            this.idInscrit = idInscrit;
            this.idService = idService;
            this.dateReponse = dateReponse;
            this.attribuer = attribuer;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            LR = new ListeReponse();
            this.Close();
            LR.Show();
        }

        private void btnModifierM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir modifier la réponse de l'inscrit : " + this.idInscrit, "Modifier", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int idService = Convert.ToInt32(tbService.Text);
                DateTime dateReponse = dtpReponse.Value;
                int attribuer = Convert.ToInt32(tbAttribuer.Text);

                try
                {
                    bool v = Modele.ModifierReponse(idInscrit, idService, dateReponse, attribuer);

                    MessageBox.Show("Modification effectuée");
                    LR = new ListeReponse();
                    this.Close();
                    LR.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void FormGestionReponse_Load(object sender, EventArgs e)
        {
            tbNumero.Text = idInscrit.ToString();
            tbService.Text = idService.ToString();
            dtpReponse.Text = dateReponse.ToString();
            tbAttribuer.Text = attribuer.ToString();
        }

        private void dtpReponse_Leave(object sender, EventArgs e)
        {
            if (dtpReponse.Value > DateTime.Today)
            {
                MessageBox.Show("Erreur, la date ne doit pas être antérieur à celle du jour", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpReponse.Value = DateTime.Today;
                dtpReponse.Focus();
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

        private void tbAttribuer_Leave(object sender, EventArgs e)
        {
            if (tbAttribuer.Text.ToString() != "")
            {
                if (int.Parse(tbAttribuer.Text.ToString()) < 0 || int.Parse(tbAttribuer.Text.ToString()) > 1)
                {
                    MessageBox.Show("Erreur, la valeur doit être 0 ou 1", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbAttribuer.Focus();
                }
            }
        }

        private void tbAttribuer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }
    }
}


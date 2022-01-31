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
    public partial class FormGestionService : Form
    {
        ListeService LS;
        private int idService;
        private string descriptif;
        private string photo;
        private DateTime dateReponse;
        private int duree;
        private int prix;
        private int realiser;
        private int departement;

        public FormGestionService(int idService, string descriptif, string photo, DateTime dateReponse, int duree, int prix, int realiser, int departement)
        {
            InitializeComponent();
            this.idService = idService;
            this.descriptif = descriptif;
            this.photo = photo;
            this.dateReponse = dateReponse;
            this.duree = duree;
            this.prix = prix;
            this.realiser = realiser;
            this.departement = departement;

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            LS = new ListeService();
            this.Close();
            LS.Show();
        }

        private void FormGestionService_Load(object sender, EventArgs e)
        {
            tbDescriptif.Text = descriptif;
            tbPhoto.Text = photo;
            dtpReponse.Text = dateReponse.ToString();
            tbDuree.Text = duree.ToString();
            tbPrix.Text = prix.ToString();
            tbRealiser.Text = realiser.ToString();
            cbDepartement.ValueMember = "IDDEPARTEMENT"; //permet de stocker l'identifiant
            cbDepartement.DisplayMember = "LIBELLEDEPARTEMENT";
            cbDepartement.DataSource = Modele.ListeDepartement();
            cbDepartement.SelectedIndex = (departement)-1;
        }

        private void btnModifierM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir modifier le service : " + this.idService, "Modifier", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string descriptif = tbDescriptif.Text;
                string photo = tbPhoto.Text;
                DateTime dateReponse = dtpReponse.Value;
                int duree = Convert.ToInt32(tbDuree.Text);
                int prix = Convert.ToInt32(tbPrix.Text);
                int realiser = Convert.ToInt32(tbRealiser.Text);
                int departement = (cbDepartement.SelectedIndex)+1;

                try
                {
                    bool v = Modele.ModifierService(idService, descriptif, photo, dateReponse, duree, prix, realiser, departement);

                    MessageBox.Show("Modification effectuée");
                    LS = new ListeService();
                    this.Close();
                    LS.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void cbDepartement_Leave(object sender, EventArgs e)
        {
            if (cbDepartement.SelectedIndex == -1)
            {
                MessageBox.Show("Erreur, vous devez sélectionné un département !", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDescriptif.Focus();
            }
        }

        private void dtpReponse_Leave(object sender, EventArgs e)
        {
            if (dtpReponse.Value > DateTime.Today)
            {
                MessageBox.Show("Erreur, la date ne doit pas être antérieur à celle du jour !", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpReponse.Value = DateTime.Today;
                dtpReponse.Focus();
            }
        }

        private void tbDuree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void tbDuree_Leave(object sender, EventArgs e)
        {
            if (tbDuree.Text.ToString() != "")
            {
                if (int.Parse(tbDuree.Text.ToString()) < 0 || int.Parse(tbDuree.Text.ToString()) > 10)
                {
                    MessageBox.Show("Erreur, la valeur doit être comprise entre 0 et 10 inclus", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbDuree.Focus();
                }
            }
        }

        private void tbPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void tbPrix_Leave(object sender, EventArgs e)
        {
            if (tbPrix.Text.ToString() != "")
            {
                if (int.Parse(tbPrix.Text.ToString()) < 0 || int.Parse(tbPrix.Text.ToString()) > 1000)
                {
                    MessageBox.Show("Erreur, la valeur doit être comprise entre 0 et 1000 inclus", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPrix.Focus();
                }
            }
        }

        private void tbRealiser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void tbRealiser_Leave(object sender, EventArgs e)
        {
            if (tbRealiser.Text.ToString() != "")
            {
                if (int.Parse(tbRealiser.Text.ToString()) < 0 || int.Parse(tbRealiser.Text.ToString()) > 2)
                {
                    MessageBox.Show("Erreur, la valeur doit être 0 ou 1 ou bien 2", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbRealiser.Focus();
                }
            }
        }
    }
}

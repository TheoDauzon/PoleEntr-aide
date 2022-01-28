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
    public partial class FormGestionMessage : Form
    {
        ListeMessage LM;
        private int idMessage;
        private int idInscrit;
        private string libelle;
        private int traiter;
        public FormGestionMessage(int idMessage, int idInscrit, string libelle, int traiter)
        {
            InitializeComponent();
            this.idMessage = idMessage;
            this.idInscrit = idInscrit;
            this.libelle = libelle;
            this.traiter = traiter;
        }

        private void btnModifierM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir modifier le message : " + this.idMessage, "Modifier", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string libelle = tbLibelle.Text;
                int traite = Convert.ToInt32(tbTraite.Text);

                if (Modele.ModifierMessage(idMessage, libelle, traite))
                {
                    MessageBox.Show("Modification effectuée");
                    LM = new ListeMessage();
                    this.Close();
                    LM.Show();
                }
                else
                    MessageBox.Show("Problème dans la modification");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            LM = new ListeMessage();
            this.Close();
            LM.Show();
        }

        private void FormGestionMessage_Load(object sender, EventArgs e)
        {
            tbNumero.Text = idInscrit.ToString();
            tbLibelle.Text = libelle;
            tbTraite.Text = traiter.ToString();
        }

        private void tbTraite_Leave(object sender, EventArgs e)
        {
            if (tbTraite.Text.ToString() != "")
            {
                if (int.Parse(tbTraite.Text.ToString()) < 0 || int.Parse(tbTraite.Text.ToString()) > 1)
                {
                    MessageBox.Show("Erreur, la valeur doit être 0 ou 1", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbTraite.Focus();
                }
            }
        }

        private void tbTraite_KeyPress(object sender, KeyPressEventArgs e)
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

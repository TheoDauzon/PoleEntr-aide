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
    public partial class FormGestionInscrit : Form
    {
        public FormGestionInscrit()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (tbNom.Text != "" && tbPrenom.Text != "" && tbEmail.Text != "" && tbMdp.Text != "" && tbTel.Text != "" && tbAdresse.Text != "" && tbCredit.Text != "" && dtpNaissance != null)
            {
                //string passwordHash = BCrypt.Net.BCrypt.HashPassword(tbMdp.Text);//Permet de hasher le mot de passe
                int credit = 100;
                if (tbCredit.Text != "") credit = Convert.ToInt32(tbCredit.Text);
                DateTime dateNaissance = dtpNaissance.Value;
                int idClient = -1;
                string nomInscrit = "";
                string prenomInscrit = tbPrenom.Text;
                string email = tbEmail.Text;
                string tel = tbTel.Text;
                string adresse = tbAdresse.Text;

                /*if (rbtnNon.Checked)
                {
                    if ())
                    {
                        MessageBox.Show("Administrateur ajouté");
                    }
                }
                else if (rbtnOui.Checked)
                {
                    if (Controleur.VmodeleF.AjoutAdministrateur(tbNom.Text, tbPrenom.Text, passwordHash, tbEmail.Text, 0))
                    {
                        MessageBox.Show("Administrateur ajouté");
                    }
                }
                else
                {
                    MessageBox.Show("Erreur dans l'ajout de l'administrateur", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERREUR : Vous devez saisir le nom, prénom, l'email et le mot de passe ! ", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

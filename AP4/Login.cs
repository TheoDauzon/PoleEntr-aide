using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP4
{
    public partial class Login : Form
    {
        Menu M;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsPasswordValid()
        {
            string password = tbMdp.Text;
            if (password.Length >= 8)
            {
                Regex majuscules = new Regex("([A-Z])");
                Regex miniscules = new Regex("([a-z])");
                Regex chiffres = new Regex("([0-9])"); 
                Regex specials = new Regex("([#~%*])");

                if(majuscules.Matches(password).Count >= 1 && miniscules.Matches(password).Count >= 1 && chiffres.Matches(password).Count >= 1 && specials.Matches(password).Count >= 1)
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            if (tbMail.Text == "" && tbMdp.Text == "")
            {
                MessageBox.Show("Les champs doivent être remplis !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tbMail.Text == "")
                {
                    MessageBox.Show("Adresse mail invalide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (tbMdp.Text == "")
                {
                    MessageBox.Show("Mot de passe invalide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    char[] SpecialChars = "@".ToCharArray();

                    int indexOf = tbMail.Text.IndexOfAny(SpecialChars);
                    if (indexOf == -1)
                    {
                        MessageBox.Show("L'adresse mail n'est pas correct !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        /*if (IsPasswordValid() == false)
                        {
                            MessageBox.Show("Le mot de passe n'est pas assez sécurisé !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {*/
                            inscrit unInscrit = Modele.VerifInscrit(tbMail.Text, tbMdp.Text);
                            if (unInscrit != null)
                            {
                                M = new Menu(unInscrit);
                                M.Show();
                                tbMail.Text = "";
                                tbMdp.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Adresse mail ou mot de passe incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        //}
                    }
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

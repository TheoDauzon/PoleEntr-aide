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
        ListeInscrit LI;
        private int idInscrit;
        private string nom;
        private string prenom;
        private string mail;
        private string mdp;
        private string tel;
        private DateTime dateNaiss;
        private string adresse;
        private int credit;
        private int admin;
        private int statut;
        public FormGestionInscrit(int idInscrit, string nom, string prenom, string mail, string mdp, string tel, DateTime dateNaiss, string adresse, int credit, int admin, int statut)
        {
            InitializeComponent();
            this.idInscrit = idInscrit;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.mdp = mdp;
            this.tel = tel;
            this.dateNaiss = dateNaiss;
            this.adresse = adresse;
            this.credit = credit;
            this.admin = admin;
            this.statut = statut;
        }

        private void btnModifierM_Click(object sender, EventArgs e)
        {
            if (idInscrit == -1)
            {
                if (MessageBox.Show("Etes-vous sur de vouloir ajouter l'inscrit ?", "Ajouter", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    string nom = tbNom.Text;
                    string prenom = tbPrenom.Text;
                    string mail = tbEmail.Text;
                    string mdp = BCrypt.Net.BCrypt.HashPassword(tbMdp.Text); //Permet de hasher le mot de passe
                    string tel = tbTel.Text;
                    DateTime dateNaiss = dtpNaissance.Value;
                    string adresse = tbAdresse.Text;
                    int credit = Convert.ToInt32(tbCredit.Text);

                    if (Modele.AjoutInscrit(nom, prenom, mail, mdp, tel, dateNaiss, adresse, credit, admin, statut))
                    {
                        MessageBox.Show("Insertion de l'inscrit réussi");
                        LI = new ListeInscrit();
                        this.Close();
                        LI.Show();
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Etes-vous sur de vouloir modifier l'inscrit : " + idInscrit + " ?", "Modifier", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    string nom = tbNom.Text;
                    string prenom = tbPrenom.Text;
                    string mail = tbEmail.Text;
                    string mdp = BCrypt.Net.BCrypt.HashPassword(tbMdp.Text); //Permet de hasher le mot de passe
                    string tel = tbTel.Text;
                    DateTime dateNaiss = dtpNaissance.Value;
                    string adresse = tbAdresse.Text;
                    int credit = Convert.ToInt32(tbCredit.Text);

                    if (Modele.ModifierInscrit(idInscrit, nom, prenom, mail, mdp, tel, dateNaiss, adresse, credit, admin, statut))
                    {
                        MessageBox.Show("Modification de l'inscrit réussi");
                        LI = new ListeInscrit();
                        this.Close();
                        LI.Show();
                    }
                }
            }
        }

        private void FormGestionInscrit_Load(object sender, EventArgs e)
        {
            if (idInscrit == -1)
            {
                tbNom.Text = "";
                tbPrenom.Text = "";
                tbEmail.Text = "";
                tbMdp.Text = "";
                tbTel.Text = "";
                dtpNaissance.Value = DateTime.Now;
                tbAdresse.Text = "";
                tbCredit.Text = 100.ToString();
                rbPeutToutFaire.Checked = true;
                rbtnNon.Checked = true; 
            }
            else
            {
                //string mdp = BCrypt.Net.BCrypt.Verify(tbMdp);
                tbNom.Text = nom;
                tbPrenom.Text = prenom;
                tbEmail.Text = mail;
                tbMdp.Text = mdp;
                tbTel.Text = tel;
                dtpNaissance.Value = dateNaiss;
                tbAdresse.Text = adresse;
                tbCredit.Text = credit.ToString();
                if (admin == 1)
                {
                    rbtnOui.Checked = true;
                }
                if (admin == 0)
                {
                    rbtnNon.Checked = true;
                }
                if (statut == 1)
                {
                    rbPeutPoster.Checked = true;
                }
                if (statut == 2)
                {
                    rbPeutPasPoster.Checked = true;
                }
                if (statut == 3)
                {
                    rbPeutAccepter.Checked = true;
                }
                if (statut == 4)
                {
                    rbPeutPasAccepter.Checked = true;
                }
                if (statut == 5)
                {
                    rbPeutToutFaire.Checked = true;
                }
                if (statut == 6)
                {
                    rbPeutPasToutFaire.Checked = true;
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            LI = new ListeInscrit();
            this.Close();
            LI.Show();
        }
    }
}

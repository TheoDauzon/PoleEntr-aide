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
            bool admin = Modele.RecupererInscrit(idInscrit).ADMIN;
            int statut = Modele.RecupererInscrit(idInscrit).STATUT;

            FGI = new FormGestionInscrit(idInscrit, nom, prenom, mail, mdp, tel, dateNaiss, adresse, credit, admin, statut);
            FGI.Show();
        }

        private void btnAjouterInscrit_Click(object sender, EventArgs e)
        {
            FGI = new FormGestionInscrit(-1, "", "", "", "", "", DateTime.Now, "", 100, false, 5);
            FGI.Show();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string num = tbNumero.Text;
            string prenom = tbPrenom.Text;
            string nom = tbNom.Text;
            string mail = tbMail.Text;
            string statut = tbStatut.Text;
            string admin = tbAdmin.Text;

            dgvInscrit.DataSource = (Modele.ListeInscrit()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.PRENOMINSCRIT.StartsWith(prenom) && k.NOMINSCRIT.StartsWith(nom) && k.MAIL.StartsWith(mail) && k.ADMIN.ToString().StartsWith(admin) && k.STATUT.ToString().StartsWith(statut)).Select(p => new { IDINSCRIT = p.IDINSCRIT, NOMINSCRIT = p.NOMINSCRIT, PRENOMINSCRIT = p.PRENOMINSCRIT, MAIL = p.MAIL, MDPINSCRIT = p.MDPINSCRIT, TELINSCRIT = p.TELINSCRIT, DATENAISSANCE = p.DATENAISSANCE, ADRESSE = p.ADRESSE, CREDIT = p.CREDIT, ADMIN = p.ADMIN, STATUT = p.STATUT}).ToList();
        }

    }
}

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
                   MessageBox.Show("Suppression effectuée");
                else
                   MessageBox.Show("PROBLEME suppression");
            }
        }
         
        private void BtnModifierInscrit_Click(object sender, EventArgs e)
        {
            System.Type type = bsInscrit.Current.GetType();
            int idInscrit = (int)type.GetProperty("IDINSCRIT").GetValue(bsInscrit.Current, null);
            MessageBox.Show("Inscrit :" + idInscrit);

            /*if (Modele.ModifierInscrit(idInscrit))
                MessageBox.Show("Modification effectuée");
            else
                MessageBox.Show("PROBLEME Modifications");*/
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

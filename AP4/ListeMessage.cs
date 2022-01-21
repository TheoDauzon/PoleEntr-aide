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
    public partial class ListeMessage : Form
    {
        public ListeMessage()
        {
            InitializeComponent();
        }

        private void BtnRetourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListeMessage_Load(object sender, EventArgs e)
        {
            bsMessage.DataSource = Modele.ListeMessage(); // appel de la méthode listeClients
            dgvMessage.DataSource = bsMessage;
            dgvMessage.Columns[4].Visible = false;
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string num = tbNumero.Text;
            string libelle = tbLibelle.Text;
            string traiter = tbTraiter.Text;
            dgvMessage.DataSource = (Modele.ListeMessage()).Where(k => k.IDINSCRIT.ToString().StartsWith(num) && k.LIBELLEMESSAGE.StartsWith(libelle) && k.TRAITER.ToString().StartsWith(traiter)).Select(p => new { IDMESSAGE = p.IDMESSAGE, IDINSCRIT = p.IDINSCRIT, LIBELLEMESSAGE = p.LIBELLEMESSAGE, TRAITER = p.TRAITER}).ToList();    
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            string mailI = Convert.ToString(tbMail.Text);
            string Subject = Convert.ToString(tbObjet.Text);
            string Body = Convert.ToString(tbCorps.Text);

            if (Modele.Envoi_mail(mailI, Subject, Body))
            {
                MessageBox.Show("Mail envoyé avec succès !");
            }
        }

        private void btnModifierMessage_Click(object sender, EventArgs e)
        {
            System.Type type = bsMessage.Current.GetType();
            int idMessage = (int)type.GetProperty("IDMESSAGE").GetValue(bsMessage.Current, null);

            MessageBox.Show("Message :" + idMessage);

            if (Modele.ModifierMessage(idMessage, 10, DateTime.Now, 1))
                MessageBox.Show("Modification effectuée");
            else
                MessageBox.Show("problème dans la modification");
        }
    }
}

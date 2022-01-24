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
        private int idInscrit;
        private int idService;
        private DateTime dateReponse;

        public FormGestionReponse(int idInscrit, int idService, DateTime dateReponse)
        {
            InitializeComponent();
            this.idInscrit = idInscrit;
            this.idService = idService;
            this.dateReponse = dateReponse;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifierM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir modifier la réponse de l'inscrit : " + this.idInscrit, "Modifier", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int idService = Convert.ToInt32(tbService.Text);
                DateTime dateReponse = dtpReponse.Value;

                try {
                    bool v = Modele.ModifierReponse(idInscrit, idService, dateReponse);

                    MessageBox.Show("Modification effectuée");
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
        }
    }
}

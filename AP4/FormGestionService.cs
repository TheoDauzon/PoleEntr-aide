﻿using System;
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
        private int idService;
        private string descriptif;
        private string photo;
        private DateTime dateReponse;
        private int duree;
        private int prix;
        private bool realiser;
        private int departement;

        public FormGestionService(int idService, string descriptif, string photo, DateTime dateReponse, int duree, int prix, bool realiser, int departement)
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
            this.Close();
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
            cbDepartement.SelectedIndex = -1;
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
                bool realiser = Convert.ToBoolean(tbRealiser.Text);
                int departement = cbDepartement.SelectedIndex;

                try
                {
                    bool v = Modele.ModifierService(idService, descriptif, photo, dateReponse, duree, prix, realiser, departement);

                    MessageBox.Show("Modification effectuée");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}

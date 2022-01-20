using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP4
{
    public static class Modele
    {
        private static ap4Entities maConnexion;
        private static inscrit unInscrit;

        public static inscrit UnInscrit { get => UnInscrit; set => UnInscrit = value; }
        public static void Init()
        {
            maConnexion = new ap4Entities();
        }
        public static List<inscrit> ListeInscrit()
        {
            return maConnexion.inscrit.ToList();
        }

        public static List<service> ListeService()
        {
            return maConnexion.service.ToList();
        }

        public static List<repondre> ListeReponse()
        {
            return maConnexion.repondre.ToList();
        }

        public static List<message> ListeMessage()
        {
            return maConnexion.message.ToList();
        }

        public static inscrit VerifInscrit(string mail, string mdp)
        {
            try
            {
                inscrit unInscrit = new inscrit();
                unInscrit = maConnexion.inscrit.First(x => x.MAIL == mail && x.MDPINSCRIT == mdp);
                return unInscrit;
            }
            catch
            {
                return null;
            }
        }

        public static inscrit RecupererInscrit(int idInscrit)
        {
            inscrit unInscrit = new inscrit();
            try
            {
                unInscrit = maConnexion.inscrit.First(x => x.IDINSCRIT == idInscrit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unInscrit;
        }

        public static bool ModifierInscrit(int idI, string nom, string prenom, string mail, string tel, DateTime date, string adresse, int credit, int admin, int statut)
        {
            bool vretour = true;
            try
            {
                unInscrit = RecupererInscrit(idI);
                unInscrit.NOMINSCRIT = nom;
                unInscrit.PRENOMINSCRIT = prenom;
                unInscrit.MAIL = mail;
                unInscrit.TELINSCRIT = tel;
                unInscrit.DATENAISSANCE = date.Date;
                unInscrit.ADRESSE = adresse;
                unInscrit.CREDIT = credit;

                maConnexion.SaveChanges();
            }
            catch
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool SuppInscrit(int idI)
        {
            bool vretour = true;
            try
            {
                unInscrit = RecupererInscrit(idI);
                maConnexion.inscrit.Remove(unInscrit);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " + ex.InnerException.InnerException.Message);
                vretour = false;
            }
            return vretour;
        }

        /*public static bool AjoutInscrit(int montant, DateTime dateC, int idClient, ICollection<partitions> part)
        {
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                unInscrit = new inscrit();
                unInscrit.MONTANTCDE = montant;
                unInscrit.DATECDE = dateC.Date;
                unInscrit.NUMCLI = idClient;
                maConnexion.commande.Add(unInscrit);
                maConnexion.SaveChanges();

                // ajout du lien entre commande et partitions (table contenir de la BD)
                // ajout des partitions en récupérant l'idCommande de la commande que l'on vient d'ajouter
                int idCde = maConnexion.commande.Max(x => x.NUMCDE);
                MessageBox.Show("Utilisateur ajouté " + idCde);
                unInscrit = RecupererCommande(idCde);
                unInscrit.partitions = part;
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }*/
    }
}

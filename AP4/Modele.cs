using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP4
{
    public static class Modele
    {
        private static ap4Entities maConnexion;
        private static inscrit unInscrit;
        private static message unMessage;

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

        public static message RecupererMessage(int idMessage)
        {
            message unMessage = new message();
            try
            {
                unMessage = maConnexion.message.First(x => x.IDMESSAGE == idMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unMessage;
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

        public static bool Envoi_mail(string adressseMail, string subject, string body)
        {
            string msg = string.Empty;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("poleentraide.service@gmail.com");
                mail.To.Add(adressseMail);
                mail.Subject = subject;
                mail.Body = body;

                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("poleentraide.service@gmail.com", "Ilfautfinirl'ap28/01");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                return true;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static bool ModifierMessage(int idMessage, string libelle)
        {
            bool vretour = true;
            try
            {
                unMessage = RecupererMessage(idMessage);
                unMessage.LIBELLEMESSAGE = libelle;

                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }
    }
}

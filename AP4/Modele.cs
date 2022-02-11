﻿using System;
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
        public static ap4Entities maConnexion;
        private static inscrit unInscrit;
        private static message unMessage;
        private static repondre uneReponse;
        private static service unService;
        private static nbInscritsTemps unInscritTemps;

        public static inscrit UnInscrit { get => UnInscrit; set => UnInscrit = value; }
        public static void Init()
        {
            maConnexion = new ap4Entities();
        }
        public static List<inscrit> ListeInscrit()
        {
            return maConnexion.inscrit.ToList();
        }

        public static List<departement> ListeDepartement()
        {
            return maConnexion.departement.ToList();
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

        public static List<nbInscritsTemps> ListeInscritsTemps()
        {
            return maConnexion.nbInscritsTemps.ToList();
        }

        public static inscrit VerifInscrit(string mail, string mdp)
        {
            try
            {
                inscrit unInscrit = new inscrit();
                //unInscrit = maConnexion.inscrit.First(x => x.MAIL == mail && x.MDPINSCRIT == mdp);
                //return unInscrit;
                unInscrit = RecupererMdp(mail);
                if (BCrypt.Net.BCrypt.Verify(mdp, unInscrit.MDPINSCRIT))
                {
                    return unInscrit;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public static inscrit RecupererMdp(string mail)
        {
            inscrit unInscrit = new inscrit();
            try
            {
                unInscrit = maConnexion.inscrit.First(x => x.MAIL == mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unInscrit;
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

        public static repondre RecupererReponse(int idInscrit)
        {
            repondre uneReponse = new repondre();
            try
            {
                uneReponse = maConnexion.repondre.First(x => x.IDINSCRIT == idInscrit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneReponse;
        }

        public static service RecupererService(int idService)
        {
            service unService = new service();
            try
            {
                unService = maConnexion.service.First(x => x.IDSERVICE == idService);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unService;
        }

        public static bool ModifierInscrit(int idI, string nom, string prenom, string mail, string mdp, string tel, DateTime date, string adresse, int credit,int admin, int statut)
        {
            bool vretour = true;
            try
            {
                unInscrit = RecupererInscrit(idI);
                unInscrit.NOMINSCRIT = nom;
                unInscrit.PRENOMINSCRIT = prenom;
                unInscrit.MAIL = mail;
                unInscrit.MDPINSCRIT = mdp;
                unInscrit.TELINSCRIT = tel;
                unInscrit.DATENAISSANCE = date.Date;
                unInscrit.ADRESSE = adresse;
                unInscrit.CREDIT = credit;
                unInscrit.ADMIN = (short)admin;
                unInscrit.STATUT = (short)statut;
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

        public static bool InscritTemps(string date, int nbInscrit)
        {
            bool vretour = true;
            try
            {
                unInscritTemps = new nbInscritsTemps();
                unInscritTemps.DATENB = Convert.ToDateTime(date);
                unInscritTemps.NBINSCRITSTEMPS1 = nbInscrit;
                maConnexion.nbInscritsTemps.Add(unInscritTemps);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool AjoutInscrit(string nom, string prenom, string mail, string mdp, string tel, DateTime date, string adresse, int credit, int admin, int statut)
        {
            bool vretour = true;
            try
            {
                // ajout dans la table inscrit
                unInscrit = new inscrit();
                unInscrit.NOMINSCRIT = nom;
                unInscrit.PRENOMINSCRIT = prenom;
                unInscrit.MAIL = mail;
                unInscrit.MDPINSCRIT = mdp;
                unInscrit.TELINSCRIT = tel;
                unInscrit.DATENAISSANCE = date.Date;
                unInscrit.ADRESSE = adresse;
                unInscrit.CREDIT = credit;
                unInscrit.ADMIN = (short)admin;
                unInscrit.STATUT = (short)statut;
                maConnexion.inscrit.Add(unInscrit);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

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

        public static bool ModifierMessage(int idMessage, string libelle, int traiter)
        {
            bool vretour = true;
            try
            {
                unMessage = RecupererMessage(idMessage);
                unMessage.LIBELLEMESSAGE = libelle;
                unMessage.TRAITER = (short)traiter;
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool ModifierReponse(int idInscrit, int idService, DateTime dateRep)
        {
            bool vretour = true;
            try
            {
                uneReponse = RecupererReponse(idInscrit);
                uneReponse.IDSERVICE = idService;
                uneReponse.DATEREP = dateRep;
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }
        public static bool ModifierService(int idService, string descriptif, string photo, DateTime dateReponse, int duree, int prix, int realiser, int departement)
        {
            bool vretour = true;
            try
            {
                unService = RecupererService(idService);
                unService.DESCRIPTIFSERVICE = descriptif;
                unService.PHOTO = photo;
                unService.DATEDEBUT = dateReponse;
                unService.DUREEJOURS = duree;
                unService.PRIX = prix;
                unService.REALISER = realiser;
                unService.IDDEPARTEMENT = departement;
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

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
        public static void init()
        {
            maConnexion = new ap4Entities();
        }
        public static List<inscrit> listeInscrit()
        {
            return maConnexion.inscrit.ToList();
        }

        public static List<service> listeService()
        {
            return maConnexion.service.ToList();
        }

        public static List<repondre> listeReponse()
        {
            return maConnexion.repondre.ToList();
        }

        public static List<message> listeMessage()
        {
            return maConnexion.message.ToList();
        }

        public static bool VerifInscrit(string mail, string mdp)
        {
            try
            {
                inscrit unInscrit = new inscrit();
                unInscrit = maConnexion.inscrit.First(x => x.MAIL == mail && x.MDPINSCRIT == mdp);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

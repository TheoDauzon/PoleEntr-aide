using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4
{
    public static class Modele // bien mettre vos noms
    {
        private static ap4 maConnexion;
        public static void init()
        {
            maConnexion = new bd_partitionsEntities();
        }
        public static List<> listeClients()
        {
            return maConnexion.client.ToList();
        }
    }
}

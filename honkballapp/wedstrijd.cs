using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace honkballapp
{
    public class wedstrijd
    {
        public int wedstrijdID { get; private set; }

        public int uitteamID { get; private set; }

        public int thuisteamID { get; private set; }

        public int puntenthuisTeam { get; private set; }
        public int puntenuitTeam { get; private set; }
    }
}

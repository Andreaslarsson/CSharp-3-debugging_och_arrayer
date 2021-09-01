using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KomplexaDatatyperKata
{
    class Kund
    {
        public string Produktnamn;
        public int Ordernummer;
        public DateTime Beställningstid;
        public string[] Kundvagn;

        public Kund(string name)
        {
            Produktnamn = name;
        }

    }

    
}

using System;
using Xunit;

namespace orders
{
    class kundinfo
    {
        public string produktnamn;
        public int ordernummer;
        public DateTime bestdate;
        public int betalsumma;

        public kundinfo(string produktnamn, int ordernummer, int betalsumma)
        {
            bestdate = DateTime.Now;
            this.produktnamn = produktnamn;
            Random a = new Random(Guid.newGuid().GetHashCode());
            ordernummer = a.Next(0, 10);
            this.betalsumma = betalsumma;
        }
        
    }
}
class kundinfo
{
    public string produktnamn;
    public int ordernummer;
    public DateTime bestdate;
    public int betalsumma;



}

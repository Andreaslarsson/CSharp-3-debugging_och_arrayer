using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexaDatatyperKata
{
    class OnlineOrder
    {
        public int OrderNumber;

        private static int _nextAvailableOrdernumber = 1;

        public OnlineOrder()
        {
            OrderNumber = _nextAvailableOrdernumber;
            _nextAvailableOrdernumber += 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // Member Variables (HAS A)
        public double money;
        public double moneyDayBegin;
        public double moneyDayEnd;
        public int cups;
        public int lemons;
        public int sugar;
        public int ice;

        // Constructor
        public Player()
        {
            money = 20.00;
            cups = 0;
            lemons = 0;
            sugar = 0;
            ice = 0;
        }
        // Member Methods (CAN DO)
    }
}

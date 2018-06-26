using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        // Member Variables (HAS A)
        Weather weather;
        // Constructor
        public Day(Player player)
        {
            weather = new Weather();
            player.ice = 0;
            player.moneyDayBegin = player.money;
            player.moneyDayEnd = 0;
            Random random = new Random();
            int randomNum = random.Next(1, 7);
            if(randomNum == 3)
            {
                player.lemons -= (player.lemons / 10);
            }
        }
        // Member Methods (CAN DO)
    }
}

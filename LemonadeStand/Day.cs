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
        readonly Weather weather;
        readonly Customer customer;
        // Constructor
        public Day(Player player)
        {
            weather = new Weather();
            Random random = new Random();
            double customerBuyRate = random.Next(1, 100);
            customer = new Customer(CalculateCustomerBuyRate());
            player.ice = 0;
            player.moneyDayBegin = player.money;
            player.moneyDayEnd = 0;
            int randomNum = random.Next(1, 7);
            if(randomNum == 3)
            {
                player.lemons -= (player.lemons / 10);
            }
            
        }
        public double CalculateCustomerBuyRate()
        {
            double buyRate = 0;
            double result;

            buyRate += weather.temperature / 1.5;
            if(weather.clouds)
            {
                buyRate -= 5;
            }
            if(weather.rain)
            {
                buyRate -= 10;
            }
            //if()
            {

            }
            result = buyRate;
            return result;

        }
    }
}

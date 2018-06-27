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
        Random random = new Random();
        
        // Constructor
        public Day(Player player)
        {
            player.moneyDayBegin = player.money;
            player.moneyDayEnd = 0;
            player.ice = 0;
            
            weather = new Weather();
            customer = new Customer( weather, player);
        }
        
        public void DailyWeatherReport()
        {
            Console.WriteLine("\r\nCurrent Weather Forcast:\r\nForcasted Temperature - {0}\r\nForcasted Sky Condition - {1}", weather.temperature, weather.skyCondition);

        }
        public void EndOfDayTotal(Day day, Player player, UserInterface userInterface)
        {
            player.moneyDayEnd = player.money;
            if (player.moneyDayBegin > player.moneyDayEnd)
            {
                Console.WriteLine("\r\nToday You Lost: ${0}", Math.Round(player.moneyDayBegin - player.moneyDayEnd));
            }
            else
            {
                Console.WriteLine("\r\nToday You Made: ${0}", (player.moneyDayEnd - player.moneyDayBegin));
            }
            userInterface.ShowCustomerPurchase(customer, player);
        }
    }
}

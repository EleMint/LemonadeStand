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
            double customerBuyRate = random.Next(1, 100);
            customer = new Customer(CalculateCustomerBuyRate());
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
        public void DailyWeatherReport()
        {
            Console.WriteLine("\r\nCurrent Weather Forcast:\r\nForcasted Temperature - {0}\r\nForcasted Sky Condition - {1}", weather.temperature, weather.skyCondition);

        }
    }
}

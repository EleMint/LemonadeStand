using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        // Member Variables (HAS A)
        public double chanceOfRain;
        public double chanceOfClouds;
        public double temperature;
        public bool clouds;
        public bool rain;
        // Constructor
        public Weather()
        {
            Random random = new Random();
            double randomNum = random.Next(1, 100);
            double randomNum2 = random.Next(1, 100);
            int randomTemp = random.Next(65, 95);
            temperature = randomTemp;
            chanceOfClouds = randomNum / 100;
            if(chanceOfClouds > 0.5)
            {
                clouds = true;
            }
            else
            {
                clouds = false;
            }
            chanceOfRain = randomNum2 / 100;
            if(chanceOfRain > 0.5)
            {
                rain = true;
            }
            else
            {
                rain = false;
            }

        }
    }
}

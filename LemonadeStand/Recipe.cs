using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        // Member Variables (HAS A)
        public int lemons;
        public int sugar;
        public int ice;
        public double pricePerCup;
        // Constructor
        public Recipe(int lemons, int sugar, int ice, double pricePerCup)
        {
            this.lemons = lemons;
            this.sugar = sugar;
            this.ice = ice;
            this.pricePerCup = pricePerCup;
        }
        // Member Methods (CAN DO)
        public void CalculateDailyItemUsage(Player player, int lemons, int sugar, int ice)
        {
            player.lemons -= lemons;
            player.sugar -= sugar;
            player.ice -= ice;
        }
    }
}

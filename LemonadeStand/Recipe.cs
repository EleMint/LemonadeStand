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
        int lemons;
        int sugar;
        int ice;
        // Constructor
        public Recipe(int lemons, int sugar, int ice)
        {
            this.lemons = lemons;
            this.sugar = sugar;
            this.ice = ice;
        }
        // Member Methods (CAN DO)
        public void CalculateDailyUsage()
        {

        }
    }
}

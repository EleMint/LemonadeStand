using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        // Member Variables (HAS A)

        // Constructor
        public Store()
        {

        }
        // Member Methods (CAN DO)
        public void CalculatePricePerItem(int itemCount, Player player)
        {
            // += itemCount;
            if (itemCount > 0 && itemCount < 25)
            {
                DecreasePlayerMoney(itemCount * 0.07, player);
            }
            else if (itemCount >= 25 && itemCount < 75)
            {
                DecreasePlayerMoney(itemCount * 0.04, player);
            }
            else if (itemCount >= 75)
            {
                DecreasePlayerMoney(itemCount * 0.03, player);
            }

        }
        public void DecreasePlayerMoney(double amount, Player player)
        {
            player.money -= amount;
        }
        public void IncreasePlayerMoney(double amount, Player player)
        {
            player.money += amount;
        }
    }
}

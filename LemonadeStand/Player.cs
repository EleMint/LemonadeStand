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
        Inventory inventory;
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
            inventory = new Inventory();
            money = 20.00;
            cups = 0;
            lemons = 0;
            sugar = 0;
            ice = 0;
        }
        // Member Methods (CAN DO)
       public void BuyProduct()
        {
            Console.WriteLine("What Would You Like To Purchace? (Cups, Lemons, Sugar, Ice)");
            string item = Console.ReadLine().ToLower();
            switch(item)
            {
                case "cups":
                    Console.WriteLine("How Many Cups Would You Like To Buy?");
                    int amount = int.Parse(Console.ReadLine());
                    
                    break;
                case "lemons":
                    break;
                case "sugar":
                    break;
                case "ice":
                    break;
                default:
                    BuyProduct();
                    break;
            }
        }
    }
}

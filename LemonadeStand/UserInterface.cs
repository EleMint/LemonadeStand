using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        // Member Variables (HAS A)

        // Constructor
        public UserInterface()
        {

        }

        // Member Methods (CAN DO)
        public int AskGameLength()
        {
            Console.WriteLine("How Many Days Would You Like To Play For? (7, 14, or 21)");
            int gameLength = int.Parse(Console.ReadLine());
            if (gameLength == 7 || gameLength == 14 || gameLength == 21)
            {
                return gameLength;
            }
            else
            {
                AskGameLength();
            }
            return 7;
        }
        public void AskToBuyProduct(Player player)
        {
            Console.WriteLine("Is There Anything You'd Like To Buy?");
            string userAnswer = Console.ReadLine().ToLower();
            switch(userAnswer)
            {
                case "yes":
                    player.BuyProduct();
                    break;
                case "no":
                    break;
                default:
                    AskToBuyProduct(player);
                    break;
            }
        }
    }
}

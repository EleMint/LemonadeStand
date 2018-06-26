using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        // Constructor
        public UserInterface()
        {
            ShowIntroduction();
        }
        // Member Methods (CAN DO)
        public void ShowIntroduction()
        {
            Console.WriteLine("\t \tWelcome To Your Lemonade Stand\r\nThe Rules Are Simple: Buy Materials, Make Your Lemonade, And Make Money.\r\nHow Much Money Can You Make At The End Of A Week, Two, Or Three?");
        }
        public int AskGameLength()
        {
            Console.WriteLine("\r\nHow Many Days Would You Like To Play For? (7, 14, or 21)");
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
        public string AskToBuyProduct(Player player, Store store)
        {
            Console.WriteLine("\r\nIs There Anything You'd Like To Buy?");
            string userAnswer = Console.ReadLine().ToLower().Trim();
            switch(userAnswer)
            {
                case "yes":
                    store.BuyProduct(player);
                    return "yes";
                case "no":
                    return "no";
                default:
                    AskToBuyProduct(player, store);
                    return "yes";
            }
        }
        public void AskForRecipe(Player player)
        {
            Console.WriteLine("\r\nTime To Input Your Lemonade Recipe.");
            player.InputRecipe();
        }
        public void ShowCurrentDay(int currentDay, Player player)
        {
            Console.WriteLine("\r\nBeginning of Day {0}", currentDay);
        }
        public void ShowEndOfDayTotal(Player player)
        {
            if(player.moneyDayBegin > player.moneyDayEnd)
            {
                Console.WriteLine("\r\nYour Daily Loss Is: {0}", player.moneyDayBegin - player.moneyDayEnd);
            }
            else
            {
                Console.WriteLine("\r\nYour Daily Profit Is: {0}", player.moneyDayEnd - player.moneyDayBegin);
            }
        }
        public void AskToPlayAgain()
        {
            Console.WriteLine("\r\nWould You Like To Play Again?");
            string userInput = Console.ReadLine().ToLower().Trim();
            switch (userInput)
            {
                case "yes":
                    Console.Clear();
                    Game newGame = new Game();
                    newGame.RunGame();
                    break;
                case "no":
                    Console.WriteLine("Thanks For Playing!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case "quit":
                    Console.WriteLine("Thanks For Playing!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    AskToPlayAgain();
                    break;
            }
        }
    }
}

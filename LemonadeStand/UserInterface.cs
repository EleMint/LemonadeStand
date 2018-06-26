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

        public void DailyWeatherReport(Game game, Weather weather)
        {
            Console.WriteLine("\r\nDay {0} Current Weather Forcast.\r\nForcasted Temperature: {1}\r\nForcasted Sky Condition: {2}", game.currentDay, weather.temperature, weather.skyCondition);

        }

        public void AskForRecipe(Player player)
        {
            Console.WriteLine("\r\nTime To Input Your Lemonade Recipe.\r\nHow Many Lemons Would You Like To Use? You Currently Have: {0}", player.lemons);
            int inputLemons = int.Parse(Console.ReadLine().Trim());
            while(inputLemons > player.lemons)            
            {
                Console.WriteLine("You Do Not Have {0} Lemons, Please Enter An Amount Less Than Or Equal To How Many Lemons You Currently Have.", inputLemons);
                Console.WriteLine("How Many Lemons Would You Like To Use?");
                inputLemons = int.Parse(Console.ReadLine().Trim());
            }
            Console.WriteLine("\r\nHow Much Sugar Would You Like To Use? You Currently Have: {0}", player.sugar);
            int inputSugar = int.Parse(Console.ReadLine().Trim());
            while(inputSugar > player.sugar)            
            {
                Console.WriteLine("You Do Not Have {0} Sugar, Please Enter An Amount Less Than Or Equal To How Many Sugar You Currently Have.", inputSugar);
                Console.WriteLine("How Much Sugar Would You Like To Use?");
                inputSugar = int.Parse(Console.ReadLine().Trim());
            }
            Console.WriteLine("\r\nHow Many Ice Cubes Would You Like To Use Per Cup? YOu Currently Have: {0}", player.ice);
            int inputIce = int.Parse(Console.ReadLine().Trim());
            while (inputIce > player.ice)
            {
                Console.WriteLine("You Do Not Have {0} Ice, Please Enter An Amount Less Than Or Equal To How Much Ice You Currently Have.", inputIce);
                Console.WriteLine("How Much Ice Would You Like To Use?");
                inputIce = int.Parse(Console.ReadLine().Trim());
            }
            player.InputRecipe(inputLemons, inputSugar, inputIce);
            
        }

        public void ShowCurrentDay(int currentDay, Player player)
        {
            Console.WriteLine("\r\nBeginning of Day {0}", currentDay);
        }

        public void ShowEndOfDayTotal(Player player)
        {
            if(player.moneyDayBegin > player.moneyDayEnd)
            {
                Console.WriteLine("\r\nToday You Lost: ${0}", (player.moneyDayBegin - player.moneyDayEnd));
            }
            else
            {
                Console.WriteLine("\r\nToday You Made: ${0}", (player.moneyDayEnd - player.moneyDayBegin));
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
                    Console.WriteLine("\r\nThanks For Playing!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case "quit":
                    Console.WriteLine("\r\nThanks For Playing!");
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

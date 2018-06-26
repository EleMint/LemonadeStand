using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        // Member Variables (HAS A)
        Player player;
        UserInterface userInterface;
        Store store;
        public int gameLength;
        public int currentDay;
        // Constructor
        public Game()
        {
            player = new Player();
            userInterface = new UserInterface();
            store = new Store();
            currentDay = 0;
        }

        // Member Methods (CAN DO)
        public void RunGame()
        {
            AskForInstructions();
            gameLength = userInterface.AskGameLength();
            do
            {
                RunDaily();
            }
            while (currentDay < gameLength);
            userInterface.AskToPlayAgain();

        }
        public void RunDaily()
        {
            currentDay++;
            userInterface.ShowCurrentDay(currentDay, player);
            Day newDay = new Day(player);
            newDay.DailyWeatherReport();
            string userInput;
            do
            {
                userInput = AskToBuyProduct();
            }
            while (userInput == "yes");
            userInterface.AskForRecipe(player);
            userInterface.ShowEndOfDayTotal(player);
        }
        public string AskToBuyProduct()
        {
            return userInterface.AskToBuyProduct(player, store);
        }
        public void AskForInstructions()
        {
            Console.WriteLine("\r\nWould You Like To Read The Instructions?");
            string userAnswer = Console.ReadLine().ToLower().Trim();
            switch (userAnswer)
            {
                case "yes":
                    userInterface.ShowInstructions();
                    break;
                default:
                    break;
            }

        }
        
    }
}

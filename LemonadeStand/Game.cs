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
        public Player player;
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
            userInterface.ShowIntroduction();
            gameLength = userInterface.AskGameLength();
            do
            {
                currentDay++;
                userInterface.ShowCurrentDay(currentDay,player);
                NewDay();
                string userInput;
                do
                {
                    userInput = userInterface.AskToBuyProduct(player, store);
                }
                while (userInput == "yes");

                userInterface.ShowEndOfDayTotal();
            }
            while (currentDay < gameLength);
            Console.WriteLine("end of program");
            Console.ReadLine();
            Environment.Exit(0);

        }
        public void NewDay()
        {
            Day newDay = new Day();
        }
    }
}

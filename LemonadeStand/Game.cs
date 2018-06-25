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
        private int gameLength;
        // Constructor
        public Game()
        {
            player = new Player();
            userInterface = new UserInterface();
            store = new Store();
        }

        // Member Methods (CAN DO)
        public void RunGame()
        {

            gameLength = userInterface.AskGameLength();
            Console.WriteLine("Player Money: $" + player.money);
            Console.WriteLine("Player Cups: " + player.cups);
            userInterface.AskToBuyProduct(player, store);
            Console.WriteLine("Player Money: $" + player.money);
            Console.WriteLine("Player Cups: " + player.cups);
            Console.WriteLine("Player Money: $" + player.money);
            Console.ReadLine();

        }
    }
}

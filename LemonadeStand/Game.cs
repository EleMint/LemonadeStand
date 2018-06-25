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
        private int gameLength;
        // Constructor
        public Game()
        {
            player = new Player();
            userInterface = new UserInterface();
        }

        // Member Methods (CAN DO)
        public void RunGame()
        {

            gameLength = userInterface.AskGameLength();
            
        }
    }
}

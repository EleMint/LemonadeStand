﻿using System;
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
            player.ShowInventory();
            Console.WriteLine("Is There Anything You'd Like To Buy?");
            string userAnswer = Console.ReadLine().ToLower();
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
        public void AskForRecipe()
        {

        }
        public void ShowCurrentDay(int currentDay)
        {
            Console.WriteLine("\r\nDay: {0}", currentDay);
        }
    }
}

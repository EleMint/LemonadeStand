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
        public void BuyProduct(Player player)
        {
            Console.WriteLine("Prices: Amount < 25 --> $0.07 / Item, 25 <= Amount < 75 --> $0.04 / Item, 75 <= Amount --> $0.03 / Item.\r\nWhat Would You Like To Purchace? (Cups, Lemons, Sugar, Ice)");
            string item = Console.ReadLine().ToLower();
            switch (item)
            {
                case "cups":
                    bool isValid;
                    do
                    {
                        Console.WriteLine("How Many Cups Would You Like To Buy?");
                        int amount = int.Parse(Console.ReadLine());
                        isValid = PricePerItem(amount, player);
                        if (isValid)
                        {
                            player.cups += amount;
                        }
                        else
                        {
                            Console.WriteLine("You Do Not Have Enough Money");
                        }

                    }
                    while (!isValid);
                    break;
                case "lemons":
                    Console.WriteLine("How Many Lemons Would You Like To Buy?");
                    int amount2 = int.Parse(Console.ReadLine());
                    bool isValid2 = PricePerItem(amount2, player);
                    if (isValid2)
                    {
                        player.lemons += amount2;
                    }
                    else
                    {
                        Console.WriteLine("You Do Not Have Enough Money");
                        BuyProduct(player);
                    }
                    break;
                case "sugar":
                    Console.WriteLine("How Much Sugar Would You Like To Buy?");
                    int amount3 = int.Parse(Console.ReadLine());
                    bool isValid3 = PricePerItem(amount3, player);
                    if (isValid3)
                    {
                        player.sugar += amount3;
                    }
                    else
                    {
                        Console.WriteLine("You Do Not Have Enough Money");
                        BuyProduct(player);
                    }
                    break;
                case "ice":
                    Console.WriteLine("How Much Ice Would You Like To Buy?");
                    int amount4 = int.Parse(Console.ReadLine());
                    bool isValid4 = PricePerItem(amount4, player);
                    if (isValid4)
                    {
                        player.sugar += amount4;
                    }
                    else
                    {
                        Console.WriteLine("You Do Not Have Enough Money");
                        BuyProduct(player);
                    }
                    break;
                default:
                    BuyProduct(player);
                    break;
            }
        }
        public bool PricePerItem(int itemCount, Player player)
        {
            bool isValid = true;
            if (itemCount > 0 && itemCount < 25)
            {
                isValid = DecreasePlayerMoney(itemCount * 0.07, player);
            }
            else if (itemCount >= 25 && itemCount < 75)
            {
                isValid = DecreasePlayerMoney(itemCount * 0.04, player);
            }
            else if (itemCount >= 75)
            {
                isValid = DecreasePlayerMoney(itemCount * 0.03, player);
            }
            return isValid;
        }
        public bool DecreasePlayerMoney(double amount, Player player)
        {
            if(player.money - amount < 0)
            {
                return false;
            }
            else
            {
                player.money -= amount;
                return true;
            }
        }
        public void IncreasePlayerMoney(double amount, Player player)
        {
            player.money += amount;
        }
    }
}

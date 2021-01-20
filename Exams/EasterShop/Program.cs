using System;

namespace EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            string input = "";
            int soldEggs = 0;

            while (input != "Close")
            {
                input = Console.ReadLine();
                if (input == "Close")
                {
                    Console.WriteLine($"Store is closed!");
                    Console.WriteLine($"{soldEggs} eggs sold.");
                    break;
                }
                if (input == "Fill")
                {

                    int fillEggs = int.Parse(Console.ReadLine());
                    quantity += fillEggs;
                }
                if (input == "Buy")
                {

                    int buyEggs = int.Parse(Console.ReadLine());
                    if (buyEggs > quantity)
                    {
                        Console.WriteLine($"Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {quantity}.");
                        break;
                    }
                    else
                    {
                        quantity -= buyEggs;
                        soldEggs += buyEggs;
                    }
                }
            }
        }
    }
}
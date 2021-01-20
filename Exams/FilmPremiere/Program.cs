using System;

namespace FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            string package = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;
            if (film == "John Wick")
            {
                if (package == "Drink") { price = 12.0 * quantity; }
                else if (package == "Popcorn") { price = 15.00 * quantity; }
                else { price = 19.00 * quantity; }
            }
            else if (film == "Star Wars")
            {
                if (package == "Drink") { price = 18.0 * quantity; }
                else if (package == "Popcorn") { price = 25.00 * quantity; }
                else { price = 30.00 * quantity; }
            }
            else
            {
                if (package == "Drink") { price = 9.0 * quantity; }
                else if (package == "Popcorn") { price = 11.00 * quantity; }
                else { price = 14.00 * quantity; }
            }

            if (film == "Star Wars" && quantity >= 4) { price = price * 0.70; }
            if (film == "Jumanji" && quantity == 2) { price = price * 0.85; }
            Console.WriteLine($"Your bill is {price:f2} leva.");
        }
    }
}
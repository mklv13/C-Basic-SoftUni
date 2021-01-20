using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double costs = 0;
            for (int i = 0; i < n; i++)
            {
                string serie = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                if (serie == "Thrones")
                {
                    price = 0.5 * price;
                    costs += price;
                }
                else if (serie == "Lucifer")
                {
                    price = 0.6 * price;
                    costs += price;
                }
                else if (serie == "Protector")
                {
                    price = 0.7 * price;
                    costs += price;
                }
                else if (serie == "TotalDrama")
                {
                    price = 0.8 * price;
                    costs += price;
                }
                else if (serie == "Area")
                {
                    price = 0.9 * price;
                    costs += price;
                }
                else
                {
                    costs += price;
                }

            }
            if (budget < costs)
            {

                Console.WriteLine($"You need {costs - budget:f2} lv. more to buy the series!");

            }
            if (budget >= costs)
            {
                Console.WriteLine($"You bought all the series and left with {budget - costs:f2} lv.");
            }
        }
    }
}
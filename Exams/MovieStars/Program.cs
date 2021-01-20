using System;

namespace MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double neededMoney = 0;
            while (budget > 0 && command != "ACTION")
            {
                string actor = command;
                int a = actor.Length;
                if (a <= 15)
                {
                    double honorarium = double.Parse(Console.ReadLine());
                    budget -= honorarium;
                }
                else
                {
                    budget -= (0.2 * budget);
                }
                if (budget < 0)
                {
                    neededMoney = Math.Abs(budget);
                    break;
                }
                command = Console.ReadLine();
            }
            if (budget >= 0)
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {neededMoney:f2} leva for our actors.");
            }
        }
    }
}
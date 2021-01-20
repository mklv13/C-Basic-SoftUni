using System;

namespace EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs1 = int.Parse(Console.ReadLine());
            int eggs2 = int.Parse(Console.ReadLine());

            while (eggs1 > 0 && eggs2 > 0)
            {
                string winner = Console.ReadLine();

                if (winner == "one")
                {
                    eggs2--;
                }
                else if (winner == "two")
                {
                    eggs1--;
                }

                if (winner == "End of battle")
                {
                    Console.WriteLine($"Player one has {eggs1} eggs left.");
                    Console.WriteLine($"Player two has {eggs2} eggs left."); break;
                }
            }
            if (eggs1 == 0)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {eggs2} eggs left.");
            }
            else if (eggs2 == 0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {eggs1} eggs left.");
            }
        }
    }
}
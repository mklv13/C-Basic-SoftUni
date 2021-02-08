using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int countFloor = int.Parse(Console.ReadLine());
            int countChambers = int.Parse(Console.ReadLine());

            for (int i = countFloor; i >= 1; i--)
            {
                Console.WriteLine();
                for (int j = 0; j < countChambers; j++)
                {

                    if (countFloor == 1 || i == countFloor)
                    {
                        Console.Write($"L{i}{j} ");

                    }

                    else if (i % 2 != 0)
                    {
                        Console.Write($"A{i}{j} ");

                    }

                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");

                    }
                }
            }
        }
    }
}
using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double result = 0;
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;
            double n4 = 0;
            double n5 = 0;
            double n6 = 0;

            for (int i = 0; i < moves; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= 0 && number < 10)
                {
                    result += number * 0.2;
                    n1++;
                }
                else if (number >= 10 && number < 20)
                {
                    result += number * 0.3;
                    n2++;
                }
                else if (number >= 20 && number < 30)
                {
                    result += number * 0.4;
                    n3++;
                }
                else if (number >= 30 && number < 40)
                {
                    result += 50;
                    n4++;
                }
                else if (number >= 40 && number <= 50)
                {
                    result += 100;
                    n5++;
                }
                else
                {
                    result /= 2;
                    n6++;
                }
            }
            double persentN1 = n1 / moves * 100;
            double persentN2 = n2 / moves * 100;
            double persentN3 = n3 / moves * 100;
            double persentN4 = n4 / moves * 100;
            double persentN5 = n5 / moves * 100;
            double persentN6 = n6 / moves * 100;
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {persentN1:f2}%");
            Console.WriteLine($"From 10 to 19: {persentN2:f2}%");
            Console.WriteLine($"From 20 to 29: {persentN3:f2}%");
            Console.WriteLine($"From 30 to 39: {persentN4:f2}%");
            Console.WriteLine($"From 40 to 50: {persentN5:f2}%");
            Console.WriteLine($"Invalid numbers: {persentN6:f2}%");


        }
    }
}
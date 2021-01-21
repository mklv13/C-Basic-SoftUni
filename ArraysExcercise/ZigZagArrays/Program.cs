using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            int[,] myArray = new int[size, 2];
            int[] first = new int[size];
            int[] second = new int[size];

            for (int i = 0; i < myArray.Length / 2; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < 2; j++)
                {
                    myArray[i, j] = input[j];
                }
            }

            for (int i = 0; i < myArray.Length / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        first[i] = myArray[i, j];
                    }
                    else if (i % 2 != 0 && j % 2 != 0)
                    {
                        first[i] = myArray[i, j];
                    }
                    else
                    {
                        second[i] = myArray[i, j];
                    }
                }
            }
            foreach (var item in first)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            foreach (var item in second)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
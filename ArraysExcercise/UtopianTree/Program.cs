using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currNum = numbers[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int otherNum = numbers[j];
                    if (currNum <= otherNum)
                    {
                        isTopInteger = false;
                        break;
                    }

                }

                if (isTopInteger)
                {
                    Console.Write(currNum + " ");
                }
            }

            Console.WriteLine(numbers[numbers.Length - 1]);

        }
    }
}
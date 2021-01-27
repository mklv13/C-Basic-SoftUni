using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split()
                .ToList();

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                char[] arr = numbers[i].ToCharArray();
                Array.Reverse(arr);
                string number = new string(arr);
                int num = int.Parse(number);
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
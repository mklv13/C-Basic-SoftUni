using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonCount = int.Parse(Console.ReadLine());
            int[] train = new int[wagonCount];

            for (int i = 0; i < wagonCount; i++)
            {
                int peopleInWagon = int.Parse(Console.ReadLine());

                train[i] = peopleInWagon;
            }
            int sum = train.Sum();
            for (int i = 0; i < train.Length; i++)
            {
                Console.Write(train[i] + " ");
            }
            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(sum);

        }
    }
}
﻿using System;

namespace EvenPowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());

            for (int i = 0; i <= power; i += 2)
            {

                double result = Math.Pow(2, i);
                Console.WriteLine(result);

            }
        }
    }
}
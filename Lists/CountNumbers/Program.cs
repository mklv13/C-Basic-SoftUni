﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> occurances = new List<int>();

            for (int i = 0; i < 1000; i++) occurances.Add(0);

            foreach (var num in nums) occurances[num]++;

            for (int num = 0; num < occurances.Count; num++) if (occurances[num] > 0)
                    Console.WriteLine(num + " -> " + occurances[num]);
        }
    }
}
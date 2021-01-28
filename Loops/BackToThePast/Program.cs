using System;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int yearInPast = int.Parse(Console.ReadLine());
            double sumOddY = 0;
            double sumEvenY = 0;
            int counterYearIvan = 18;
            double totalCosts = 0;
            for (int i = 1800; i <= yearInPast; i++)
            {
                if (i % 2 == 0)
                {
                    sumEvenY = 12000;
                    heritage -= sumEvenY;


                }
                else
                {
                    sumOddY = (12000 + (50 * counterYearIvan));
                    heritage -= sumOddY;
                }
                counterYearIvan++;

            }


            if (heritage >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {(heritage):f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(heritage):f2} dollars to survive.");
            }
        }
    }
}
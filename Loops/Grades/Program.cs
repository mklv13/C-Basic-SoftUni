using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double s1 = 0;
            double s2 = 0;
            double s3 = 0;
            double s4 = 0;
            double totalgrades = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 5.00)
                {
                    s1++;
                }
                else if (grade >= 4.00 && grade < 5.00)
                {
                    s2++;
                }
                else if (grade >= 3.00 && grade < 4.00)
                {
                    s3++;
                }
                else
                {
                    s4++;
                }

                totalgrades += grade;
            }

            double persentS1 = s1 / students * 100.00;
            double persentS2 = s2 / students * 100.00;
            double persentS3 = s3 / students * 100.00;
            double persentS4 = s4 / students * 100.00;
            double aberageGrade = totalgrades / students;
            Console.WriteLine($"Top students: {persentS1:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {persentS2:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {persentS3:f2}%");
            Console.WriteLine($"Fail: {persentS4:f2}%");
            Console.WriteLine($"Average: {aberageGrade:f2}");

        }
    }
}
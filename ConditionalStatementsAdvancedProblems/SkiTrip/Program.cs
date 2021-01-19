using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string evaluation = Console.ReadLine();
            double priceOnePerson = 18.0;
            double priceApart = 25.0;
            double pricePresApart = 35.0;
            double posistivIndex0 = 1.25;
            double negativIndex = 0.9;
            double price = 0.0;
            days = days - 1;
            if (days > 0 && days < 10)
            {
                if (roomType == "room for one person" && evaluation == "positive")
                { price = (days * priceOnePerson) * posistivIndex0; }
                else if (roomType == "apartment" && evaluation == "positive")
                { price = (days * priceApart * 0.70) * posistivIndex0; }
                else if (roomType == "president apartment" && evaluation == "positive")
                { price = (days * pricePresApart * 0.90) * posistivIndex0; }
                else if (roomType == "room for one person" && evaluation == "negative") { price = (days * priceOnePerson) * negativIndex; }
                else if (roomType == "apartment" && evaluation == "negative")
                { price = (days * priceApart * 0.70) * negativIndex; }
                else if (roomType == "president apartment" && evaluation == "negative") { price = (days * pricePresApart * 0.90) * negativIndex; }
            }
            else if (days > 10 && days <= 15)
            {
                if (roomType == "room for one person" && evaluation == "positive")
                { price = (days * priceOnePerson) * posistivIndex0; }
                else if (roomType == "apartment" && evaluation == "positive")
                { price = (days * priceApart * 0.65) * posistivIndex0; }
                else if (roomType == "president apartment" && evaluation == "positive")
                { price = (days * pricePresApart * 0.85) * posistivIndex0; }
                else if (roomType == "room for one person" && evaluation == "negative") { price = (days * priceOnePerson) * negativIndex; }
                else if (roomType == "apartment" && evaluation == "negative")
                { price = (days * priceApart * 0.65) * negativIndex; }
                else if (roomType == "president apartment" && evaluation == "negative") { price = (days * pricePresApart * 0.85) * negativIndex; }
            }
            else if (days > 15)
            {
                if (roomType == "room for one person" && evaluation == "positive")
                { price = (days * priceOnePerson) * posistivIndex0; }
                else if (roomType == "apartment" && evaluation == "positive")
                { price = (days * priceApart * 0.50) * posistivIndex0; }
                else if (roomType == "president apartment" && evaluation == "positive")
                { price = (days * pricePresApart * 0.80) * posistivIndex0; }
                else if (roomType == "room for one person" && evaluation == "negative") { price = (days * priceOnePerson) * negativIndex; }
                else if (roomType == "apartment" && evaluation == "negative")
                { price = (days * priceApart * 0.50) * negativIndex; }
                else if (roomType == "president apartment" && evaluation == "negative") { price = (days * pricePresApart * 0.80) * negativIndex; }
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
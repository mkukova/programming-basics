using System;

namespace _08.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());
            double priseApartment = 0.0;
            double priseStudio = 0.0;
            double discountStudio = 0.0;
            double discountApartment = 0.0;
            switch (month)
            {
                case "may":
                case "october":
                    priseStudio = 50 * nights;
                    priseApartment = 65 * nights;
                    if (nights > 7 && nights <= 14)
                    {
                        discountStudio = 0.05 * priseStudio;
                        priseStudio = priseStudio - discountStudio;
                    }
                    else if (nights > 14)
                    {
                        discountStudio = 0.3 * priseStudio;
                        priseStudio = priseStudio - discountStudio;
                        discountApartment = 0.1 * priseApartment;
                        priseApartment = priseApartment - discountApartment;
                    }

                    break;
                case "june":
                case "september":
                    priseStudio = 75.20 * nights;
                    priseApartment = 68.70 * nights;
                    if (nights > 14)
                    {
                        discountStudio = 0.2 * priseStudio;
                        priseStudio = priseStudio - discountStudio;
                        discountApartment = 0.1 * priseApartment;
                        priseApartment = priseApartment - discountApartment;
                    }

                    break;
                case "july":
                case "august":
                    priseStudio = 76 * nights;
                    priseApartment = 77 * nights;
                    if (nights > 14)
                    {
                        discountApartment = 0.1 * priseApartment;
                        priseApartment = priseApartment - discountApartment;
                    }

                    break;
            }

            Console.WriteLine($"Apartment: {priseApartment:F2} lv.");
            Console.WriteLine($"Studio: {priseStudio:F2} lv.");
        }
    }
}


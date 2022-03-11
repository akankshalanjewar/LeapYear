using System;

namespace LeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {

            int year;

            Console.WriteLine("Enter the year");

            Random random = new Random();

            year = int.Parse(Console.ReadLine());



            if ((year % 100 == 0) && (year % 400 == 0) || (year % 4 == 0))
            {

                Console.WriteLine("is a leap year");
            }

            else
            {

                Console.WriteLine("is not a leap year");
            }

        }
    }
}

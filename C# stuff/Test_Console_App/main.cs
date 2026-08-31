using System;
using System.Net.NetworkInformation;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141592654;
            double radius = 5;
            double diameter = Double.NaN;
            double area;

            Console.WriteLine("Do you want to enter a diameter or radius? (d / r) ");
            
            string userInput = Console.ReadLine().Trim().ToLower();

            while (userInput != "d" && userInput != "r") {
                Console.WriteLine("Enter a valid Value. ");
                userInput = Console.ReadLine().Trim().ToLower();
            }

            if (userInput == "d") {
                Console.WriteLine("Enter A Value For The Diameter In Meters: ");
                userInput = Console.ReadLine();
                int.Parse(userInput);
            } else if (userInput == "r")
            {
                Console.WriteLine("Enter A Value For The Radius In Meters: ");
                userInput = Console.ReadLine();
                int.Parse(userInput);
            }

            if (Double.IsNaN(diameter))
            {
                area = pi * Math.Pow(radius, 2);
            } else {
                area = pi * Math.Pow(diameter/2, 2);
            }

            Console.WriteLine("The Area Is: ", area, "m.");
        }
    }
}
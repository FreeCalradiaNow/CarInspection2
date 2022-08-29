using System;

namespace CarInspection2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array von Autos
            string[] carNames = new string[6];
            carNames[0] = "Mercedes G";
            carNames[1] = "Audi A8";
            carNames[2] = "BMW 3";
            carNames[3] = "Audi A6";
            carNames[4] = "Hyundai";
            carNames[5] = "Toyota";

            Console.WriteLine("Bitte geben Sie einen Suchbegriff ein: ");

            string searchTerm = Console.ReadLine();

            Console.WriteLine("Der Suchbegriff ist: " + searchTerm);

            Console.WriteLine("Folgende Autos wurden gefunden: ");

            foreach(string carName in carNames)
            {
                if (carName.Contains(searchTerm))
                {
                    Console.WriteLine(carName);
                }


            } 
        }
    }
}

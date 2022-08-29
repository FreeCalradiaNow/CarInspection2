using System;

namespace CarInspection2
{
    class Program
    {
        static void Main()
        {
            // Array von Autos
            // string[] carNames = new string[6];
            // Array von Cars (von der Klasse)
            Car[] cars = new Car[6];
            cars[0] = new Car("Mercedes G", 2008);
            cars[1] = new Car("BMW 3", 2001);
            cars[2] = new Car("Audi A&", 2005);
            cars[3] = new Car("Audi A8", 2012);
            cars[4] = new Car("Hyundai", 2003);
            cars[5] = new Car("Toyota", 1995);

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
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}

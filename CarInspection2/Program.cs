using System;

namespace CarInspection2
{
    class Program
    {
        static void Main()
        {
            // Array von Autos
            //  string[] carNames = new string[6];
            //  string[0] = "Mercedes G"
            //  string[1] = "BMW 3", 
            //  string[2] = "Audi A6"
            //  string[3] = "Audi A8"
            //  string[4] = "Hyundai"
            //  string[5] = "Toyota"

            // Array mit der Klasse Car
            Car[] cars = new Car[6];
            cars[0] = new Car("Mercedes G", 2008);
            cars[1] = new Car("BMW 3", 2001);
            cars[2] = new Car("Audi A6", 2005);
            cars[3] = new Car("Audi A8", 2012);
            cars[4] = new Car("Hyundai", 2003);
            cars[5] = new Car("Toyota", 1995);

            Console.WriteLine("Bitte geben Sie einen Suchbegriff ein: ");

            string searchTerm = Console.ReadLine();

            Console.WriteLine("Der Suchbegriff ist: " + searchTerm);

            Console.WriteLine("Folgende Autos wurden gefunden: ");

            // gilt für Array von Autos
            //foreach(string carName in cars)
            foreach(Car car in cars)
            {
                if (car.carName.Contains(searchTerm))
                {
                    Console.WriteLine(car.carName + " Baujahr:: " + car.carBaujahr);
                }


            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}

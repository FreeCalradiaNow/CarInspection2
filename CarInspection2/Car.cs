using System;
using System.Collections.Generic;
using System.Text;

namespace CarInspection2
{
    class Car
    {
        public string carName = "Name";
        public int carBaujahr = 1995;
        public int carLastinspectionYear = 2010;

        // Konstruktor (wird aufgerufen wenn ein Object aus der Car-Klasse erstellt wird)
        public Car (string newName, int newBaujahr)
        {
            carName = newName;
            carBaujahr = newBaujahr;
        }
    }
}

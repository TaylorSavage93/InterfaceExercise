using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool FourWheelDrive { get; set; }
        public bool Lifted { get; set; }
        public int NumberOfWheels { get; set; }
        public string StickOrAuto { get; set; }
        public double EngineSize { get; set; }
        public double Year { get; set; }
        public string Name { get; set; }
        public double NumberOfEmployees { get; set; }

        public void ChangeGears()
        {
            Console.WriteLine("Truck is changing gears from neutral to drive.");
        }

        public void Drive()
        {
            Console.WriteLine("Truck is now in drive, turning right.");
        }

        public void Reverse()
        {
            Console.WriteLine("Truck is backing into a parking spot.");
        }
    }
}

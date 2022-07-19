using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool Trunk { get; set; }
        public string ElectricOrGas { get; set; }
        public int NumberOfWheels { get; set; }
        public string StickOrAuto { get; set; }
        public double EngineSize { get; set; }
        public double Year { get; set; }
        public string Name { get; set; }
        public double NumberOfEmployees { get; set; }

        public void ChangeGears()
        {
            Console.WriteLine("Car is now changing from reverse to drive.");
        }

        public void Drive()
        {
            Console.WriteLine("Car is now in Drive.");
        }

        public void Reverse()
        {
            Console.WriteLine("Car is now in reverse, backing up now.");
        }
    }
}

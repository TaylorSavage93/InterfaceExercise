using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public string Color { get; set; }
        public int NumberOfWindows { get; set; }
        public int NumberOfWheels { get; set; }
        public string StickOrAuto { get; set; }
        public double EngineSize { get; set; }
        public double Year { get; set; }
        public string Name { get; set; }
        public double NumberOfEmployees { get; set; }

        public void ChangeGears()
        {
            Console.WriteLine("Suv is changing from reverse to drive.");
        }

        public void Drive()
        {
            Console.WriteLine("SUV is moving forward gear is now in Drive.");
        }

        public void Reverse()
        {
            Console.WriteLine("SUV is now in reverse, backing up.");
        }
    }
}

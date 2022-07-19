using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string StickOrAuto { get; set; }
        public double EngineSize { get; set; }
        public double Year { get; set; }

        void Drive();
        void Reverse();
        void ChangeGears();


    }
}

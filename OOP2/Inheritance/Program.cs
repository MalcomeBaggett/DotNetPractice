using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
        public class Vehicle
        {
            public int MaxPassengers { get; set; }
            public int NumOfWheels { get; set; }
            public bool IsLandVehicle { get; set; }
        }
        public class Car : Vehicle
        {

        }
        public class Boat : Vehicle
        {

        }

        public class MotorCycle : Vehicle
        {

        }
    }
}

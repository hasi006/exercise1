using System;

namespace ConstructorInheritance
{
    public class Vehicle
    {
        /// <summary>
        /// to demonstrate implementation hierachy
        /// </summary>
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is beigng initialized");
        //}

        public Vehicle(string registrationNumber)
        {
            Console.WriteLine($"Vehicle is being initialized {registrationNumber}");
        }
    }
}

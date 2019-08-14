using System;

namespace ConstructorInheritance
{
    public class Car:Vehicle
    {
        private readonly string registrationNumber;

        /// <summary>
        /// to demonstrate hierachy of implementation
        /// </summary>
        //public Car()
        //{
        //    Console.WriteLine("Car is being initialized");
        //}

        public Car(string registrationNumber):base(registrationNumber)
        {
            this.registrationNumber = registrationNumber;
            Console.WriteLine($"Car is being initialized {registrationNumber}");
        }
    }
}

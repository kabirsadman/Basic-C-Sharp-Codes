using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();    
            Boat boat = new Boat();
            Vehicle[] vehicles = { car, bicycle, boat }; //array
            foreach( Vehicle sami in vehicles) //using foreach loop to print all the values in array
            {
                sami.Go();
            }
            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public virtual void Go()
        {
           

        }

    }
    class Car:Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The Car is moving");
        }

    }
    class Bicycle:Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The Bicycle is moving");
        }

    }
    class Boat:Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The Boat is moving");
        }

    }
}

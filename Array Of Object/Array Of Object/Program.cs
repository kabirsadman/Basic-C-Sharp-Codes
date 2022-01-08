using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Of_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] garage = { new Car("BMW"), new Car("Corolla"), new Car("Toyota") };
            foreach(Car car in garage)
            {
                Console.WriteLine(car.model);
            }
            Console.ReadKey();

        }
    }
    class Car
    {
        public string model;
        public Car(String model)
        {
            this.model = model;
        }
    }
}

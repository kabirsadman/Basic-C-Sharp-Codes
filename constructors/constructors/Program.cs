using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW","Lol");
            car.Drive();
            Console.ReadKey();
        }
    }
    class Car
    {
        String name;
        String model;
        public Car(String name, String model)
        {
            this.name = name;
            this.model = model;

        }
        public void Drive()
        {
            Console.WriteLine("This is"+" "+name+" it's model number is"+" "+model);
        }

       
       
    }
}

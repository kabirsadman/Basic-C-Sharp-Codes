using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getters_and_setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(503);
            car.Speed = 502; //value
            Console.WriteLine(car.Speed);
            Console.ReadKey();
        }
    }
    class Car
    {
        private int speed;
        public Car(int speed)
        {
            Speed = speed;

        }
        public int Speed //decalaring property. Property will be the same name as field just first alphabet will be capital
        {
            get { return speed; } //it will read whatever value is within our field
            set //write
            {
                if(value>500)
                {
                    speed = 500;
                }
                else
                {
                    speed= value;
                }
            }

        }

    }
}

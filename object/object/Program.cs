using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.name = "Sami";
            human.age = 24;
            human.Sleep();
            human.Eat();
            Console.ReadKey();

        }
    }
    class Human
    {
        public String name; //field
        public int age; //field
        public void Eat()
        {
            Console.WriteLine(name+ " "+ "is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name+ " "+ "is sleeping" );
        }


    }

}

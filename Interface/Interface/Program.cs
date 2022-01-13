using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit =new Rabbit();
            Fish fish = new Fish();
            fish.Flee();
            fish.Eat();
            //rabbit.Flee();
            Console.ReadKey();
        }
    }
    interface Iprey
    {
        void Eat();

    }
    interface Ipreditor
    {
        void Flee(); //we will not declare method's body in interface
        

    }
    class Rabbit
    {
        public void Flee()
        {
            Console.WriteLine("The Rabbit is running");
        }

    }
    class Hawk
    {

    }
    class Fish:Iprey, Ipreditor
    {
        public void Eat()
        {
            Console.WriteLine("The Fish is eating");
        }
        public void Flee()
        {
            Console.WriteLine("Fish Can't talk");
        }
      


    }
}

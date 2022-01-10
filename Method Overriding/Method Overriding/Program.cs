using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat =new Cat();
            cat.Speak();
            dog.Speak();
            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal can speak!!");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The animal can jump");
        }

    }
    class Cat: Animal
    {

    }
    
}

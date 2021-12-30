using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter You'r Name");
            string name = Console.ReadLine();
            if(name != "")
            {
                Console.WriteLine("Hey there "+name);
            }
            else
            {
                Console.WriteLine("Fool! You did not enter you'r name");
            }

        }
    }
}

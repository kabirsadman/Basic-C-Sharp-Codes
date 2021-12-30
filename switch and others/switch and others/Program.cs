using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_and_others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is today?");
            string day = Console.ReadLine();
            switch(day)
            {
                case "Sunday":
                Console.WriteLine("It's Sunday!");
                    break;
                case "Monday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday");
                    break;
                default:
                    Console.WriteLine(day+ "is not a day");
                    break ;
            }
            Console.ReadKey();
        }
    }
}

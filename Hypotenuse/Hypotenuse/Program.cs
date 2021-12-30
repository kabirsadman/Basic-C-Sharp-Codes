using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypotenuse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the vlaue of b");
            double b= Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt((a * a)+(b * b));
            Console.WriteLine("The hypotenus of the triangle is:"+c);
        }
    }
}

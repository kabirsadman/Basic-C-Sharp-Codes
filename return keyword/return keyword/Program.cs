using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter the value of x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y:");
            double y = Convert.ToDouble(Console.ReadLine());
            double result = Multipy(x,y);
            Console.WriteLine(result);
            Console.ReadLine();


        }
        static double Multipy(double x, double y)
        {
            double z = x * y;
            return z;

        }

       
    }
}

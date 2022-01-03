using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = CheckOut(5,4,3);
            Console.WriteLine(result);
            Console.ReadKey();

        }
        static double CheckOut(params double[] prices)
        {
            double total = 0;
            foreach(double price in prices)
            {
                total += price;
            }
            return total;

        }
    }
}

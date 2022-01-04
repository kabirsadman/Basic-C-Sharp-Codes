using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int result;
            try
            {

                Console.WriteLine("Enter number 1:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2:");
                y = Convert.ToInt32(Console.ReadLine());
                result = x / y;
                Console.WriteLine(+result);
                
            }
            catch (FormatException e)
            {
                Console.WriteLine("You are mad dude!");
            }
            catch (DivideByZeroException e )
            {
                Console.WriteLine("You can't divide by zero! Fool!");
            }
            Console.ReadKey();
        }
    }
}

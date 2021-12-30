using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter row numbers");
           int rows= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter column numbers");
            int colums= Convert.ToInt32(Console.ReadLine());
            Console.Write("What symbol?");
            String symbol = Console.ReadLine();
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<colums;j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
         
            Console.ReadKey();

        }
    }
}

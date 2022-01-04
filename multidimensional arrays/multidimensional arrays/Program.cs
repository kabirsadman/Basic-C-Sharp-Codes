using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimensional_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[,] lol = {{ "sami", "siyam", "tuhin" },
                { "Ash", "Ehsan", "Rezab" },
                { "xoss", "voitka", "beshi voitka" } };
            lol[2, 1] = "Valoi Voitka";

            /*foreach(String ash in lol)
            {
                Console.WriteLine(ash);
            }
            */
            for(int i=0; i<lol.GetLength(0);i++) //here 0 in GetLength means the first dimenson
            {
                for(int j=0;j<lol.GetLength(1);j++) //here 1 in GetLength means the second dimenson
                {
                    Console.Write(lol[i,j]+ " ");
                }
                Console.WriteLine();
            }

            
            Console.ReadKey();
        }
    }
}

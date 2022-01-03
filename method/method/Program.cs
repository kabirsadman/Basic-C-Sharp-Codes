using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Kabir";
            Myself(name);
            Myself(name);
            Console.ReadKey();
            

          
        }
        
        static void Myself(String name)
        {
            Console.WriteLine("I am "+name);
            Console.WriteLine("I love C#");
            Console.WriteLine("I did this course a while ago now I forget the basic");
            Console.WriteLine("So I am brainstorming again");
        }
        
    }
   
   
}

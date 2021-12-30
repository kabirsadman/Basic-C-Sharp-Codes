using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girrafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string characterName = "Sami";
            //int characterAge = 23;
            //Console.WriteLine("My name is:"+characterName);
            //Console.WriteLine("I am "+characterAge+" years old" );
            //Console.WriteLine(" /  |");
            //Console.WriteLine("/___|");

            //type casting
            //double a = 3.1416;
            //int b = Convert.ToInt32(a);
            //Console.WriteLine(b);

            //taking input from console
            //Console.WriteLine("Give Your name");
            //string name = Console.ReadLine();

            //Console.WriteLine("Give Your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hey there:"+name);
            //Console.WriteLine("Your age is:"+age);
            
            //arithmatic operations
            //friend +=2;
            //friend++;
            //friend=friend+2;

            //random rumbers
            Random random = new Random();
            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);









            Console.ReadKey();
        }
    }
}

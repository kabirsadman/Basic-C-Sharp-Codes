using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)

        {
            do
            {

                double num1 = 0;
                double num2 = 0; ;
                double result = 0;
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Calculator Developed By Sami");
                Console.WriteLine("---------------------------------");
                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter an option");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.WriteLine("Enter an operator among above four:");
                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your  result is: {num1} + {num2} =" + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your  result is: {num1} - {num2} =" + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your  result is: {num1} * {num2} =" + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your  result is: {num1} / {num2} =" + result);
                        break;
                    default:
                        Console.WriteLine("You choose wrong keyword");
                        break;


                }
                Console.WriteLine("Would you like to use it again(Y/N)");
            }
            
            while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Thank You I hope It Helped You Little Bit ^_^ ");


            Console.ReadKey();
        }
    }
}

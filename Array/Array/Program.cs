using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] cars = { "lol", "rofl", "tol" };
            //for(int i=0; i<cars.Length; i++)
            //{
                //Console.WriteLine(cars[i]);
            //}
            //another way of declare array
            // String[] cars= new String[3];
            // cars[0]="lol";
            //cars[1]="rofl";
            //cars[2]="tofl";

            //printing the value of array using foreach loop

            foreach(String car in cars)
            {
                Console.WriteLine(car);

            }    





            Console.ReadLine(); 
        }
    }
}

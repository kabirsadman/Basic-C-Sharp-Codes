using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic; 

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*String[] food = new string[3];
            food[0] = "Khichuri";
            food[1] = "Polao or pulao";
            food[2] = "Biriyani";*/
            //food[3]= "Mangsho";

            //for using list we have to declare System.Collections.Generic on top

            List<String> food = new List<string>();
            food.Add("Khichuri");
            food.Add("Mangsho");
            food.Add("Pulao or polao");
            food.Add("Kacchi");
            //food.Remove("Mangsho");
            //food.Insert(1,"loil");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("Khichuri"));
            //Console.WriteLine(food.LastIndexOf("kacchi"));
            //Console.WriteLine(food.Contains("Mangsho"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();

            //for converting list into array we will do exactly like below
            String [] foodArray = food.ToArray();

            foreach (String lol in food)
            {
                Console.WriteLine(lol);  
            }
            Console.ReadKey();
        }
    }
}

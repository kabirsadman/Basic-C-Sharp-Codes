using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int number;
            int guess;
            int guesses;
            String response;
            while(playAgain)
            {
                guess = 0;
                response = "";
                guesses = 0;
                number = random.Next(min, max + 1);

                while(guess != number)
                {
                    Console.WriteLine("Type a number between " +min+ "-" +max+ ":" );
                    guess = Convert.ToInt32(Console.ReadLine()) ;
                    Console.WriteLine("Guess:"+""+ +guess);

                    if(guess>number)
                    {
                        Console.WriteLine(guess+ " " + "is too high");
                    }
                    else if(guess<number)
                    {
                        Console.WriteLine(guess + " " + "is too low");
                    }
                    guesses++;


                }
                Console.WriteLine("Number:"+number);
                Console.WriteLine("You Win Dude!!");
                Console.WriteLine("You Took"+guesses +"Guess");
                Console.WriteLine("Would You Like To Play Again?(Y/N)");
                response = Console.ReadLine().ToUpper();
                if(response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain=false;    
                }


            }
            Console.WriteLine("Thanks For Playing");
            Console.ReadKey();
        }
    }
}

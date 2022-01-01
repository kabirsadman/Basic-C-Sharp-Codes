using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;
            while(playAgain)
            {
                player = "";
                computer = "";
                answer = "";
                while(player != "ROCK" && player != "PAPERS" && player != "SCISSORS" )
                { 
                Console.WriteLine("Enter Rock,Papers, or, Scissors:");
                player = Console.ReadLine();
                player=player.ToUpper();
               
                }
                switch(random.Next(1,4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                        case 2:
                        computer = "PAPERS";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;


                }
                Console.WriteLine("Player's choice:"+" "+player);
                Console.WriteLine("Computer's choice:" + " " + computer);
                switch(player)
                {
                    case "ROCK":
                        if(computer =="ROCK")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (computer == "PAPERS")
                        {
                            Console.WriteLine("You lose");
                        }
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You Win");
                        }
                        break;
                    case "PAPERS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Win");
                        }
                        else if (computer == "PAPERS")
                        {
                            Console.WriteLine("Draw");
                        }
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You lose");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose");
                        }
                        else if (computer == "PAPERS")
                        {
                            Console.WriteLine("You Win");
                        }
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("Draw");
                        }
                        break;


                }
                Console.WriteLine("Do you want to play again(Y/N):");
                answer= Console.ReadLine();
                answer = answer.ToUpper();
                if(answer=="Y")
                {
                    playAgain = true;
                }
                else if(answer == "N")
                {
                    playAgain = false;
                }    
               



            }

        }
    }
}

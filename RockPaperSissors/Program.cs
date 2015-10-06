using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperSissors;
using RockPaperSissors.Implementations;


namespace RockPaperSissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock, Paper,Sissors.....");
            Game newGame = new Game();

            string input = "";

            do
            {
                newGame.playRound();
               
                Console.Write("Would you like to play again? (enter \"Q\" to quit)");
                input = Console.ReadLine();

            } while (input.ToUpper() != "Q");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperSissors.Enums;
using RockPaperSissors.Implementations;

namespace RockPaperSissors
{
    public class Game
    {
        public void playRound()
        {
            Player p1 = new Human("Player 1");
            //Player p2 = new ComputerPlayer("Player 2");
            ComputerPlayerWeighted p2 = new ComputerPlayerWeighted("Player 2");

            MatchResult result = new MatchResult();
            result.Player1_Choice = p1.GetChoice();
            result.Player2_Choice = p2.GetChoiceWeighted();

            if (result.Player1_Choice == result.Player2_Choice)
            {
                result.Match_Result = Result.Tie;
            }
            else if((result.Player1_Choice == Choice.Rock && result.Player2_Choice == Choice.Sissors) ||
                (result.Player1_Choice == Choice.Paper && result.Player2_Choice == Choice.Rock) ||
                (result.Player1_Choice == Choice.Sissors && result.Player2_Choice == Choice.Paper))
            {
                result.Match_Result = Result.Win;
            }
            else
            {
                result.Match_Result = Result.Loss;
            }
            ProcessResult(p1,p2,result);
            Console.WriteLine("Rock Count : {0} ", ComputerPlayerWeighted.CountR);
            Console.WriteLine("Scissors Count : {0}", ComputerPlayerWeighted.CountS);
            Console.WriteLine("Paper Count : {0} ", ComputerPlayerWeighted.CountP);
            //Console.WriteLine(Enum.GetName(typeof(Choice),p1.GetChoice()));
        }
        
        public int ProcessResult(Player player1, Player player2, MatchResult result)
        {
            Console.WriteLine("{0} picked  {1}. {2} picked {3}", player1.Name,
                Enum.GetName(typeof(Choice),result.Player1_Choice),
                player2.Name, Enum.GetName(typeof(Choice),result.Player2_Choice));

            switch (result.Match_Result)
            {
                case Enums.Result.Win:
                    Console.WriteLine("{0} Wins!", player1.Name);
                    return 1;
                case Enums.Result.Loss:
                    Console.WriteLine("{0} Wins!", player2.Name);
                    return 2;
                default:
                    Console.WriteLine("You both tie!");
                    return 0;
            }
        }
      
    }

        

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperSissors.Enums;

namespace RockPaperSissors.Implementations
{
    public class ComputerPlayerTwo : Player
    {
        private static Random _randomGenerator = new Random();// static can have 2 comp players 
                                                              //and won't use chose the same number
        public ComputerPlayerTwo(string Name) : base(Name)
        {

        }

        public override Choice GetChoice()
        {
            int i = _randomGenerator.Next(1, 11);//num 1-10

            if (i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7)
            {
                return Choice.Rock;
            }
            else if (i == 8 || i == 9)
            {
                return Choice.Sissors;
            }
            return Choice.Paper;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperSissors.Enums;

namespace RockPaperSissors.Implementations
{
    public class ComputerPlayer : Player
    {
        private static Random  _randomGenerator = new Random();// static so can have 2 comp players 
        public static int CountR = 0;
        public static int CountS = 0;
        public static int CountP = 0;                          //and won't use chose the same number
        public ComputerPlayer(string Name) : base(Name)
        {
           
        }

        public override Choice GetChoice()
        {
            int i = _randomGenerator.Next(1, 4);//num 1-3

            return (Choice) i; //will choose from enum Choice of rock -1 paper -2 sissors-3
                                //because casted i to enum Choice => (Choice)i
        }

        public Choice GetChoiceTest()
        {
            return (Choice) 2;
        }
    }
}

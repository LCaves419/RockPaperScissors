﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperSissors.Enums;

namespace RockPaperSissors.Implementations
{
    class ComputerPlayerWeighted : Player
    {
        private static Random _randomGenerator = new Random();// static can have 2 comp players 
        public static int CountR = 0;                            //and won't use chose the same number
        public static int CountS = 0;
        public static int CountP = 0;                                                  
        public ComputerPlayerWeighted(string Name) : base(Name)
        {

        }

        public override Choice GetChoice()
        {
            int i = _randomGenerator.Next(1, 4);//num 1-3

            return (Choice)i; //will choose from enum Choice of rock -1 paper -2 sissors-3
                              //because casted i to enum Choice => (Choice)i
        }

        public Choice GetChoiceWeighted()
        {
            int i = _randomGenerator.Next(1, 11);//num 1-10


            if (i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7)
            {
                CountR++;
                return Choice.Rock;
            }
            else if (i == 8 || i == 9)
            {
                CountS++;
                return Choice.Sissors;
            }
            CountP++;
            return Choice.Paper;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperSissors.Enums;
using RockPaperSissors.Implementations;


namespace RockPaperSissors.Implementations
{
    public class Human : Player
    {
        public Human(string Name) : base(Name)
        {
            
        }

        public override Choice GetChoice()
        {
            Choice choice = Choice.Unknown;

            while (choice == Choice.Unknown)
            {
                Console.Write("\n{0}:Enter a choice (R)ock, (P)aper, (S)issors:\n",Name);
                string input = Console.ReadLine();

                switch (input.ToUpper())
                {
                    case "R":
                        choice = Choice.Rock;
                        break;
                    case "P":
                        choice = Choice.Paper;
                        break;
                    case "S":
                        choice = Choice.Sissors;
                        break;
                    default:
                        Console.WriteLine("Try again");
                        choice = Choice.Unknown;
                        break;
                }
            }
            return choice;
        }
    }
}

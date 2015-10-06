using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperSissors.Enums;
using RockPaperSissors.Implementations;

namespace RockPaperSissorsTests.PlayerTests
{
    public class PaperPlayer : Player
    {
        public PaperPlayer(string Name) : base(Name)
        {
            
        }
        public override Choice GetChoice()
        {
            return Choice.Paper;
        }
    }
}

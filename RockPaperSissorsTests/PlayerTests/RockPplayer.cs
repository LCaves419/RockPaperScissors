using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperSissors.Enums;
using RockPaperSissors.Implementations;

namespace RockPaperSissorsTests.PlayerTests
{
    public class RockPplayer : Player
    {
        public RockPplayer(string Name) : base(Name)
        {

        }

        public override Choice GetChoice()
        {
            return Choice.Rock;
        }
    }
}

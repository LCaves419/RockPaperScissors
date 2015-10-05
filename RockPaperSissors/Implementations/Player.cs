using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperSissors.Enums;
using RockPaperSissors.Interfaces;

namespace RockPaperSissors.Implementations
{
    public abstract class Player : IChoiceSlector
    {
        public string Name { get;  }

        public Player(string Name)
        {
            this.Name = Name;
        }

        public abstract Choice GetChoice();
    }
}

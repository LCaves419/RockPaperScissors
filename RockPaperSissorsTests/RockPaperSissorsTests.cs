using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RockPaperSissors;
using RockPaperSissors.Enums;
using RockPaperSissors.Implementations;
using RockPaperSissorsTests.PlayerTests;

namespace RockPaperSissorsTests
{
    [TestFixture]
    class RockPaperSissorsTests
    {
        [TestCase(Choice.Paper, Result.Tie)]
        [TestCase(Choice.Rock,Result.Win)]
        [TestCase(Choice.Sissors,Result.Loss)]
        public void GetChoiceInput(Choice choice, Result expectedResult)
        {
            TestGame _game = new TestGame();
            PaperPlayer player1 = new PaperPlayer("PaperPlayer");
             Player player2;
     
            //Act
            switch (choice)
            {
                case Choice.Rock:
                    player2 = new RockPplayer("rockplayer");
                    break;
                    case Choice.Paper:
                    player2 = new PaperPlayer("paperplayer");
                    break;
                default:
                    player2 = new ScissorsPlayer("scissorsplayer");
                    break;
            }
            Result actual = _game.playRound(player1, player2);

            //Assert
            Assert.AreEqual(actual, expectedResult);
        }
    }
}

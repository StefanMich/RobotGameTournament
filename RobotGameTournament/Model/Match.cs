using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotGameTournament.Model;

namespace RobotGameTournament
{
    [System.Diagnostics.DebuggerDisplay("Player1: {Player1.Name} Player2: {Player2.Name}")]
    public class Match
    {
        public Robot Player1 { get; set; }
        public Robot Player2 { get; set; }

        public int Player1Score { get; set; }
        public int Player2Score { get; set; }

        public MatchResult MatchResult{ get; set; }

        public Match(Robot player1, Robot player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public Robot Winner()
        {
            if (MatchResult.result == Result.Player1)
                return Player1;
            else if (MatchResult.result == Result.Player2)
                return Player2;
            else return Robot.Draw();
        }
    }
}

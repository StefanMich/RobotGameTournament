using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGameTournament
{
    [System.Diagnostics.DebuggerDisplay("Player1: {Player1.Name} Player2: {Player2.Name}")]
    public class Match
    {
        public Robot Player1 { get; set; }
        public Robot Player2 { get; set; }

        public Robot Winner { get; set; }

        public Match(Robot player1, Robot player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
    }
}

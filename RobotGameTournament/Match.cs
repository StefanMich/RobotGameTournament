using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGameTournament
{
    public class Match
    {
        public Robot Player1 {get;set;}
        public Robot Player2 { get; set; }

        public Match(Robot player1, Robot player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
    }
}

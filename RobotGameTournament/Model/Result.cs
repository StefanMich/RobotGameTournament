using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGameTournament.Model
{
    public enum Result { Player1, Player2, Draw }
    public struct MatchResult
    {
        public int player1score;
        public int player2score;
        public Result result;

        public MatchResult(int player1score, int player2score, Result res)
        {
            this.player1score = player1score;
            this.player2score = player2score;
            result = res;
        }


    }
}

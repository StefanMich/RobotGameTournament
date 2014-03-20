using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotGameTournament.Model;

namespace RobotGameTournament
{
    public class PrintScoresToConsole : RobotGameTournament.Control.IPrintScores
    {
        public void PrintScoreBoard(List<Robot> robots)
        {
            foreach (Robot r in robots)
            {
                Console.WriteLine(r.ShortName + ": " + r.Points);
            }
        }

        public void PrintMatchOverview(List<Match> matches)
        {
            foreach (Match m in matches)
            {
                string match = string.Format("{0} {1} \t vs. \t {3} {2}", m.Player1, m.MatchResult.player1score, m.Player2, m.MatchResult.player2score);
                if (m.Winner() == Robot.Draw())
                    Console.WriteLine(match + " - Draw!");
                else Console.WriteLine(match+ string.Format(" - {0} wins!", m.Winner()));
            }
        }
    }
}

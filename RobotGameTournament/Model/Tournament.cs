using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotGameTournament.Control;

namespace RobotGameTournament.Model
{
    public abstract class Tournament
    {
        protected List<Robot> robots;

        List<Match> matches;
        IPrintScores printer;

        public List<Robot> Robots { get { return robots; } }

        public List<Match> Matches { get { return matches; } }

        public Tournament(IPrintScores printer)
        {
            robots = new List<Robot>();
            matches = new List<Match>();
            this.printer = printer;
        }

        public void CalculateMatches(int rounds)
        {
            for (int i = 0; i < rounds; i++)
            {
                matches.AddRange(calculateMatches(robots));
            }
        }

        public void RunMatches()
        {
            foreach (Match m in matches)
            {
                RunMatch.Run(m,winPoints,drawPoints);
            }
        }

        public void RunTournament(int rounds)
        {
            CalculateMatches(rounds);

            RunMatches();
        }

        public void PrintMatchOverview()
        {
            printer.PrintMatchOverview(matches);
        }

        public void PrintScoreBoard()
        {
            printer.PrintScoreBoard(robots);
        }


        protected abstract List<Match> calculateMatches(List<Robot> robots);

        protected abstract int winPoints{get;}
        protected abstract int drawPoints { get; }


    }
}

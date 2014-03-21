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

        protected List<Match> matches;
        
        public List<Robot> Robots { get { return robots; } }

        public List<Match> Matches { get { return matches; } }

        public Tournament()
        {
            robots = new List<Robot>();
            matches = new List<Match>();
        }

        
        public void RunMatches()
        {
            foreach (Match m in matches)
            {
                RunMatch.Run(m, winPoints, drawPoints);
            }
        }

        public abstract void RunTournament();
        

        public void PrintMatchOverview(IPrintScores printer)
        {
            printer.PrintMatchOverview(matches);
        }

        public void PrintScoreBoard(IPrintScores printer)
        {
            printer.PrintScoreBoard(robots);
        }

        protected abstract int winPoints{get;}
        protected abstract int drawPoints { get; }


    }
}

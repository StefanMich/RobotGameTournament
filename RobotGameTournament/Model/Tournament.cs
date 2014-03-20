using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGameTournament
{
    public abstract class Tournament
    {
        protected List<Robot> robots;

        List<Match> matches;

        public List<Robot> Robots { get { return robots; } }

        public List<Match> Matches { get { return matches; } }

        public Tournament()
        {
            robots = new List<Robot>();
        }

        public void CalculateMatches()
        {
            matches = calculateMatches(robots);
        }

        public void RunMatches()
        {
            foreach (Match m in matches)
            {
                RunMatch.Run(m,winPoints,drawPoints);
            }
        }

        protected abstract List<Match> calculateMatches(List<Robot> robots);

        protected abstract int winPoints{get;}
        protected abstract int drawPoints { get; }


    }
}

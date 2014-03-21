using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotGameTournament.Control;

namespace RobotGameTournament.Model
{
    public class RoundRobinTournament : Tournament
    {
        public RoundRobinTournament(List<Robot> robots) 
        {
            this.robots = robots;
        }

        protected List<Match> calculateMatches(List<Robot> robots)
        {
            List<Match> matches = new List<Match>();

            for (int i = 0; i <= robots.Count - 1; i++)
            {
                for (int j = i+1; j < robots.Count; j++)
                {
                    matches.Add(new Match(robots[i],robots[j]));   
                }
            }
            return matches;
        }

        public override void RunTournament()
        {
            matches =  calculateMatches(robots);

            RunMatches();
        }

        protected override int winPoints
        {
            get { return 3; }
        }

        protected override int drawPoints
        {
            get { return 1; }
        }
    }
}

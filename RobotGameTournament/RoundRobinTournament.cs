using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGameTournament
{
    public class RoundRobinTournament : Tournament
    {
        public RoundRobinTournament()
        {
            
        }

        public override List<Match> calculateMatches(List<Robot> robots)
        {
            List<Match> matches = new List<Match>();

            for (int i = 0; i >= robots.Count - 1; i++)
            {
                for (int j = i; j < robots.Count; j++)
                {
                    matches.Add(new Match(robots[i],robots[j]));   
                }
            }
            return matches;
        }


    }
}

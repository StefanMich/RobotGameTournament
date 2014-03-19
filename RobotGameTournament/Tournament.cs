using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGameTournament
{
    public abstract class Tournament
    {
        List<Robot> robots;

        List<Match> matches;

        public List<Robot> Robots { get { return robots; } }

        public Tournament()
        {
            robots = new List<Robot>();
        }

        public void CalculateMatches()
        {
            matches = calculateMatches(robots);
        }

        public abstract List<Match> calculateMatches(List<Robot> robots);


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGameTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot r1 = new Robot(@"C:\Users\Stefan\Dropbox\Programmering\Python\RobotGame\ruthlessKiller.py");
            Robot r2 = new Robot(@"C:\Users\Stefan\Dropbox\Programmering\Python\RobotGame\ruthlessKiller.py");
            Robot r3 = new Robot(@"C:\Users\Stefan\Dropbox\Programmering\Python\RobotGame\ruthlessKiller.py");
            Robot r4 = new Robot(@"C:\Users\Stefan\Dropbox\Programmering\Python\RobotGame\ruthlessKiller.py");

            List<Robot> robots = new List<Robot>() { r1, r2, r3, r4 };

            RoundRobinTournament t = new RoundRobinTournament(robots);
            t.CalculateMatches();

            RunMatch.Run(t.Matches[0],3,1);
        }
    }
}

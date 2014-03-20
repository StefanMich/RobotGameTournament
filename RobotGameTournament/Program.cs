using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotGameTournament.Control;
using RobotGameTournament.Model;

namespace RobotGameTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 50);

            List<Robot> robots = LoadRobots.GetRobots(args[0]);

            RoundRobinTournament t = new RoundRobinTournament(robots, new PrintScoresToConsole());

            t.RunTournament(int.Parse(args[1]));

            t.PrintMatchOverview();

            Console.WriteLine();

            t.PrintScoreBoard();

            Console.ReadKey();
        }

        
    }
}

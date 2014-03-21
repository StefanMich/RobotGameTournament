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

            RoundRobinTournament t = new RoundRobinTournament(robots);
            PrintScoresToConsole printer = new PrintScoresToConsole();

            for (int i = 0; i < int.Parse(args[1]); i++)
			{
                t.RunTournament();
                t.PrintMatchOverview(printer);
			}

            Console.WriteLine();

            t.PrintScoreBoard(printer);

            Console.ReadKey();
        }

        
    }
}

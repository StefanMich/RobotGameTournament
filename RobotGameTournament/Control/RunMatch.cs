using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotGameTournament.Model;

namespace RobotGameTournament
{
    public static class RunMatch
    {
        static string pythonpath = @"C:\Python27\Python.exe";
        static string rgpath = @"C:\Users\Stefan\Dropbox\Programmering\Python\RobotGame\rgkit\rgkit\run.py";

        public static void Run(Match m, int win, int draw)
        {
            List<string> output = new List<string>();

            Process p = new Process
            {
                StartInfo =
                {
                    FileName = pythonpath,
                    Arguments = rgpath + " -H " + m.Player1.Path + " " + m.Player2.Path,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            p.Start();
            while (!p.StandardOutput.EndOfStream)
            {
                output.Add(p.StandardOutput.ReadLine());
            }

            m.MatchResult = InterpretResult(output[output.Count-1]);


            switch (m.MatchResult.result)
            {
                case Result.Player1:
                    m.Player1.Points += win;
                    break;
                case Result.Player2:
                    m.Player2.Points += win;
                    break;
                case Result.Draw:
                    m.Player1.Points += draw;
                    m.Player2.Points += draw;
                    break;
                default:
                    break;
            }

        }

        private static MatchResult InterpretResult(string result)
        {
            int comma = result.IndexOf(',');
            int space = result.IndexOf(' ', comma+2);

            string firstScore = result.Substring(1, comma - 1);
            string secondScore = result.Substring(comma + 2, space - comma - 3);

            Result matchResult;
            int first = int.Parse(firstScore);
            int second = int.Parse(secondScore);


            int res = first - second;

            if (res > 0)
                matchResult = Result.Player1;
            else if (res < 0)
                matchResult = Result.Player2;
            else matchResult = Result.Draw;

            return new MatchResult(first, second, matchResult);
        }
    }
}

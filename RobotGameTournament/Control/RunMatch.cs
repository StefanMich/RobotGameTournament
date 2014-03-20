using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGameTournament
{

    public enum Result { Player1, Player2, Draw }
    public static class RunMatch
    {
        static string pythonpath = @"C:\Python27\Python.exe";
        static string rgpath = @"C:\Users\Stefan\Dropbox\Programmering\Python\RobotGame\rgkit\rgkit\run.py";

        public static void Run(Match m,int win, int draw)
        {
            List<string> output = new List<string>();

            Process p = new Process
            {
                StartInfo =
                {
                    FileName = pythonpath,
                    Arguments = rgpath + " -H " + m.Player1.Name + " " + m.Player2.Name,
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

            //           Process.Start(rgpath, "-H " + r1.Name + " " + r2.Name);

            Result r = InterpretResult(output[1]);

            switch (r)
            {
                case Result.Player1:
                    m.Winner = m.Player1;
                    m.Player1.Points += win;
                    break;
                case Result.Player2:
                    m.Winner = m.Player2;
                    m.Player2.Points += win;
                    break;
                case Result.Draw:
                    m.Winner = Robot.Draw();
                    m.Player1.Points += draw;
                    m.Player2.Points += draw;
                    break;
                default:
                    break;
            }

        }

        private static Result InterpretResult(string result)
        {
            int comma = result.IndexOf(',');
            int space = result.IndexOf(' ', comma);

            string firstScore = result.Substring(1, comma - 1);
            string secondScore = result.Substring(comma + 1, space - 1);


            int first = int.Parse(firstScore);
            int second = int.Parse(secondScore);

            int res = first - second;

            if (res > 0)
                return Result.Player1;
            else if (res < 0)
                return Result.Player2;
            else return Result.Draw;

        }
    }
}

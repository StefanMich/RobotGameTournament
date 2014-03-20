using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotGameTournament.Model;

namespace RobotGameTournament.Control
{
    public static class LoadRobots
    {
        public  static List<Robot> GetRobots(string dir)
        {
            string[] files = Directory.GetFiles(dir);

            List<Robot> robots = new List<Robot>();
            foreach (var item in files)
            {
                if (item.Split('.')[1] == "py")
                    robots.Add(new Robot(item));
            }
            return robots;
        }
    }
}

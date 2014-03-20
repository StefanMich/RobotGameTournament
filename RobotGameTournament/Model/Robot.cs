using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGameTournament.Model
{
    [System.Diagnostics.DebuggerDisplay("Name: {Path}")]
    public class Robot
    {
        public string Path { get; set; }

        public string ShortName
        {
            get
            {
                string[] ar = Path.Split('\\');
                return ar[ar.Length - 1];
            }
        }
        public int Points { get; set; }



        public Robot(string path)
        {
            Path = path;
        }

        public static Robot DrawInstance;
        public static Robot Draw()
        {
            if (DrawInstance == null)
                DrawInstance = new Robot("DRAW");
            return DrawInstance;
        }

        public override string ToString()
        {
            return ShortName;
        }
    }
}
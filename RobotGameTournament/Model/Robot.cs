using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGameTournament
{
    [System.Diagnostics.DebuggerDisplay("Name: {Name}")]
    public class Robot
    {
        public string Name { get; set; }

        
        public int Points { get ;set; }



        public Robot(string name)
        {
            Name = name;
        }

        public static Robot Draw()
        {
            return new Robot("DRAW");
        }
    }
}
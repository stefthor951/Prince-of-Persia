using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningGame.Classes
{
    public class Obstacle
    {
        public int x, y, xSize = 50, ySize = 50;

        public Obstacle(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningGame.Classes
{
    class Platform
    {
        public int x, y, speed, xSize, ySize, initialY, counter = 0, yChange = 0, yAcceleration;
        public string type;
        int platformWidth = 1000;

        public Platform(int _x, int _y, int _speed, int _xSize, int _ySize) //this method is only really used for the first platform
        {
            x = _x;
            y = _y;
            speed = _speed;
            xSize = _xSize;
            ySize = _ySize;
        }

        public Platform(string _type, int screenHeight)
        {
            type = _type;

            x = 1000;
            speed = 5;
            xSize = platformWidth;
            if (type == "high")
            {
                y = 150;
                ySize = screenHeight - y;
            }
            if (type == "middle")
            {
                y = 250;
                ySize = screenHeight - y;
            }
            if (type == "low")
            {
                y = 350;
                ySize = screenHeight - y;
            }
            initialY = y;
        }

        public void Move()
        {
            x -= speed;
        }

        public void ReverseJump()
        {
            yAcceleration = 15;
        }
    }
}

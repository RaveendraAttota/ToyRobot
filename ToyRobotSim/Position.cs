using System;
using System.Collections.Generic;
using System.Text;
using static ToyRobot.Enum;

namespace ToyRobot
{
    public class Position
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public Direction Facing { get; set; }

        public Position(int x, int y, Direction direction)
        {
            this.XPosition = x;
            this.YPosition = y;
            this.Facing = direction;
        }

    }
}

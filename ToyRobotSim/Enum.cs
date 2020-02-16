using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot
{
    public class Enum
    {
        public enum Direction
        {
            North,
            East,
            South,
            West
        }

        public enum Command
        {
            Place,
            Move,
            Left,
            Right,
            Report
        }

    }
}

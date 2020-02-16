using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot.Interfaces
{
    public interface IRobot
    {
        Position RobotPosition { get; set; }
        void Place(Position position);
        Position Move();
        void TurnLeft();
        void TurnRight();
    }
}

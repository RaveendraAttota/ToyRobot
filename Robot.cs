using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Interfaces;
using static ToyRobot.Enum;

namespace ToyRobot
{
    public class Robot : IRobot
    {
        public Position RobotPosition { get; set; }

        public void Place(Position position)
        {
            RobotPosition = position;
        }
        public Position Move()
        {
            Position newPosition = new Position(RobotPosition.XPosition, RobotPosition.YPosition, RobotPosition.Facing);
            
            switch(RobotPosition.Facing)
            {
                case Direction.North:
                    newPosition.YPosition = RobotPosition.YPosition + 1;
                    break;
                case Direction.East:
                    newPosition.XPosition = RobotPosition.XPosition + 1;
                    break;
                case Direction.South:
                    newPosition.YPosition = RobotPosition.YPosition - 1;
                    break;
                case Direction.West:
                    newPosition.XPosition = RobotPosition.XPosition - 1;
                    break;              
            }

            return newPosition;
        }

        public void TurnLeft()
        {
            switch(RobotPosition.Facing)
            {
                case Direction.North:
                    RobotPosition.Facing = Direction.West;
                    break;
                case Direction.East:
                    RobotPosition.Facing = Direction.North;
                    break;
                case Direction.South:
                    RobotPosition.Facing = Direction.East;
                    break;
                case Direction.West:
                    RobotPosition.Facing = Direction.South;
                    break;
                default:
                    break;

            }
        }
        public void TurnRight()
        {
            switch (RobotPosition.Facing)
            {
                case Direction.North:
                    RobotPosition.Facing = Direction.East;
                    break;
                case Direction.East:
                    RobotPosition.Facing = Direction.South;
                    break;
                case Direction.South:
                    RobotPosition.Facing = Direction.West;
                    break;
                case Direction.West:
                    RobotPosition.Facing = Direction.North;
                    break;
                default:
                    break;

            }
        }
    }
}

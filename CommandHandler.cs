using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Interfaces;
using static ToyRobot.Enum;

namespace ToyRobot
{
    public class CommandHandler
    {
        public IRobot Robot { get; private set; }
        public ITable Table { get; private set; }
        public ICommandParser CommandParser { get; private set; }

        public CommandHandler(IRobot robot, ITable table, ICommandParser commandParser)
        {
            Robot = robot;
            Table = table;
            CommandParser = commandParser;
        }

        public string ProcessCommand(string[] input)
        {
            var command = CommandParser.ParseCommand(input);
            if (command != Command.Place && Robot.RobotPosition == null) return string.Empty;

            switch (command)
            {
                case Command.Place:
                    var placePosition = CommandParser.ParsePlaceParameters(input);
                    if (Table.IsValidPosition(placePosition))
                        Robot.Place(placePosition);
                    break;
                case Command.Move:
                    var newPosition = Robot.Move();
                    if (Table.IsValidPosition(newPosition))
                        Robot.RobotPosition = newPosition;
                    break;
                case Command.Left:
                    Robot.TurnLeft();
                    break;
                case Command.Right:
                    Robot.TurnRight();
                    break;
                case Command.Report:
                    return GetReport();
            }
            return string.Empty;
        }

        public string GetReport()
        {
            return string.Format("Output: {0},{1},{2}", Robot.RobotPosition.XPosition,
                Robot.RobotPosition.YPosition, Robot.RobotPosition.Facing.ToString().ToUpper());
        }
    }
}

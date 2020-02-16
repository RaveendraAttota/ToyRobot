using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Interfaces;
using static ToyRobot.Enum;

namespace ToyRobot
{
    public class CommandParser : ICommandParser
    {
        public Command ParseCommand(string[] rawInput)
        {
            Command command;
            if (!System.Enum.TryParse(rawInput[0], true, out command))
                throw new ArgumentException("Sorry, your command was not recognised. Please try again using the following format: PLACE X,Y,F|MOVE|LEFT|RIGHT|REPORT");
            return command;
        }

        // Number of parameters provided for "PLACE" Command. (X,Y,F)
        private const int ParameterCount = 3;

        // Number of raw input items expected from user.
        private const int CommandInputCount = 2;

        public Position ParsePlaceParameters(string[] input)
        {
            Direction direction;

            if (input.Length != CommandInputCount)
                throw new ArgumentException("Incomplete command. Please ensure that the PLACE command is using format: PLACE X,Y,F");

            var commandParams = input[1].Split(',');
            if (commandParams.Length != ParameterCount)
                throw new ArgumentException("Incomplete command. Please ensure that the PLACE command is using format: PLACE X,Y,F");

            if (!System.Enum.TryParse(commandParams[commandParams.Length - 1], true, out direction))
                throw new ArgumentException("Invalid direction. Please select from one of the following directions: NORTH|EAST|SOUTH|WEST");

            var x = Convert.ToInt32(commandParams[0]);
            var y = Convert.ToInt32(commandParams[1]);

            return new Position(x, y, direction);
        }
    }
}

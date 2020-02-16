using System;
using System.Collections.Generic;
using System.Text;
using static ToyRobot.Enum;

namespace ToyRobot.Interfaces
{
    public interface ICommandParser
    {
        Command ParseCommand(string[] rawInput);
        Position ParsePlaceParameters(string[] input);
    }
}

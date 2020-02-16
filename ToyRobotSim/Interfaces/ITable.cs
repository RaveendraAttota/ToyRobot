using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot.Interfaces
{
    public interface ITable
    {
        bool IsValidPosition(Position position);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Interfaces;

namespace ToyRobot
{
    public class Table : ITable
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public Table(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
        }
        public bool IsValidPosition(Position position)
        {
            return position.XPosition < Columns && position.XPosition >= 0 && 
                   position.YPosition < Rows && position.YPosition >= 0;
        }
    }
}

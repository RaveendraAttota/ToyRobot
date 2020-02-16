using System;
using ToyRobot.Interfaces;

namespace ToyRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            ITable table = new Table(5, 5);
            ICommandParser commandParser = new CommandParser();
            IRobot robot = new Robot();
            var handler = new CommandHandler(robot, table, commandParser);

            var stopApplication = false;
            Console.WriteLine("Please enter commands to control robot movements");
            do
            {
                var command = Console.ReadLine();
                if (command == null) continue;

                if (command.Equals("EXIT"))
                    stopApplication = true;
                else
                {
                    try
                    {
                        var output = handler.ProcessCommand(command.Split(' '));
                        if (!string.IsNullOrEmpty(output))
                            Console.WriteLine(output);
                    }
                    catch (ArgumentException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
            } while (!stopApplication);
        }
    }
}

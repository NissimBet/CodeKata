using System;

namespace CodeKata
{
    /// <summary>
    /// Main entry point of the program, it gets the name of the file from console. It reads the data from it, storing relevant information
    /// and prints a report of the resulting data
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();
            string[] lines = FileReader.ReadFile(filename);

            DriverStore drivers = new DriverStore();

            foreach (string line in lines)
            {
                string[] separatedLines = line.Split(" ");

                ProgramOperation.DoOp(separatedLines, drivers);
            }

            drivers.PrintReport();
        }
    }
}

using System;
using System.IO;

namespace CodeKata
{
    class FileReader
    {
        public static string[] ReadFile(string filename)
        {
            try
            {
                return File.ReadAllLines(filename);
            }
            catch (Exception ex) when (ex is FileNotFoundException || ex is ArgumentException)
            {
                Console.WriteLine($"Error opening {0}, file could not be found", filename);
                return new string[0];
            }
        }
    }
}

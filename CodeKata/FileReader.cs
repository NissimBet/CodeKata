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
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Error opening {0}, file could not be found", e.FileName);
                return new string[0];
            }
        }
    }
}

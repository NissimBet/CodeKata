using System;
using System.IO;

namespace CodeKata
{
    /// <summary>
    /// class that implements reading text from a text file
    /// </summary>
    class FileReader
    {
        /// <summary>
        /// Read the lines of a file. If the file is not found, an error message is displayed
        /// </summary>
        /// <param name="filename">name or path of the file</param>
        /// <returns>A list of string representing the lines of text of the file</returns>
        public static string[] ReadFile(string filename)
        {
            try
            {
                return File.ReadAllLines(filename);
            }
            // File not found or path is null
            catch (Exception ex) when (ex is FileNotFoundException || ex is ArgumentException)
            {
                Console.WriteLine($"Error opening {0}, file could not be found", filename);
                return new string[0];
            }
        }
    }
}

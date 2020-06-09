using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CodeKata
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = FileReader.ReadFile("./TextFile1.txt");

            Dictionary<string, Driver> drivers = new Dictionary<string, Driver>();

            foreach (string line in lines)
            {
                string[] separatedLines = line.Split(" ");
                string command = separatedLines[0];
                string driverName = separatedLines[1];

                if (command.ToUpper() == "DRIVER")
                {
                    if (!drivers.ContainsKey(driverName))
                    {
                        drivers.Add(driverName, new Driver(driverName));
                    }
                }
                else if (command.ToUpper() == "TRIP")
                {
                    if (drivers.ContainsKey(driverName))
                    {
                        DateTime startTime = DateTime.ParseExact(separatedLines[2], "HH:mm", CultureInfo.InvariantCulture);
                        DateTime endTime = DateTime.ParseExact(separatedLines[3], "HH:mm", CultureInfo.InvariantCulture);
                        float distance = float.Parse(separatedLines[4], CultureInfo.InvariantCulture);

                        Trip newTrip = new Trip(startTime, endTime, distance);

                        if (5 <= newTrip.Speed && newTrip.Speed <= 100)
                        {
                            drivers[driverName].AddTrip(newTrip);
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a valid driver", driverName);
                    }
                }
            }

            List<Driver> sortedDrivers = drivers.Values.OrderByDescending(driver => driver.TotalDistance).ToList();
            foreach (Driver driver in sortedDrivers)
            {
                if (driver.TotalDistance > 0)
                {
                    Console.WriteLine("{0}: {1} miles @ {2} mph", driver.name, Math.Ceiling(driver.TotalDistance), Math.Ceiling(driver.AverageSpeed));
                }
                else
                {
                    Console.WriteLine("{0}: {1} miles", driver.name, Math.Ceiling(driver.TotalDistance));
                }
            }
        }
    }
}

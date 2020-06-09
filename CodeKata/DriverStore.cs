using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKata
{
    /// <summary>
    /// Class that stores the data of the drivers
    /// </summary>
    class DriverStore
    {
        /// <summary>
        /// Dictionary used to store the drivers and their data, using their names as the key
        /// and the Driver data as the value
        /// </summary>
        private readonly Dictionary<string, Driver> drivers;

        /// <summary>
        /// Initializes an instance of the DriverStore
        /// </summary>
        public DriverStore() => drivers = new Dictionary<string, Driver>();

        /// <summary>
        /// Checks if the driver is already present in the store
        /// </summary>
        /// <param name="name">Name of the driver to check</param>
        /// <returns><c>true</c> if the driver is present in the data structure</returns>
        public bool HasDriver(string name) => drivers.ContainsKey(name);
        
        /// <summary>
        /// Adds a driver to the structure, if the driver already exists, the driver is not added
        /// </summary>
        /// <param name="driver">driver data, including driver name</param>
        public void AddDriver(Driver driver) {
            if (!HasDriver(driver.name)) { 
                drivers.Add(driver.name, driver); 
            }
        }

        /// <summary>
        /// Returns the Driver data of a given driver
        /// </summary>
        /// <param name="name">name of the driver</param>
        /// <returns>The the data corresponding to the driver, or null if the driver doesn't exist</returns>
        public Driver GetDriver(string name) => drivers.GetValueOrDefault(name, null);
        
        /// <summary>
        /// Returns a list of the drivers, sorted by the total distance traveled of each driver
        /// </summary>
        /// <returns>A list of Driver data</returns>
        public List<Driver> SortedDrivers() => drivers.Values.OrderByDescending(driver => driver.TotalDistance).ToList();

        /// <summary>
        /// Prints a report of the current data of the drivers in the store
        /// </summary>
        public void PrintReport()
        {
            foreach (Driver driver in SortedDrivers())
            {
                if (driver.TotalDistance > 0)
                {
                    Console.WriteLine("{0}: {1} miles @ {2} mph", driver.name, Math.Round(driver.TotalDistance), Math.Round(driver.AverageSpeed));
                }
                else
                {
                    Console.WriteLine("{0}: {1} miles", driver.name, Math.Round(driver.TotalDistance));
                }
            }
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace CodeKata
{
    class DriverStore
    {
        private readonly Dictionary<string, Driver> drivers;

        public DriverStore() => drivers = new Dictionary<string, Driver>();

        public bool HasDriver(string name) => drivers.ContainsKey(name);
        
        public void AddDriver(Driver driver) {
            if (!HasDriver(driver.name)) { 
                drivers.Add(driver.name, driver); 
            }
        }

        public Driver GetDriver(string name) => drivers.GetValueOrDefault(name);
        
        public List<Driver> SortedDrivers() => drivers.Values.OrderByDescending(driver => driver.TotalDistance).ToList();
    }
}

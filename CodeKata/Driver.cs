using System.Collections.Generic;
using System.Linq;

namespace CodeKata
{
    /// <summary>
    /// Driver class to store the data of the driver and his trips
    /// </summary>
    class Driver
    {
        /// <summary>
        /// List of the trips the driver has been on
        /// </summary>
        private readonly List<Trip> trips;

        /// <summary>
        /// name of the driver
        /// </summary>
        public readonly string name;

        /// <summary>
        /// Total Distance traveled by the driver
        /// </summary>
        public float TotalDistance => trips.Aggregate(0.0f, (sum, next) => sum + next.distance);

        /// <summary>
        /// Average speed of the driver's Trips
        /// </summary>
        public float AverageSpeed => trips.Average((trip) => trip.Speed);

        /// <summary>
        /// Creates an instance of a driver 
        /// </summary>
        /// <param name="name">name of the driver</param>
        public Driver(string name) { 
            this.name = name; 
            trips = new List<Trip>(); 
        }

        /// <summary>
        /// Adds a trip to the driver's list of trips
        /// </summary>
        /// <param name="trip">new trip of the driver</param>
        public void AddTrip(Trip trip) => trips.Add(trip);
    }
}

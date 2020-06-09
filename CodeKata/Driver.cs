using System.Collections.Generic;
using System.Linq;

namespace CodeKata
{
    class Driver
    {
        private readonly List<Trip> trips;
        public readonly string name;
        public float TotalDistance => trips.Aggregate(0.0f, (sum, next) => sum + next.distance);
        public float AverageSpeed => trips.Average((trip) => trip.Speed);

        public Driver(string name) { 
            this.name = name; 
            trips = new List<Trip>(); 
        }

        public void AddTrip(Trip trip) => trips.Add(trip);
    }
}

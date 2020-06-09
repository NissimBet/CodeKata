using System;

namespace CodeKata
{
    /// <summary>
    /// Class that stores the data of a single Trip of a driver
    /// </summary>
    class Trip
    {
        /// <summary>
        /// Time of the day of the start of the Trip
        /// </summary>
        private readonly DateTime start;

        /// <summary>
        /// Time of the of the end time of the Trip
        /// </summary>
        private readonly DateTime end;

        /// <summary>
        /// Distance traveled during the Trip
        /// </summary>
        public readonly float distance;

        /// <summary>
        /// Average speed during the Trip
        /// </summary>
        public float Speed => distance / (float)end.Subtract(start).TotalHours;

        /// <summary>
        /// Initializes a new instance of a Trip 
        /// </summary>
        /// <param name="start">Trip start time</param>
        /// <param name="end">Trip end time</param>
        /// <param name="distance">Trip distance traveled</param>
        public Trip(DateTime start, DateTime end, float distance)
        {
            this.start = start;
            this.end = end;
            this.distance = distance;
        }
    }
}

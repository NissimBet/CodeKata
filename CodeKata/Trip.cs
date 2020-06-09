using System;

namespace CodeKata
{
    class Trip
    {
        private readonly DateTime start;
        private readonly DateTime end;
        public readonly float distance;
        public float Speed => distance / (float)end.Subtract(start).TotalHours;

        public Trip(DateTime start, DateTime end, float distance)
        {
            this.start = start;
            this.end = end;
            this.distance = distance;
        }
    }
}

using System;
using System.Globalization;

namespace CodeKata
{
    /// <summary>
    /// Class that checks the given operation and executes it on the driver store
    /// </summary>
    class ProgramOperation
    {
        /// <summary>
        /// Function that executes the operation
        /// </summary>
        /// <param name="operationData">List of strings containing the data required for the operation</param>
        /// <param name="store">Object reference of the Driver Store</param>
        public static void DoOp(string[] operationData, DriverStore store) {
            if (operationData.Length == 2 && operationData[0].ToUpper() == "DRIVER")
            {
                store.AddDriver(new Driver(operationData[1]));
            }
            else if (operationData.Length == 5 && operationData[0].ToUpper() == "TRIP")
            {
                string driverName = operationData[1];
                if (store.HasDriver(driverName))
                {
                    DateTime startTime = DateTime.ParseExact(operationData[2], "HH:mm", CultureInfo.InvariantCulture);
                    DateTime endTime = DateTime.ParseExact(operationData[3], "HH:mm", CultureInfo.InvariantCulture);
                    float distance = float.Parse(operationData[4], CultureInfo.InvariantCulture);

                    Trip newTrip = new Trip(startTime, endTime, distance);

                    if (5 <= newTrip.Speed && newTrip.Speed <= 100)
                    {
                        store.GetDriver(driverName).AddTrip(newTrip);
                    }
                }
            }
        }
    }
}

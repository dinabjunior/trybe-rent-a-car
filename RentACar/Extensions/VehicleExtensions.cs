using System.Linq;
using RentACar.Models;
using RentACar.Models.Vehicles;

namespace System.Collections.Generic
{
    public static class VehicleExtensions
    {
        public static decimal CalculateTotalRentValue(this List<IVehicle> vehicles)
        {
            if (vehicles is null || vehicles.Count == 0) return 0M;

            return vehicles.Sum(vehicle =>
            {
                if (vehicle is Bus bus)
                {
                    return bus.GetDailyValue();
                }

                return vehicle.GetDailyValue();
            });
        }
    }
}

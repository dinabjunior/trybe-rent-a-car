using System;
using System.Diagnostics.CodeAnalysis;

namespace RentACar.Models.Vehicles
{
    public class Motorcycle : AbstractVehicle
    {
        public override string Color { get; }
        protected override decimal DailyValue { get; }

        public Motorcycle(string color, decimal dailyValue)
        {
            Color = color;
            DailyValue = dailyValue;
        }

        public override decimal GetDailyValue()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                return base.GetDailyValue() * 0.90M; // 10% de desconto
            }

            return base.GetDailyValue();
        }
    }
}

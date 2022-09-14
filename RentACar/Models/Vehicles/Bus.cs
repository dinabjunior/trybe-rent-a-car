using System;

namespace RentACar.Models.Vehicles
{
    public class Bus : AbstractVehicle
    {
        public override string Color { get; }
        protected override decimal DailyValue { get; }

        public Bus(string color, decimal dailyValue)
        {
            Color = color;
            DailyValue = dailyValue;
        }

        public new decimal GetDailyValue()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                return DailyValue * 0.50M; // 50% de desconto
            }

            return DailyValue;
        }
    }
}

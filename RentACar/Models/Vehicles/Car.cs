namespace RentACar.Models.Vehicles
{
    public class Car : AbstractVehicle
    {
        public override string Color { get; }
        protected override decimal DailyValue { get; }

        public Car(string color, decimal dailyValue)
        {
            Color = color;
            DailyValue = dailyValue;
        }
    }
}

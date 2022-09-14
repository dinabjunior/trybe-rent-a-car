namespace RentACar.Models
{
    public abstract class AbstractVehicle : IVehicle
    {
        public abstract string Color { get; }
        protected abstract decimal DailyValue { get; }

        public virtual decimal GetDailyValue() => DailyValue * 0;
    }
}

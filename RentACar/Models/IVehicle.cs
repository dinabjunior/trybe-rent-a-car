namespace RentACar.Models
{
    public interface IVehicle
    {
        string Color { get; }

        decimal GetDailyValue();
    }
}

using RentACar.Models;
using RentACar.Models.Vehicles;
using Xunit.Abstractions;

namespace RestACar.Tests
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Test_RentAMultipleVehicles()
        {
            var vehicles = new List<IVehicle>
            {
                new Car("Black", 60),
                new Car("Red", 60),
                new Bus("White", 120),
                new Motorcycle("White", 40),
                new Motorcycle("Red", 40)
            };

            var rentedVehicles = new List<IVehicle>();
            rentedVehicles.Add(vehicles.First(e => e is Car));
            rentedVehicles.Add(vehicles.First(e => e is Bus && e.Color == "White"));
            rentedVehicles.Add(vehicles.First(e => e is Motorcycle && e.Color == "Red"));

            var totalRentValue = rentedVehicles.CalculateTotalRentValue();
            _testOutputHelper.WriteLine($"Rented Value: {totalRentValue:C2}");
        }
    }
}
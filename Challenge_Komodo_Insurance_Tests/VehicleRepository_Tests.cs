using System;
using System.Collections.Generic;
using Challenge_Komodo_Insurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_Komodo_Insurance_Tests
{
    [TestClass]
    public class VehicleRepository_Tests
    {
        List<Vehicle> _list;
        VehicleRepository _vehicleRepo;

        [TestInitialize]
        public void Arrange()
        {
            _list = new List<Vehicle>();
            _vehicleRepo = new VehicleRepository(_list);
        }

        [TestMethod]
        public void VehicleRepository_AddVehicleToList_ShouldBeCorrectCount()
        {
            Vehicle vehicle = new Vehicle();
            Vehicle vehicleTwo = new Vehicle();

            _vehicleRepo.AddVehicleToList(vehicle);
            _vehicleRepo.AddVehicleToList(vehicleTwo);

            int actual = _vehicleRepo.GetVehicleList().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VehicleRepository_CalculateVehiclePremium_DecimalShouldBeEqual()
        {
            Arrange();

            Vehicle vehicle = new Vehicle();
            Vehicle vehicleTwo = new Vehicle();
            vehicle.Mileage = 100000;
            vehicleTwo.Mileage = 75000;

            decimal actual = _vehicleRepo.CalculateVehiclePremium(vehicle);
            decimal actualTwo = _vehicleRepo.CalculateVehiclePremium(vehicleTwo);

            decimal expected = 50;
            decimal expectedTwo = 25;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedTwo, actualTwo);
        }
    }
}

using NUnit.Framework;

namespace Testing
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ConstructorShouldInitializeCorrectly()
        {
            //TO DO
        }
        [Test]
        public void ModelShouldThrowArgExWhenNameIsNull()
        {
            //TO DO
        }
        [Test]
        public void MakeShouldThrowArgExWhenNameIsNull()
        {
            //TO DO
        }
        [Test]
        public void FuelConsumptionShouldThrowArgExWhenIsBellowZero()
        {
            //TO DO
        }
        [Test]
        public void FuelConsumptionShouldThrowArgExWhenIsZero()
        {
            //TO DO
        }
        [Test]
        public void FuelCapacityShouldThrowArgExWhenIsZero()
        {
            //TO DO
        }
        [Test]
        public void FuelCapacityShouldThrowArgExWhenIsBellowZero()
        {
            //TO DO
        }
        [Test]
        [TestCase]
        //TO DO
        public void ValidateAllProperties()
        {
            //TO DO
        }

        [Test]
        public void ShouldRefuelNormally()
        {
            //TO DO
        }
        [Test]
        public void ShouldRefuelUntillTotalFuelCapacity()
        {
            //TO DO
        }
        [Test]
        //TO DO
        public void ShouldRefuelThrowArgExWhenInputAmountIsBelloZero()
        {
            //TO DO
        }
        [Test]
        public void ShouldDriveNormally()
        {
            //TO DO
        }
        [Test]
        public void DriveShouldThrowInvalidOperationExceptionWhenFuelAmountIsNotEnough()
        {
            //TO DO
        }
    }
}
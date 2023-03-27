using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkTests
{
    internal class VehiclesTests
    {
        [Test]
        public void WhenADefaultVehicleIsConstructedItsPositionIsZero()
        {
            Vehicle v = new Vehicle();
            Assert.That(v.Position, Is.EqualTo(0));
        }

        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.That(v.Position, Is.EqualTo(20));
            Assert.That(result, Is.EqualTo("Moving along 2 times"));
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.That(v.Position, Is.EqualTo(40));
            Assert.That(result, Is.EqualTo("Moving along"));
        }

        [TestCase(-1, 0)] //no. of passengers = -1, expect 0
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(3, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 5)] //no. of passengers = 6, despite the capacity being 5. The expeted no
        public void VehicleCapacityTests(int numPassengers, int expectedPassengers)
        {
            Vehicle v = new Vehicle(5,10)
            {
                NumPassengers = numPassengers
            };
            Assert.That(v.NumPassengers, Is.EqualTo(expectedPassengers));
        }
    }
}

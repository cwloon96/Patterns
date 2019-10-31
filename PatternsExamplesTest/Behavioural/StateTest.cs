using NUnit.Framework;
using PatternsExamples.Behavioural.State;

namespace PatternsExamplesTest.Behavioural
{
    [TestFixture]
    public class StateTest
    {
        [Test]
        public void ShouldHasBatteryAndFullyCharged()
        {
            var phone = new Phone();

            phone.Charge();
            phone.Charge();
            phone.Charge();
            phone.Charge();
            phone.Charge();
            var battery = phone.Charge();

            Assert.AreEqual(battery, 100);
            Assert.IsTrue(phone.phoneState is HasBattery);
        }

        [Test]
        public void ShouldNoBattery()
        {
            var phone = new Phone();

            phone.Use();
            phone.Use();
            phone.Use();
            phone.Use();
            var battery = phone.Use();

            Assert.AreEqual(battery, 0);
            Assert.IsTrue(phone.phoneState is NoBattery);
        }

        [Test]
        public void ShouldHasBatteryAfterCharge()
        {
            var phone = new Phone();

            phone.Use();
            phone.Use();
            phone.Use();
            phone.Use();
            phone.Use();

            Assert.IsTrue(phone.phoneState is NoBattery);

            var battery = phone.Charge();
            Assert.AreEqual(battery, 10);
            Assert.IsTrue(phone.phoneState is HasBattery);
        }
    }
}
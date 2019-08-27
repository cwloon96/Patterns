using NUnit.Framework;
using PatternsExamples.Creational.SimpleFactory;

namespace PatternsExamplesTest.Creational
{
    [TestFixture]
    public class SimpleFactoryTest
    {
        [Test]
        public void ShouldCreateCarToy()
        {
            var car = ToySimpleFactory.GetToy(ToyType.Car);

            Assert.That(car is CarToy);
        }

        [Test]
        public void ShouldCreateFerryToy()
        {
            var ferry = ToySimpleFactory.GetToy(ToyType.Ferry);

            Assert.That(ferry is FerryToy);
        }

        [Test]
        public void ShouldCreateHelicopterToy()
        {
            var helicopter = ToySimpleFactory.GetToy(ToyType.Helicopter);

            Assert.That(helicopter is HelicopterToy);
        }
    }
}
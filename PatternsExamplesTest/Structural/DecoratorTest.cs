using NUnit.Framework;
using PatternsExamples.Structural.Decorator;

namespace PatternsExamplesTest.Structural
{
    [TestFixture]
    public class DecoratorTest
    {
        [Test]
        public void ShouldHaveMilkInMilo()
        {
            var milo = new MilkDecorator(new Milo());

            Assert.AreEqual(2.5 , milo.CalculateCost());
        }

        [Test]
        public void ShouldHaveDoubleMilkInMilo()
        {
            var milo = new MilkDecorator(new Milo());
            milo = new MilkDecorator(milo);

            Assert.AreEqual(3, milo.CalculateCost());
        }
    }
}
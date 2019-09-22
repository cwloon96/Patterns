using NUnit.Framework;
using PatternsExamples.Structural.Flyweight;

namespace PatternsExamplesTest.Structural
{
    [TestFixture]
    public class FlyweightTest
    {
        [Test]
        public void ShouldReturnSameInstance()
        {
            var redCircle1 = CircleFactory.GetCircle("red");
            var redCircle2 = CircleFactory.GetCircle("red");

            Assert.AreEqual(redCircle1, redCircle2);
        }
    }
}
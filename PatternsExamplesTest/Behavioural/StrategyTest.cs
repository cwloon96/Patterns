using NUnit.Framework;
using PatternsExamples.Behavioural.Strategy;

namespace PatternsExamplesTest.Behavioural
{
    [TestFixture]
    public class StrategyTest
    {
        [Test]
        public void ShouldHaveDiscount()
        {
            var cafe = new Cafe(new WeekEndStrategy());
            var bill = cafe.CalculateBill(100);

            Assert.AreEqual(100 * 0.8, bill);
        }

        [Test]
        public void ShouldNotHaveDiscount()
        {
            var cafe = new Cafe(new WeekDayStrategy());
            var bill = cafe.CalculateBill(100);

            Assert.AreEqual(100, bill);
        }
    }
}
using NUnit.Framework;
using PatternsExamples.Behavioural.Visitor;

namespace PatternsExamplesTest.Behavioural
{
    [TestFixture]
    public class VisitorTest
    {
        [Test]
        public void ShouldDiscountTwentyPercent()
        {
            var food = new Food(10);
            var afterDiscount = food.Accept(new DiscountVisitor());

            Assert.AreEqual(8, afterDiscount);
        }


        [Test]
        public void ShouldDiscountTenPercent()
        {
            var beverage = new Beverage(5);
            var afterDiscount = beverage.Accept(new DiscountVisitor());

            Assert.AreEqual(4.5, afterDiscount);
        }
    }
}
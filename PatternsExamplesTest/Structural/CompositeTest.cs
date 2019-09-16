using NUnit.Framework;
using PatternsExamples.Structural.Composite;

namespace PatternsExamplesTest.Structural
{
    [TestFixture]
    public class CompositeTest
    {
        [Test]
        public void CompositeImplementation()
        {
            var shop = new FoodCollection("KFC");
            var childCombo = new FoodCollection("Children Combo Box");
            childCombo.Add(new SimpleFood("Nugget"));
            childCombo.Add(new SimpleFood("Chicken"));

            var adultCombo = new FoodCollection("Adult Combo Box");
            adultCombo.Add(new SimpleFood("Burger"));
            adultCombo.Add(new SimpleFood("Chicken"));

            shop.Add(childCombo);
            shop.Add(adultCombo);

            var info = shop.ShowInfo();

            Assert.That(info.Length > 0);
        }
    }
}
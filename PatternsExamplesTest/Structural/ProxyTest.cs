using NUnit.Framework;
using PatternsExamples.Structural.Proxy;

namespace PatternsExamplesTest.Structural
{
    [TestFixture]
    public class ProxyTest
    {
        [Test]
        public void InternShouldAllowedToMakeOrder()
        {
            var proxy = new OrderSystemProxy("Intern");
            Assert.IsTrue(proxy.MakeOrder());
        }

        [Test]
        public void InternShouldNotAllowedToMakePayment()
        {
            var proxy = new OrderSystemProxy("Intern");
            Assert.IsFalse(proxy.MakePayment());
        }
    }
}
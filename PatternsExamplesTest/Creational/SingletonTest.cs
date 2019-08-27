using NUnit.Framework;
using PatternsExamples.Creational.Singleton;

namespace PatternsExamplesTest.Creational
{
    [TestFixture]
    public class SingletonTest
    {
        [Test]
        public void ShouldReturnEqualCounterWithMultipleCalls()
        {
            var singleton1 = Singleton.Instance;
            var singleton2 = Singleton.Instance;

            singleton1.Counter++;
            Assert.AreEqual(singleton1.Counter, singleton2.Counter);
        }

        [Test]
        public void ShouldReturnSameWithMultipleCalls()
        {
            var singleton1 = Singleton.Instance;
            var singleton2 = Singleton.Instance;
            
            Assert.AreSame(singleton1, singleton2);
        }
    }
}
using NUnit.Framework;
using PatternsExamples.Behavioural.Mediator;

namespace PatternsExamplesTest.Behavioural
{
    [TestFixture]
    public class MediatorTest
    {
        [Test]
        public void CounterAShouldReceiveMessage()
        {
            var counterA = new CounterA();
            var counterB = new CounterB();
            new CounterMediator(counterA, counterB);

            string message = "Hi Counter A";
            var counterAReceived = counterB.Send(message);

            Assert.AreEqual(counterAReceived, $"Counter A received message: {message}");
        }

        [Test]
        public void CounterBShouldReceiveMessage()
        {
            var counterA = new CounterA();
            var counterB = new CounterB();
            new CounterMediator(counterA, counterB);

            string message = "Hi Counter B";
            var counterBReceived = counterA.Send(message);

            Assert.AreEqual(counterBReceived, $"Counter B received message: {message}");
        }
    }
}
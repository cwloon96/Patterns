using NUnit.Framework;
using PatternsExamples.Behavioural.Command;

namespace PatternsExamplesTest.Behavioural
{
    [TestFixture]
    public class CommandTest
    {
        [Test]
        public void ShouldTurnOnLight()
        {
            var light = new Light();
            var controller = new Controller(new LightOnCommand(light), new LightOffCommand(light));
            controller.ClickOn();

            Assert.IsTrue(light.LightOn);
        }

        [Test]
        public void ShouldTurnOffAfterOnLight()
        {
            var light = new Light();
            var controller = new Controller(new LightOnCommand(light), new LightOffCommand(light));
            controller.ClickOn();
            controller.ClickOff();

            Assert.IsFalse(light.LightOn);
        }
    }
}
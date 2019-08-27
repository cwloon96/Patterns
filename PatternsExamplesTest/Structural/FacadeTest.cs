using NUnit.Framework;
using PatternsExamples.Structural.Facade;
using PatternsExamples.Structural.Facade.Models;

namespace PatternsExamplesTest.Structural
{
    [TestFixture]
    public class FacadeTest
    {
        [Test]
        public void ShouldSwitchOffAll()
        {
            var light = new Light();
            var tv = new TV();
            var musicSystem = new MusicSystem();
            var security = new Security();

            var facade = new HomeFacade(light, musicSystem, tv, security);
            facade.LeaveHome();

            Assert.That(!light.IsSwitchOn);
            Assert.That(!tv.IsSwitchOn);
            Assert.That(!musicSystem.IsSwitchOn);
            Assert.That(!security.IsSwitchOn);
        }

        [Test]
        public void ShouldSwitchOnAll()
        {
            var light = new Light();
            var tv = new TV();
            var musicSystem = new MusicSystem();
            var security = new Security();

            var facade = new HomeFacade(light, musicSystem, tv, security);
            facade.ArriveHome();

            Assert.That(light.IsSwitchOn);
            Assert.That(tv.IsSwitchOn);
            Assert.That(musicSystem.IsSwitchOn);
            Assert.That(security.IsSwitchOn);
        }
    }
}
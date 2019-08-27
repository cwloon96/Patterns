using NUnit.Framework;
using PatternsExamples.Behavioural.Observer;

namespace PatternsExamplesTest.Behavioural
{
    [TestFixture]
    public class ObserverTest
    {
        [Test]
        public void ShouldNotifyWhenObservableChange()
        {
            var station = new WeatherStation();
            var display = new PhoneDisplay(station);

            station.SetTemperature(10);
            Assert.AreEqual(station.Temperature, display.Temperature);
        }
    }
}
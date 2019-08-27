namespace PatternsExamples.Behavioural.Observer
{
    public interface IObserver
    {
        void Update();
    } 

    public class PhoneDisplay : IObserver
    {
        protected WeatherStation Station;

        public double Temperature { get; private set; }

        public PhoneDisplay(WeatherStation station)
        {
            Station = station;
            Station.AddObserver(this);
        }

        public void Update()
        {
            Temperature = Station.Temperature;
        }
    }
}
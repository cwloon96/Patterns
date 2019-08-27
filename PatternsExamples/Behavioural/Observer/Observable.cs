using System.Collections;
using System.Collections.Generic;

namespace PatternsExamples.Behavioural.Observer
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }

    public class WeatherStation : IObservable
    {
        List<IObserver> Observers;

        public double Temperature { get; private set; }

        public WeatherStation()
        {
            Observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (var observer in Observers)
            {
                observer.Update();
            }
        }

        public void SetTemperature(double temperature)
        {
            Temperature = temperature;
            NotifyObserver();
        }
    }
}
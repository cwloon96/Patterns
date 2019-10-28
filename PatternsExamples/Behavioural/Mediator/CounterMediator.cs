namespace PatternsExamples.Behavioural.Mediator
{
    public interface ICounterMediator
    {
        string SendMessage(string message, Counter counter);
    }

    public class CounterMediator : ICounterMediator
    {
        protected CounterA _counterA;
        protected CounterB _counterB;

        public CounterMediator(CounterA counterA, CounterB counterB)
        {
            _counterA = counterA;
            _counterA.SetMediator(this);
            _counterB = counterB;
            _counterB.SetMediator(this);
        }

        public string SendMessage(string message, Counter counter)
        {
            if (counter.Equals(_counterA))
                return _counterB.Notify(message);
            else
                return _counterA.Notify(message);
        }
    }
}
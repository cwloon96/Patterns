using System;

namespace PatternsExamples.Behavioural.Mediator
{
    public abstract class Counter
    {
        protected ICounterMediator _mediator;

        public void SetMediator(ICounterMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract string Send(string message);
        public abstract string Notify(string message);
    }

    public class CounterA : Counter
    {
        public override string Send(string message)
        {
            return _mediator.SendMessage(message, this);
        }

        public override string Notify(string message)
        {
            return $"Counter A received message: {message}";
        }
    }

    public class CounterB : Counter
    {
        public override string Send(string message)
        {
            return _mediator.SendMessage(message, this);
        }

        public override string Notify(string message)
        {
            return $"Counter B received message: {message}";
        }
    }
}
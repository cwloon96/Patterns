namespace PatternsExamples.Structural.Decorator
{
    public abstract class AddOnDecorator : Beverage
    {
    }

    public class MilkDecorator : AddOnDecorator
    {
        protected Beverage Beverage;

        public MilkDecorator(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double CalculateCost()
        {
            return Beverage.CalculateCost() + 0.5;
        }
    }

    public class SugarDecorator : AddOnDecorator
    {
        protected Beverage Beverage;

        public SugarDecorator(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double CalculateCost()
        {
            return Beverage.CalculateCost() + 0.3;
        }
    }
}
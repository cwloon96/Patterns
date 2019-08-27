namespace PatternsExamples.Structural.Decorator
{
    public abstract class Beverage
    {
        public abstract double CalculateCost();
    }

    public class Milo : Beverage
    {
        public override double CalculateCost()
        {
            return 2;
        }
    }

    public class Tea : Beverage
    {
        public override double CalculateCost()
        {
            return 1;
        }
    }
}
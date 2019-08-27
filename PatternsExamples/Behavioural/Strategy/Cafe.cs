namespace PatternsExamples.Behavioural.Strategy
{
    public class Cafe
    {
        private IDiscountStrategy DiscountStrategy;

        public Cafe(IDiscountStrategy strategy)
        {
            DiscountStrategy = strategy;
        }

        public double CalculateBill(decimal bill)
        {
            return DiscountStrategy.CalculateBill(bill);
        }
    }
}
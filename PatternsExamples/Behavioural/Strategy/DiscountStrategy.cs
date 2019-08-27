namespace PatternsExamples.Behavioural.Strategy
{
    public interface IDiscountStrategy
    {
        double CalculateBill(decimal bill);
    }

    public class WeekEndStrategy : IDiscountStrategy
    {
        public double CalculateBill(decimal bill)
        {
            return (double)bill * 0.8;
        }
    }

    public class WeekDayStrategy : IDiscountStrategy
    {
        public double CalculateBill(decimal bill)
        {
            return (double)bill;
        }
    }
}
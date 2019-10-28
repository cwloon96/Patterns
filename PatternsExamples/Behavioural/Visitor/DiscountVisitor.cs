namespace PatternsExamples.Behavioural.Visitor
{
    public interface IDiscountVisitor
    {
        decimal Visit(Food visitable);
        decimal Visit(Beverage visitable);
    }

    public class DiscountVisitor : IDiscountVisitor
    {
        public decimal Visit(Food food)
        {
            return food.Price * 0.8M;
        }

        public decimal Visit(Beverage beverage)
        {
            return beverage.Price * 0.9M;
        }
    }
}
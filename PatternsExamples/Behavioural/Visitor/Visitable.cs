namespace PatternsExamples.Behavioural.Visitor
{
    public abstract class Visitable
    {
        public decimal Price { get; set; }

        public Visitable(decimal price)
        {
            Price = price;
        }

        public abstract decimal Accept(IDiscountVisitor visitor);
    }

    public class Food : Visitable
    {
        public Food(decimal price) : base(price)
        {
        }

        public override decimal Accept(IDiscountVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    public class Beverage : Visitable
    {
        public Beverage(decimal price) : base(price)
        {
        }

        public override decimal Accept(IDiscountVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
namespace PatternsExamples.Structural.Flyweight
{
    public interface IShape
    {
        string Color { get; set; }
    }

    public class Circle : IShape
    {
        public string Color { get; set; }

        public Circle(string color)
        {
            Color = color;
        }
    }
}
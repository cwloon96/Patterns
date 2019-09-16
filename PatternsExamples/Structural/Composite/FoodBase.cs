namespace PatternsExamples.Structural.Composite
{
    public abstract class FoodBase
    {
        public string Name { get; protected set; }

        public FoodBase(string name)
        {
            Name = name;
        }

        public abstract string ShowInfo(int indent = 0);
    }
}
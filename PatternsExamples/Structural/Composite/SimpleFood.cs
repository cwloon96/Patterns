using System;

namespace PatternsExamples.Structural.Composite
{
    public class SimpleFood : FoodBase
    {
        public SimpleFood(string name) : base(name)
        {
        }

        public override string ShowInfo(int indent = 0)
        {
            return $"{new string(' ', indent)}{Name}{Environment.NewLine}";
        }
    }
}
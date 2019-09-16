using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Structural.Composite
{
    public interface IComboBoxOperations
    {
        void Add(FoodBase food);
        void Remove(FoodBase food);
    }

    public class FoodCollection : FoodBase, IComboBoxOperations
    {
        private List<FoodBase> FoodList;

        public FoodCollection(string name) : base(name)
        {
            FoodList = new List<FoodBase>();
        }

        public void Add(FoodBase food)
        {
            FoodList.Add(food);
        }

        public void Remove(FoodBase food)
        {
            FoodList.Remove(food);
        }

        public override string ShowInfo(int indent = 0)
        {
            var builder = new StringBuilder($"{new string(' ', indent)}{Name} contains : {Environment.NewLine}");

            FoodList.ForEach((food) => { builder.Append(food.ShowInfo(indent + 2)); });

            return builder.ToString();
        }
    }
}
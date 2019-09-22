using System.Collections.Generic;

namespace PatternsExamples.Structural.Flyweight
{
    public class CircleFactory
    {
        private static Dictionary<string, IShape> circleMap = new Dictionary<string, IShape>();

        public static IShape GetCircle(string color)
        {
            if (circleMap.ContainsKey(color))
                return circleMap[color];

            var circle = new Circle(color);
            circleMap.Add(color, circle);
            return circle;
        }
    }
}
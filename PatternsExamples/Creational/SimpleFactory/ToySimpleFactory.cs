using System;

namespace PatternsExamples.Creational.SimpleFactory
{
    public class ToySimpleFactory
    {
        public static IToy GetToy(ToyType type)
        {
            switch (type)
            {
                case ToyType.Car: return new CarToy();
                case ToyType.Ferry: return new FerryToy();
                case ToyType.Helicopter: return new HelicopterToy();
                default: throw new Exception("Invalid toy type");
            }
        }
    }
}
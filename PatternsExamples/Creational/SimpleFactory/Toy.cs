using System;

namespace PatternsExamples.Creational.SimpleFactory
{
    public interface IToy
    {
        void Prepare();
        void Package();
        void Label();
        void ShowType();
    }

    public enum ToyType
    {
        Car,
        Helicopter,
        Ferry
    }

    public enum ToyStyle
    {
        Cool,
        Beautiful,
        Cute,
        None
    }

    public abstract class Toy : IToy
    {
        public ToyStyle ToyStyle { get; private set; }

        public ToyType Type { get; protected set; }

        public decimal Price { get; protected set; }

        public Toy()
        {
            ToyStyle = ToyStyle.None;
        }

        public Toy(ToyStyle style)
        {
            ToyStyle = style;
        }

        public void Prepare() => Console.WriteLine($"A {ToyStyle.ToString()} Style of {Type.ToString()} is prepared.");

        public void Package() => Console.WriteLine($"{Type.ToString()} is packaged.");

        public void Label() => Console.WriteLine($"{Type.ToString()} is RM {Price}.");

        public abstract void ShowType();
    }

    public class CarToy : Toy
    {
        public CarToy() { }

        public CarToy(ToyStyle style) : base(style)
        {
            Type = ToyType.Car;
            Price = 20;
        }

        public override void ShowType() => Console.WriteLine("Car Toy");
    }

    public class HelicopterToy : Toy
    {
        public HelicopterToy() { }

        public HelicopterToy(ToyStyle style) : base(style)
        {
            Type = ToyType.Helicopter;
            Price = 50;
        }

        public override void ShowType() => Console.WriteLine("Helicopter Toy");
    }

    public class FerryToy : Toy
    {
        public FerryToy() { }

        public FerryToy(ToyStyle style) : base(style)
        {
            Type = ToyType.Ferry;
            Price = 30;
        }

        public override void ShowType() => Console.WriteLine("Ferry Toy");
    }
}
using PatternsExamples.Creational.SimpleFactory;

namespace PatternsExamples.Creational.FactoryMethod
{
    public interface IToyFactory
    {
        Toy ProductToy(ToyStyle style);
    }

    public abstract class ToyFactory : IToyFactory
    {
        public Toy ProductToy(ToyStyle style)
        {
            var toy = CreateToy(style); // Factory method
            toy.Prepare();
            toy.Package();
            toy.Label();

            return toy;
        }

        protected abstract Toy CreateToy(ToyStyle style);
    }

    public class CarToyFactory : ToyFactory
    {
        protected override Toy CreateToy(ToyStyle style) => new CarToy(style);
    }

    public class HelicopterToyFactory : ToyFactory
    {
        protected override Toy CreateToy(ToyStyle style) => new HelicopterToy(style);
    }

    public class FerryToyFactory : ToyFactory
    {
        protected override Toy CreateToy(ToyStyle style) => new FerryToy(style);
    }
}
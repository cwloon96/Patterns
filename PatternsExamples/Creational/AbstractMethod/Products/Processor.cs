namespace PatternsExamples.Creational.AbstractMethod.Products
{
    public enum ProcessorType
    {
        I5,
        I7
    }

    public interface IProcessor
    {
        ProcessorType GetProcessor();
    }

    public class I5 : IProcessor
    {
        public ProcessorType GetProcessor()
        {
            return ProcessorType.I5;
        }
    }

    public class I7 : IProcessor
    {
        public ProcessorType GetProcessor()
        {
            return ProcessorType.I7;
        }
    }
}
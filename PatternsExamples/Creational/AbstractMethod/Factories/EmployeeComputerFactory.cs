using PatternsExamples.Creational.AbstractMethod.Products;

namespace PatternsExamples.Creational.AbstractMethod.Factories
{
    public interface IEmployeeComputerFactory
    {
        IProcessor CreateProcessor();
        IOperatingSystem CreateOperatingSystem();
    }

    public class ITManagerFactory : IEmployeeComputerFactory
    {
        public IOperatingSystem CreateOperatingSystem()
        {
            return new Linux();
        }

        public IProcessor CreateProcessor()
        {
            return new I7();
        }
    }

    public class HRStaffFactory : IEmployeeComputerFactory
    {
        public IOperatingSystem CreateOperatingSystem()
        {
            return new Windows();
        }

        public IProcessor CreateProcessor()
        {
            return new I5();
        }
    }
}
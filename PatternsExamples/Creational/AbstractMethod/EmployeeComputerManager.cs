using PatternsExamples.Creational.AbstractMethod.Factories;
using PatternsExamples.Creational.AbstractMethod.Products;

namespace PatternsExamples.Creational.AbstractMethod
{
    public class EmployeeComputerManager
    {
        protected IEmployeeComputerFactory ComputerFactory;

        public EmployeeComputerManager(IEmployeeComputerFactory computerFactory)
        {
            ComputerFactory = computerFactory;
        }

        public Computer CreateComputer()
        {
            var computer = new Computer
            {
                OperatingSystem = ComputerFactory.CreateOperatingSystem(),
                Processor = ComputerFactory.CreateProcessor()
            };

            return computer;
        }
    }

    public class Computer
    {
        public IProcessor Processor { get; set; }
        public IOperatingSystem OperatingSystem { get; set; }
    }
}

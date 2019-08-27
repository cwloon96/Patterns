using NUnit.Framework;
using PatternsExamples.Creational.AbstractMethod;
using PatternsExamples.Creational.AbstractMethod.Factories;
using PatternsExamples.Creational.AbstractMethod.Products;

namespace PatternsExamplesTest.Creational
{
    [TestFixture]
    public class AbstractFactoryTest
    {
        [Test]
        public void ShouldReturnLinuxI7()
        {
            var computerManager = new EmployeeComputerManager(new ITManagerFactory());
            var computer = computerManager.CreateComputer();

            Assert.That(computer.OperatingSystem.GetOperatingSystem() == OperatingSystemType.Linux);
            Assert.That(computer.Processor.GetProcessor() == ProcessorType.I7);
        }

        [Test]
        public void ShouldReturnWindowsI5()
        {
            var computerManager = new EmployeeComputerManager(new HRStaffFactory());
            var computer = computerManager.CreateComputer();

            Assert.That(computer.OperatingSystem.GetOperatingSystem() == OperatingSystemType.Windows);
            Assert.That(computer.Processor.GetProcessor() == ProcessorType.I5);
        }
    }
}
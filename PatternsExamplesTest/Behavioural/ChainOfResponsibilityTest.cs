using NUnit.Framework;
using PatternsExamples.Behavioural.ChainOfResponsibility;

namespace PatternsExamplesTest.Behavioural
{
    [TestFixture]
    public class ChainOfResponsibilityTest
    {
        [Test]
        public void ShouldAddDataByJunior()
        {
            var executor = ChainOfExecutor.GetExecutorChain();
            var addResponse = executor.HandleRequest("Dog", Executor.AddData);
            Assert.AreEqual(addResponse, "Dog is added by JuniorDeveloper");
        }

        [Test]
        public void ShouldUpdateDataBySenior()
        {
            var executor = ChainOfExecutor.GetExecutorChain();
            var updateResponse = executor.HandleRequest("Cat", Executor.UpdateData);
            Assert.AreEqual(updateResponse, "Cat is updated by SeniorDeveloper");
        }

        [Test]
        public void ShouldDeleteDataByLead()
        {
            var executor = ChainOfExecutor.GetExecutorChain();
            var deleteResponse = executor.HandleRequest("Cow", Executor.DeleteData);
            Assert.AreEqual(deleteResponse, "Cow is deleted by TeamLead");
        }

        [Test]
        public void ShouldNoActionPerformed()
        {
            var executor = ChainOfExecutor.GetExecutorChain();
            var dropResponse = executor.HandleRequest("Database", Executor.DropDatabase);
            Assert.AreEqual(dropResponse, "No Action Performed");
        }
    }
}
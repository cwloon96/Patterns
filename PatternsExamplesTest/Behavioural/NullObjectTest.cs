using NUnit.Framework;
using PatternsExamples.Behavioural.NullObject;

namespace PatternsExamplesTest.Behavioural
{
    [TestFixture]
    public class NullObjectTest
    {
        [Test]
        public void NullObjectImplementation()
        {
            var student1 = StudentFactory.GetStudent("Ali");
            var student2 = StudentFactory.GetStudent("HAha");

            Assert.AreEqual("Ali", student1.Name);
            Assert.AreEqual("Not Available", student2.Name);
        }
    }
}
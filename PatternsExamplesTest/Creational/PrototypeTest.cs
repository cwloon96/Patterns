using NUnit.Framework;
using PatternsExamples.Creational.Prototype;

namespace PatternsExamplesTest.Creational
{
    [TestFixture]
    public class PrototypeTest
    {
        [Test]
        public void ShouldReturnValueTypeDifferentReferenceTypeSame()
        {
            var person1 = new Person
            {
                Name = "A",
                Age = 10,
                Address = new Address
                {
                    Unit = 1,
                    Street = 2,
                    Zipcode = 3,
                    Country = "Malaysia"
                }
            };

            var person2 = person1.Clone();

            person2.Address.Unit = 5;
            person2.Age = 11;

            Assert.AreNotEqual(person1.Age, person2.Age);
            Assert.AreEqual(person1.Address.Unit, person2.Address.Unit);
        }

        [Test]
        public void ShouldReturnValueTypeDifferentReferenceTypeDifferent()
        {
            var person1 = new Person
            {
                Name = "A",
                Age = 10,
                Address = new Address
                {
                    Unit = 1,
                    Street = 2,
                    Zipcode = 3,
                    Country = "Malaysia"
                }
            };

            var person2 = person1.DeepCopy();

            person2.Address.Unit = 5;
            person2.Age = 11;

            Assert.AreNotEqual(person1.Age, person2.Age);
            Assert.AreNotEqual(person1.Address.Unit, person2.Address.Unit);
        }
    }
}
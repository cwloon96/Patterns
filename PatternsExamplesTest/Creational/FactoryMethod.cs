using NUnit.Framework;
using PatternsExamples.Creational.FactoryMethod;
using PatternsExamples.Creational.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExamplesTest.Creational
{
    [TestFixture]
    public class FactoryMethod
    {
        [Test]
        public void ShouldCreateCoolCar()
        {
            var carFactory = new CarToyFactory();
            var coolCar = carFactory.ProductToy(ToyStyle.Cool);

            Assert.That(coolCar is CarToy && coolCar.ToyStyle == ToyStyle.Cool);
        }

        [Test]
        public void ShouldCreateCuteFerry()
        {
            var ferryFactory = new FerryToyFactory();
            var coolFerry = ferryFactory.ProductToy(ToyStyle.Cute);

            Assert.That(coolFerry is FerryToy && coolFerry.ToyStyle == ToyStyle.Cute);
        }
    }
}

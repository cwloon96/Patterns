using NUnit.Framework;
using PatternsExamples.Creational.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExamplesTest.Creational
{
    [TestFixture]
    public class BuilderTest
    {
        [Test]
        public void ShouldBuildHuman()
        {
            var creator = new CharacterCreator(new HumanBuilder());
            creator.CreateCharacter();
            var human = creator.GetCharacter();

            Assert.That(human.Head == "Human Head" && human.Body == "Human Body" && human.Leg == "Human Leg");
        }

        [Test]
        public void ShouldBuildMonster()
        {
            var creator = new CharacterCreator(new MonsterBuilder());
            creator.CreateCharacter();
            var monster = creator.GetCharacter();

            Assert.That(monster.Head == "Monster Head" && monster.Body == "Monster Body" && monster.Leg == "Monster Leg");
        }

        [Test]
        public void ShouldBuildHumanFluentWay()
        {
            var creator = new CharacterFluentCreator(new HumanFluentBuilder());
            creator.CreateCharacter();
            var human = creator.GetCharacter();

            Assert.That(human.Head == "Human Head" && human.Body == "Human Body" && human.Leg == "Human Leg");
        }
    }
}

using NUnit.Framework;
using PatternsExamples.Behavioural.Memento;

namespace PatternsExamplesTest.Behavioural
{
    [TestFixture]
    public class MementoTest
    {
        [Test]
        public void ShouldRestoreToPreviousState()
        {
            var skillTree = new SkillTree { AttackLevel = 1, DefendLevel = 2 };
            var skillTreeMemory = new SkillTreeMemory(skillTree);

            skillTreeMemory.Save();
            skillTree.AttackLevel = 3;
            skillTreeMemory.Undo();

            Assert.AreEqual(skillTree.AttackLevel, 1);
        }
    }
}
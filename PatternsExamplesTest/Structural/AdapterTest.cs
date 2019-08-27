using NUnit.Framework;
using PatternsExamples.Structural.Adapter;

namespace PatternsExamplesTest.Structural
{
    [TestFixture]
    public class AdapterTest
    {
        [Test]
        public void ShouldReturnKnightActions()
        {
            var adapter = new KnightAdapter(new Knight());

            Assert.AreEqual(AttackMethod.SwordAttack, adapter.Attack());
            Assert.AreEqual(DefendMethod.ShieldDefend, adapter.Defend());
            Assert.AreEqual(DodgeMethod.SideStep, adapter.Dodge());
        }

        [Test]
        public void ShouldReturnMagicianActions()
        {
            var adapter = new MagicianAdapter(new Magician());

            Assert.AreEqual(AttackMethod.MagicAttack, adapter.Attack());
            Assert.AreEqual(DefendMethod.MagicShield, adapter.Defend());
            Assert.AreEqual(DodgeMethod.Fly, adapter.Dodge());
        }
    }
}
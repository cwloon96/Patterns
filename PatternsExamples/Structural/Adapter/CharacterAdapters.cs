namespace PatternsExamples.Structural.Adapter
{
    public class KnightAdapter : ICharacter
    {
        protected IKnight Knight;

        public KnightAdapter(IKnight knight)
        {
            Knight = knight;
        }

        public AttackMethod Attack()
        {
            return Knight.SwordAttack();
        }

        public DefendMethod Defend()
        {
            return Knight.ShieldDefend();
        }

        public DodgeMethod Dodge()
        {
            return Knight.SideStep();
        }
    }

    public class MagicianAdapter : ICharacter
    {
        protected IMagician Magician;

        public MagicianAdapter(IMagician magician)
        {
            Magician = magician;
        }

        public AttackMethod Attack()
        {
            return Magician.MagicAttack();
        }

        public DefendMethod Defend()
        {
            return Magician.MagicShield();
        }

        public DodgeMethod Dodge()
        {
            return Magician.Fly();
        }
    }
}
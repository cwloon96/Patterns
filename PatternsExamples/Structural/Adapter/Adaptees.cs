namespace PatternsExamples.Structural.Adapter
{
    public interface IKnight
    {
        AttackMethod SwordAttack();
        DefendMethod ShieldDefend();
        DodgeMethod SideStep();
    }

    public class Knight : IKnight
    {
        public AttackMethod SwordAttack()
        {
            return AttackMethod.SwordAttack;
        }

        public DefendMethod ShieldDefend()
        {
            return DefendMethod.ShieldDefend;
        }

        public DodgeMethod SideStep()
        {
            return DodgeMethod.SideStep;
        }
    }

    public interface IMagician
    {
        AttackMethod MagicAttack();
        DefendMethod MagicShield();
        DodgeMethod Fly();
    }

    public class Magician : IMagician
    {
        public AttackMethod MagicAttack()
        {
            return AttackMethod.MagicAttack;
        }

        public DefendMethod MagicShield()
        {
            return DefendMethod.MagicShield;
        }

        public DodgeMethod Fly()
        {
            return DodgeMethod.Fly;
        }
    }

    public enum AttackMethod
    {
        SwordAttack,
        MagicAttack
    }

    public enum DefendMethod
    {
        ShieldDefend,
        MagicShield
    }

    public enum DodgeMethod
    {
        SideStep,
        Fly
    }
}
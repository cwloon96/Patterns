namespace PatternsExamples.Structural.Adapter
{
    public interface ICharacter
    {
        AttackMethod Attack();
        DefendMethod Defend();
        DodgeMethod Dodge();
    }
}
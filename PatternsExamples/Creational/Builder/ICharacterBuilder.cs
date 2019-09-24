namespace PatternsExamples.Creational.Builder
{
    public interface ICharacterBuilder
    {
        void BuildHead();
        void BuildBody();
        void BuildLeg();
        Character GetCharacter();
    }

    public interface ICharacterFluentBuilder
    {
        ICharacterFluentBuilder BuildHead();
        ICharacterFluentBuilder BuildBody();
        ICharacterFluentBuilder BuildLeg();
        Character GetCharacter();
    }
}
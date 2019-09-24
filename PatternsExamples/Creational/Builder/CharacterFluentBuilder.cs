namespace PatternsExamples.Creational.Builder
{
    public class HumanFluentBuilder : ICharacterFluentBuilder
    {
        private Character character;

        public HumanFluentBuilder()
        {
            character = new Character();
        }

        public ICharacterFluentBuilder BuildBody()
        {
            character.Body = "Human Body";
            return this;
        }

        public ICharacterFluentBuilder BuildHead()
        {
            character.Head = "Human Head";
            return this;
        }

        public ICharacterFluentBuilder BuildLeg()
        {
            character.Leg = "Human Leg";
            return this;
        }

        public Character GetCharacter() => character;
    }

    public class MonsterFluentBuilder : ICharacterFluentBuilder
    {
        private Character character;

        public MonsterFluentBuilder()
        {
            character = new Character();
        }

        public ICharacterFluentBuilder BuildBody()
        {
            character.Body = "Monster Body";
            return this;
        }

        public ICharacterFluentBuilder BuildHead()
        {
            character.Head = "Monster Head";
            return this;
        }

        public ICharacterFluentBuilder BuildLeg()
        {
            character.Leg = "Monster Leg";
            return this;
        }

        public Character GetCharacter() => character;
    }
}
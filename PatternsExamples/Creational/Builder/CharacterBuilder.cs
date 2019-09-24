namespace PatternsExamples.Creational.Builder
{
    public class HumanBuilder : ICharacterBuilder
    {
        private Character character;

        public HumanBuilder()
        {
            character = new Character();
        }

        public void BuildBody() => character.Body = "Human Body";

        public void BuildHead() => character.Head = "Human Head";

        public void BuildLeg() => character.Leg = "Human Leg";

        public Character GetCharacter() => character;
    }

    public class MonsterBuilder : ICharacterBuilder
    {
        private Character character;

        public MonsterBuilder()
        {
            character = new Character();
        }

        public void BuildBody() => character.Body = "Monster Body";

        public void BuildHead() => character.Head = "Monster Head";

        public void BuildLeg() => character.Leg = "Monster Leg";

        public Character GetCharacter() => character;
    }
}
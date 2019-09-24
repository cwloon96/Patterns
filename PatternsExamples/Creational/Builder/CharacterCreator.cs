using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExamples.Creational.Builder
{
    public class CharacterCreator
    {
        private ICharacterBuilder CharacterBuilder;
        public CharacterCreator(ICharacterBuilder characterBuilder)
        {
            CharacterBuilder = characterBuilder;
        }

        public void CreateCharacter()
        {
            CharacterBuilder.BuildHead();
            CharacterBuilder.BuildBody();
            CharacterBuilder.BuildLeg();
        }

        public Character GetCharacter()
        {
            return CharacterBuilder.GetCharacter();
        }
    }

    public class CharacterFluentCreator
    {
        private ICharacterFluentBuilder CharacterBuilder;
        public CharacterFluentCreator(ICharacterFluentBuilder characterBuilder)
        {
            CharacterBuilder = characterBuilder;
        }

        public void CreateCharacter()
        {
            CharacterBuilder.BuildBody().BuildHead().BuildLeg();
        }

        public Character GetCharacter()
        {
            return CharacterBuilder.GetCharacter();
        }
    }
}

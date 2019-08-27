using System;

namespace PatternsExamples.Behavioural.TemplateMethod
{
    public interface ICharacter
    {
        void BuildCharacter();
        void BuildHead();
        void BuildBody();
        void BuildLeg();
    }               
    
    public abstract class CharaterBase : ICharacter
    {
        public void BuildCharacter()
        {
            BuildHead();
            BuildBody();
            BuildLeg();
            Finish();
        }

        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildLeg();

        private void Finish()
        {
            Console.WriteLine("Build Success.");
        }
    }

    public class Human : CharaterBase
    {
        public override void BuildBody()
        {
            Console.WriteLine("Building Human Head.");
        }

        public override void BuildHead()
        {
            Console.WriteLine("Building Human Body.");
        }

        public override void BuildLeg()
        {
            Console.WriteLine("Building Human Leg.");
        }
    }

    public class Elf : CharaterBase
    {
        public override void BuildBody()
        {
            Console.WriteLine("Building Elf Head.");
        }

        public override void BuildHead()
        {
            Console.WriteLine("Building Elf Body.");
        }

        public override void BuildLeg()
        {
            Console.WriteLine("Building Elf Leg.");
        }
    }
}
using System;

namespace PatternsExamples.Behavioural.Memento
{
    //memento class
    public class SkillTreeMemento
    {
        public int AttackLevel { get; set; }

        public int DefendLevel { get; set; }

        public DateTime CreateDate { get; set; }

        public SkillTreeMemento(int attackLevel, int defendLevel)
        {
            AttackLevel = attackLevel;
            DefendLevel = defendLevel;
            CreateDate = DateTime.Now;
        }
    }
}
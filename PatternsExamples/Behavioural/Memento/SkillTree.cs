namespace PatternsExamples.Behavioural.Memento
{
    // Originator class
    public class SkillTree
    {
        public int AttackLevel { get; set; }

        public int DefendLevel { get; set; }

        public SkillTreeMemento Save()
        {
            return new SkillTreeMemento(AttackLevel, DefendLevel);
        }

        public void Restore(SkillTreeMemento memento)
        {
            AttackLevel = memento.AttackLevel;
            DefendLevel = memento.DefendLevel;
        }
    }
}
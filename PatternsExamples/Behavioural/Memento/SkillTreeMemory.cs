using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternsExamples.Behavioural.Memento
{
    // caretaker
    public class SkillTreeMemory
    {
        private List<SkillTreeMemento> _mementos;

        private SkillTree _skillTree;

        public SkillTreeMemory(SkillTree skillTree)
        {
            _skillTree = skillTree;
            _mementos = new List<SkillTreeMemento>();
        }

        public void Save()
        {
            _mementos.Add(_skillTree.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
                return;

            var lastMemento = _mementos.Last();
            _mementos.Remove(lastMemento);

            _skillTree.Restore(lastMemento);
        }

        public void ShowHistory()
        {
            foreach (var memento in _mementos)
            {
                Console.WriteLine($"{memento.CreateDate.ToString("dd-MM-yyyy HH:MM")} - Attack Level: {memento.AttackLevel}, Defend Level: {memento.DefendLevel}");
            }
        }
    }
}
namespace PatternsExamples.Behavioural.NullObject
{
    public class StudentBase
    {
        public string Name { get; protected set; }

        public StudentBase(string name)
        {
            Name = name;
        }
    }

    public class Student : StudentBase
    {
        public Student(string name) : base(name)
        {
        }
    }

    public class NullStudent : StudentBase
    {
        public NullStudent() : base("Not Available")
        {
        }
    }
}

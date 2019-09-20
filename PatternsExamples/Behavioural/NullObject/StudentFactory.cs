using System.Linq;

namespace PatternsExamples.Behavioural.NullObject
{
    public class StudentFactory
    {
        private static string[] StudentList = new string[] { "Ali", "Abu" };

        public static StudentBase GetStudent(string name)
        {
            if (StudentList.Contains(name))
                return new Student(name);

            return new NullStudent();
        }
    }
}
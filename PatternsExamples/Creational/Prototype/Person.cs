namespace PatternsExamples.Creational.Prototype
{
    public class Person : Clonable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public int Unit { get; set; }
        public int Street { get; set; }
        public int Zipcode { get; set; }
        public string Country { get; set; }
    }
}
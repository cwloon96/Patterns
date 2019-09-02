namespace PatternsExamples.Structural.Bridge
{
    public class Artist
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string ProfileUrl { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string PurchaseUrl { get; set; }
    }
}
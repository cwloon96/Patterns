namespace PatternsExamples.Structural.Bridge
{
    public interface IResource
    {
        string Snippet();
        string Title();
        string Url();
    }

    public class ArtistResource : IResource
    {
        protected Artist Artist;

        public ArtistResource(Artist artist)
        {
            Artist = artist;
        }

        public string Snippet()
        {
            return Artist.Bio;
        }

        public string Title()
        {
            return Artist.Name;
        }

        public string Url()
        {
            return Artist.ProfileUrl;
        }
    }

    public class BookResource : IResource
    {
        protected Book Book;

        public BookResource(Book book)
        {
            Book = book;
        }

        public string Snippet()
        {
            return Book.Summary;
        }

        public string Title()
        {
            return Book.Title;
        }

        public string Url()
        {
            return Book.PurchaseUrl;
        }
    }
}
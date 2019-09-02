using NUnit.Framework;
using PatternsExamples.Structural.Bridge;

namespace PatternsExamplesTest.Structural
{
    [TestFixture]
    public class BridgeTest
    {
        [Test]
        public void ShouldReturnLongViewArtist()
        {
            var artist = new Artist { Name = "Artist", Bio = "A new artist", ProfileUrl = "www.newartist.com" };
            var artistLongView = new LongView(new ArtistResource(artist));

            Assert.AreEqual($"Long View - {artist.Name} | {artist.Bio} | {artist.ProfileUrl}", artistLongView.Show());
        }
        
        [Test]
        public void ShouldReturnShortViewBook()
        {
            var book = new Book { Title = "Book", Summary = "A new book", PurchaseUrl = "www.purchasebook.com" };
            var bookLongView = new ShortView(new BookResource(book));

            Assert.AreEqual($"Short View - {book.Title} | {book.Summary} | {book.PurchaseUrl}", bookLongView.Show());
        }
    }
}
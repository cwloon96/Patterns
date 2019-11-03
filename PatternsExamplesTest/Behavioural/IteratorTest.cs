using NUnit.Framework;
using PatternsExamples.Behavioural.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExamplesTest.Behavioural
{
    [TestFixture]
    public class IteratorTest
    {
        [Test]
        public void ShouldAbleToAddAndRetrieveUntilEnd()
        {
            var animeCollection = new AnimeCollection();
            var conan = new Anime { Name = "Detective Conan" };
            var naruto = new Anime { Name = "Naruto" };
            var onepiece = new Anime { Name = "One Piece" };
            animeCollection.Add(conan);
            animeCollection.Add(naruto);
            animeCollection.Add(onepiece);

            var iterator = animeCollection.CreateIterator();

            for (var anime = iterator.First(); !iterator.IsLast; anime = iterator.Next())
            {
                Console.WriteLine(anime.Name);
            }

            Assert.AreEqual(iterator.Current.Name, onepiece.Name);
        }
    }
}

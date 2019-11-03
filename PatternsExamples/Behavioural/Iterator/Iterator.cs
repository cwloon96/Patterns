namespace PatternsExamples.Behavioural.Iterator
{
    public interface IAnimeIterator
    {
        Anime First();
        Anime Next();
        Anime Current { get; }
    }

    public class AnimeIterator : IAnimeIterator
    {
        private AnimeCollection _collection;
        private int currentIndex = 0;
        public bool IsLast { get; private set; }

        public AnimeIterator(AnimeCollection collection)
        {
            _collection = collection;
        }

        public Anime Current => _collection[currentIndex] as Anime;

        public Anime First()
        {
            return _collection[0] as Anime;
        }

        public Anime Next()
        {
            if ((currentIndex + 1) >= _collection.Count)
            {
                IsLast = true;
                return null;
            }
            currentIndex += 1;
            return _collection[currentIndex] as Anime;
        }
    }
}
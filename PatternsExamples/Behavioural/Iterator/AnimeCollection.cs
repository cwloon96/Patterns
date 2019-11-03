using System.Collections;

namespace PatternsExamples.Behavioural.Iterator
{
    public interface IAnimeCollection
    {
        AnimeIterator CreateIterator();
    }

    public class AnimeCollection : IAnimeCollection
    {
        private ArrayList _items = new ArrayList();

        public AnimeIterator CreateIterator()
        {
            return new AnimeIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public void Add(Anime anime)
        {
            _items.Add(anime);
        }

        public object this[int index]
        {
            get { return _items[index]; }
        }
    }
}
namespace PatternsExamples.Creational.Singleton
{
    public class Singleton
    {
        private static volatile Singleton _instance;
        private static readonly object obj = new object();

        public int Counter { get; set; } = 0;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (obj)
                    {
                        if (_instance == null)
                            _instance = new Singleton();
                    }
                }

                return _instance;
            }
        }
    }
}
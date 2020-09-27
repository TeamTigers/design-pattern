using System;

namespace design_pattern.Singleton
{
    public sealed class Singleton
    {
        private static int _counter = 0;
        private static Singleton _singleton = null;

        private Singleton()
        {
            ++_counter;
            Console.WriteLine($"Counter is now: {_counter}");
        }

        public static Singleton GetSingleton
        {
            get
            {
                if (_singleton == null)
                {
                    _singleton = new Singleton();
                }

                return _singleton;
            }
        }
    }
}
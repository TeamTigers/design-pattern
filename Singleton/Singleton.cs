using System;

namespace design_pattern.Singleton
{
    //
    // Class: Singleton
    // Implements singleton design pattern.
    // Keyword "sealed" restricts other class to inherit this class.
    //
    public sealed class Singleton
    {
        private static int _counter;
        private static Singleton _singleton;
        
        // Private constructor ensures publicly unavailability
        // and usage only by the Singleton class.
        private Singleton()
        {
            ++_counter;
            Console.WriteLine($"Counter is now: {_counter}");
        }
        
        // Publicly available getter to provide instance only once
        // and leveraging privately assigned property for rest of the time.
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
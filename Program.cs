using System;

namespace design_pattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var singleton1 = Singleton.GetSingleton;
            var singleton2 = Singleton.GetSingleton;
        }
    }
}
using SingletonDesignPattern = design_pattern.Singleton;

namespace design_pattern
{
    internal static class MainClass
    {
        private static void Main(string[] args)
        {
            var singleton1 = SingletonDesignPattern.Singleton.GetSingleton;
            var singleton2 = SingletonDesignPattern.Singleton.GetSingleton;
        }
    }
}
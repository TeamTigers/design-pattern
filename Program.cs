using System;

namespace design_pattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var pie = int.Parse(Console.ReadLine() ?? "3.14156");
            PrintLn($"Value of pie is: {pie}");
        }
        
        private static void PrintLn(object anyObject)
        {
            Console.WriteLine(anyObject);
        }
    }
}
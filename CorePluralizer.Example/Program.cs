using System;
using CorePluralizer.Extensions;

namespace CorePluralizer.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var singular = "World";

            var plural = singular.ToPlural();
            
            Console.WriteLine($"Hello {plural}!");
            
            var exampleWords = new string[]
            {
                "Leaf",
                "Stock",
                "Pitch",
                "Day",
                "Boy",
                "Plate",
                "City",
                "Cactus",
                "goose"
            };

            Console.WriteLine("-----------------------------");
            Console.WriteLine("        Some Examples        ");
            Console.WriteLine("-----------------------------");
            foreach (var word in exampleWords)
            {
                Console.WriteLine($"{word} -> {word.ToPlural()}");
            }
        }
    }
}

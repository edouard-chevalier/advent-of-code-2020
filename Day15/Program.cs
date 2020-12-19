using System;
using System.Linq;

namespace Day15
{
    class Program
    {
        private const string input = @"1,12,0,20,8,16";
        private const string test = @"0,3,6";
        private const string test1 = @"1,3,2";
        private const string test2 = @"2,1,3";
        private const string test3 = @"1,2,3";
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            exo1();
        }

        private static void exo1()
        {
            var nums = input.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();

            var ages = nums.Take( nums.Count - 1).Select((i, v) => (i, v)).ToDictionary((tuple => tuple.i), tuple => tuple.v);

            var lastSpoken = nums.Last();
            for (int i = nums.Count; i < 30000000; i++)
            {
                int spoken = 0;
                if (ages.TryGetValue(lastSpoken, out var pos)){
                    spoken = i - 1 - pos;
                }
                
                ages[lastSpoken] = i - 1;
                lastSpoken = spoken;
                if (i % 10000 == 0)
                {
                    Console.WriteLine($"{i}: {spoken}");
                }
            }
            Console.WriteLine(lastSpoken);
        }
    }
}
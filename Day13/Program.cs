using System;
using System.Linq;

namespace Day13
{
    class Program
    {
        private const string input = @"1003240
19,x,x,x,x,x,x,x,x,41,x,x,x,37,x,x,x,x,x,787,x,x,x,x,x,x,x,x,x,x,x,x,13,x,x,x,x,x,x,x,x,x,23,x,x,x,x,x,29,x,571,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,17
";
        private const string test = @"939
7,13,x,x,59,x,31,19";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            exo1();
        }

        static void exo1()
        {
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            int target = Int32.Parse(lines[0]);
            int[] bus = lines[1].Split(',', StringSplitOptions.RemoveEmptyEntries).Where(s => s != "x")
                .Select(Int32.Parse).ToArray();
            int min = Int32.MaxValue;
            int busID = -1;
            foreach (var bu in bus)
            {
                int wait = ((target / bu + 1) * bu) - target;
                if (wait < min)
                {
                    busID = bu;
                    min = wait;
                }
            }
            Console.WriteLine( busID * min);
        }
    }
}
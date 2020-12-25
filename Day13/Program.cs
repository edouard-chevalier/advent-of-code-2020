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
            exo2();
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
        
        static long modInverse(long a, long n) 
        {
            long i = n, v = 0, d = 1;
            while (a>0) {
                long t = i/a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t*x;
                v = x;
            }
            v %= n;
            if (v<0) v = (v+n)%n;
            return v;
        }
        
        static void exo2()
        {
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            int target = Int32.Parse(lines[0]);
            int[] bus = lines[1].Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s == "x" ? -1 : Int32.Parse(s)).ToArray();
            long ts = 0;
            long bftot = 1;

            for (int i = 0; i < bus.Length; i++)
            {
                if (bus[i] < 0) continue;
                int bf = bus[i];

                // (bftot * n) % bftot = ( bf - (ts + i) % bf) % bf;
                long inv = modInverse(bftot, bf);
                long res = (bf - (ts + i) % bf) % bf;
                long n = (inv * res) % bf;
                ts += bftot * n;
                bftot *= bf;
            }
            
            Console.WriteLine( ts);
        }
    }
}
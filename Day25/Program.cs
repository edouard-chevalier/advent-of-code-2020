using System;
using System.Linq;

namespace Day25
{
    class Program
    {
        private const string input = @"10441485
1004920
";
        private const string test = @"5764801
17807724";
        static void Main(string[] args)
        {
            exo1();
            
        }

        static long Transform(long subjectNumber, int loopSize, long res = 1)
        {
            for (int i = 0; i< loopSize; i++)
            {
                res *= subjectNumber;
                res %= 20201227;
            }

            return res;
        }

        static int  BruteForce(long publicKey )
        {
            long res = 1;
            for (int loopSize = 1; loopSize < 100000000; loopSize++)
            {
                res = Transform(7, 1, res);
                if (res == publicKey)
                {
                    return loopSize;
                }
            }

            throw new Exception();
        }
        static void exo1()
        {
            var vals = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse)
                .ToArray();

            long cardPublicKey = vals[0];
            int cardLoopSize = BruteForce(cardPublicKey);

            Console.WriteLine(cardLoopSize);
            long doorPublicKey = vals[1];
            int doorLoopSize = BruteForce(doorPublicKey);
            Console.WriteLine(doorLoopSize);

            Console.WriteLine(Transform(doorPublicKey, cardLoopSize));
            Console.WriteLine(Transform(cardPublicKey, doorLoopSize));

        }
    }
}
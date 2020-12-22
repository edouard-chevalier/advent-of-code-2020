using System;
using System.Collections.Generic;
using System.Linq;

namespace Day22
{
    class Program
    {
        private const string input = @"Player 1:
4
25
3
11
2
29
41
23
30
21
50
8
1
24
27
10
42
43
38
15
18
13
32
37
34

Player 2:
12
6
36
35
40
47
31
9
46
49
19
16
5
26
39
48
7
44
45
20
17
14
33
28
22
";
        private const string test = @"Player 1:
9
2
6
3
1

Player 2:
5
8
4
7
10";

        private const string testLoop = @"Player 1:
43
19

Player 2:
2
29
14";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            exo2();
        }

        private static void exo1()
        {
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Queue<int> deck1 = new Queue<int>();
            Queue<int> deck2 = new Queue<int>();

            Queue<int> currentDeck = null;
            foreach (var line in lines)
            {
                if (line.Trim() == "Player 1:")

                {
                    currentDeck = deck1;
                    continue;

                }
                if (line.Trim() == "Player 2:")
                {
                    currentDeck = deck2;
                    continue;
                }
                currentDeck.Enqueue(Int32.Parse(line));
            }

            while (deck1.Count > 0 && deck2.Count > 0)
            {
                int c1 = deck1.Dequeue();
                int c2 = deck2.Dequeue();
                if (c1 == c2)
                {
                    throw new Exception();
                }

                if (c1 > c2)
                {
                    deck1.Enqueue(c1);
                    deck1.Enqueue(c2);
                }
                else
                {
                    deck2.Enqueue(c2);
                    deck2.Enqueue(c1);
                }
            }

            var winnerDeck = deck1.Count > 0 ? deck1 : deck2;

            long sum = 0;
            long mul = winnerDeck.Count;
            while (winnerDeck.Count>0)
            {
                var dequeue = winnerDeck.Dequeue();
                Console.WriteLine($"{dequeue} * {mul}");

                sum += dequeue * mul;
                mul--;
            }
            Console.WriteLine(sum);

        }

        static bool AreEqual(int[] a, int[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }

        static int ArrayHashCode(int[] array)
        {
            int hc = array.Length;
            for (int i = 0; i < array.Length; ++i)
            {
                hc = unchecked(hc * 314159 + array[i]);
            }

            return hc;
        }

        public class RoundState : IEquatable<RoundState>
        {
            public RoundState(int[] player1, int[] player2)
            {
                Player1 = player1;
                Player2 = player2;
            }

            public bool Equals(RoundState other)
            {
                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return AreEqual(Player1,other.Player1) && AreEqual(Player2, other.Player2);
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((RoundState) obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return (ArrayHashCode(Player1) * 397) ^ ArrayHashCode(Player2);
                }
            }

            public int[] Player1 { get; }
            public int[] Player2 { get; }
        }
        private static void exo2()
        {
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            List<int> deck1 = new List<int>();
            List<int> deck2 = new List<int>();

            List<int> currentDeck = null;
            foreach (var line in lines)
            {
                if (line.Trim() == "Player 1:")

                {
                    currentDeck = deck1;
                    continue;

                }
                if (line.Trim() == "Player 2:")
                {
                    currentDeck = deck2;
                    continue;
                }
                currentDeck.Add(Int32.Parse(line));
            }

            bool Player1WinCombat(int[] player1Input, int[] player2Input, bool mainGame = false) {
                Queue<int> deck1 = new Queue<int>(player1Input);
                Queue<int> deck2 = new Queue<int>(player2Input);
                var states = new HashSet<RoundState>();
                while (deck1.Count > 0 && deck2.Count > 0)
                {
                    var roundState = new RoundState(deck1.ToArray(), deck2.ToArray());
                    if (states.Contains(roundState))
                    {
                        return true;
                    }
                    states.Add(roundState);
                    int c1 = deck1.Dequeue();
                    int c2 = deck2.Dequeue();
                    bool player1WindRound = false;
                    if (deck1.Count>=c1 && deck2.Count>=c2)
                    {
                        player1WindRound = Player1WinCombat(deck1.Take(c1).ToArray(), deck2.Take(c2).ToArray());
                    }
                    else
                    {
                        if (c1 == c2)
                        {
                            throw new Exception();
                        }

                        player1WindRound = c1 > c2;
                    }

                    if (player1WindRound)
                    {
                        deck1.Enqueue(c1);
                        deck1.Enqueue(c2);
                    }
                    else
                    {
                        deck2.Enqueue(c2);
                        deck2.Enqueue(c1);
                    }
                }

                var res = deck1.Count > 0;

                if (mainGame)
                {
                    var winnerDeck = deck1.Count > 0 ? deck1 : deck2;

                    long sum = 0;
                    long mul = winnerDeck.Count;
                    while (winnerDeck.Count>0)
                    {
                        var dequeue = winnerDeck.Dequeue();
                        Console.WriteLine($"{dequeue} * {mul}");

                        sum += dequeue * mul;
                        mul--;
                    }
                    Console.WriteLine(sum);
                }

                return res;

            }

            Player1WinCombat(deck1.ToArray(), deck2.ToArray(), true);

        }
    }
}
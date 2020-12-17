using System;
using System.Collections.Generic;
using System.Linq;

namespace Day10
{
    class Program
    {
        private const string input = @"126
38
162
123
137
97
92
67
136
37
146
2
139
74
101
163
128
127
13
111
30
117
3
93
29
152
80
21
7
54
69
40
48
104
110
142
57
116
31
70
28
151
108
20
157
121
47
75
94
39
73
77
129
41
24
44
132
87
114
58
64
4
10
19
138
45
76
147
59
155
156
83
118
109
107
160
61
91
102
115
68
150
34
16
27
135
161
46
122
90
1
164
100
103
84
145
51
60
";
        private const string test1 = @"16
10
15
5
1
11
7
19
6
12
4";
        private const string test2 = @"28
33
18
42
31
14
46
20
48
47
24
23
49
45
19
38
39
11
1
32
25
35
8
17
7
9
4
2
34
10
3";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            exo2();
        }

        static void exo1()
        {
            var jolts = new List<int>();
            jolts.Add(0);
            jolts.AddRange(input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse));
            jolts.Sort();

            int nb1 = 0;
            int nb2 = 0;
            int nb3 = 1;

            for (int i = 1; i < jolts.Count; i++)
            {
                switch (jolts[i] - jolts[i-1])
                {
                    case 1: nb1++;
                        break;
                    case 2: nb2++;
                        break;
                    case 3: nb3++;
                        break;
                    default: throw new Exception();

                }
            }
            Console.WriteLine(nb1*nb3);


        }

        static void exo2()
        {
            var jolts = new List<int>();
            jolts.Add(0);
            jolts.AddRange(input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse));
            jolts.Sort();

            int nb1 = 0;
            int nb2 = 0;
            int nb3 = 1;

            var cache = new Dictionary<int, long>();

            long NbCombinations(int adapterIdx) {
                if (adapterIdx == jolts.Count - 1) {
                    return 1;
                }

                if (cache.TryGetValue(adapterIdx, out var cached))
                {
                    return cached;
                }
                var currentJolt = jolts[adapterIdx];

                long res = 0;
                for (int i = adapterIdx + 1; i < jolts.Count; i++) {
                    if ( jolts[i] > ( currentJolt +3 ))
                    {
                        break;
                    }

                    res += NbCombinations(i);
                }

                cache[adapterIdx] = res;
                return res;
            }


            Console.WriteLine(NbCombinations(0));


        }
    }
}
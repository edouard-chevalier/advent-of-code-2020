﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Day19
{
    class Program
    {
        private const string input = @"7: 128 83 | 90 111
67: 128 128
73: 83 128
38: 90 55 | 128 126
69: 90 49 | 128 7
82: 122 128 | 111 90
55: 90 128 | 128 128
44: 51 90 | 123 128
25: 128 10 | 90 135
109: 128 16 | 90 68
129: 97 132
21: 97 128 | 111 90
71: 128 95 | 90 110
43: 128 104 | 90 134
120: 90 97 | 128 67
59: 77 90 | 95 128
50: 95 90
127: 90 106 | 128 61
35: 90 104 | 128 45
83: 128 90
10: 62 90 | 63 128
1: 90 112 | 128 103
57: 99 90 | 40 128
40: 128 2 | 90 93
2: 83 128 | 83 90
91: 128 96 | 90 64
45: 128 90 | 90 90
110: 90 90
123: 128 87 | 90 79
104: 128 132 | 90 90
121: 95 128 | 111 90
111: 90 128 | 90 90
124: 128 108 | 90 54
88: 55 128 | 26 90
125: 128 126 | 90 83
58: 90 78 | 128 14
118: 55 90 | 134 128
48: 116 90 | 86 128
130: 23 90 | 97 128
61: 90 43 | 128 56
78: 90 47 | 128 37
128: ""b""
99: 128 114 | 90 7
87: 128 111 | 90 23
84: 128 62 | 90 101
135: 34 90 | 30 128
41: 90 121 | 128 100
63: 45 90 | 122 128
115: 118 90 | 94 128
37: 97 90 | 55 128
23: 132 132
65: 128 45
98: 128 1 | 90 70
36: 90 69 | 128 19
122: 90 128
32: 128 50 | 90 85
114: 23 128 | 67 90
17: 128 83 | 90 55
103: 128 102 | 90 22
79: 128 67 | 90 134
94: 90 111 | 128 97
30: 128 122 | 90 77
89: 132 55
100: 122 128 | 126 90
11: 42 31
18: 21 90 | 7 128
86: 117 128 | 17 90
33: 95 90 | 111 128
6: 65 90 | 100 128
102: 35 90 | 49 128
14: 39 90 | 53 128
66: 83 90 | 67 128
105: 104 128 | 126 90
47: 90 26 | 128 122
16: 90 44 | 128 25
72: 97 128 | 55 90
53: 55 128 | 122 90
112: 128 6 | 90 124
75: 128 82 | 90 94
70: 90 24 | 128 52
31: 98 128 | 109 90
126: 90 90 | 128 128
49: 23 90 | 111 128
28: 90 130 | 128 129
54: 90 110 | 128 45
97: 128 90 | 90 128
80: 127 128 | 119 90
107: 128 133 | 90 92
27: 90 117 | 128 88
60: 90 23 | 128 134
0: 8 11
39: 23 90 | 55 128
13: 134 90 | 67 128
52: 115 90 | 41 128
77: 128 90 | 132 128
117: 128 67 | 90 83
90: ""a""
76: 134 132
26: 128 90 | 128 128
4: 58 128 | 9 90
20: 128 111 | 90 77
42: 46 128 | 15 90
116: 89 128 | 131 90
9: 18 90 | 84 128
5: 90 134 | 128 77
113: 128 76 | 90 20
95: 90 128 | 132 90
92: 113 128 | 32 90
12: 128 72 | 90 66
8: 42
74: 128 111 | 90 122
15: 3 90 | 107 128
24: 28 128 | 81 90
34: 90 67 | 128 95
3: 48 90 | 91 128
131: 132 26
51: 73 128 | 60 90
93: 126 90 | 67 128
108: 134 90 | 95 128
68: 57 128 | 36 90
133: 29 90 | 27 128
64: 38 90 | 59 128
56: 126 132
62: 128 122 | 90 97
85: 128 134 | 90 26
96: 33 90 | 5 128
132: 90 | 128
29: 5 128 | 74 90
81: 128 105 | 90 17
119: 90 12 | 128 75
101: 134 90
22: 128 131 | 90 71
134: 90 90 | 132 128
46: 4 90 | 80 128
106: 13 90 | 89 128
19: 125 128 | 120 90

bbbbababababbbaabbabbabbaabaabaaaabaabaabbabbbbbaabbbaaaaabbaabbaaaaaabb
baabbbbbbbabbbaaaaababbaaabbabbbaababbbb
abbbabaabaaabbaabababbaa
babbabaaababbbababbbabaabbbbbaaaabbbaaba
baabaababbbabababbbbaaaaabababbb
aabaaabbabaaaaaabaaabbaaabbaaababaaaabbaabaababaaaaabbab
abbbaabbbaababbaabbabbab
abbaababbbbbabbabaabaaaa
aaabaaabaabaabbbbbbbaaba
baaababbbabbbababaaabbbbaaabaaabaabbbbba
bbaabaaabaabaabaabbbbaaabbbbbaaaabbbaabbbabbaabbaabaabaabaaaabbb
babbabbbbabbbabaabbbbaaa
bbbaababaabaabbbaabaaabbaaabaabb
aabbbabbbabaaaababbbbbabaaaaabba
bbbbbbabaaaabbbababaaabb
aaababababababbaabbabbaaaaaabaabbabbbbbbabaaaaaabbbbbaabaabbaabb
aabbabaaaaababbaaabaabaa
aababaaaaabbaabaabbbbababaabaaabaabbbababbbbbaaabaaababbaaababba
aabbaaaaabbaabbbabbabaaababbabaaabaabbab
baaababababaabbbabbbbbbbabbabbbbbabababa
aababbababbbabaaaababababababaaa
aaaabbbabbaaaabababaaaabbaabaaab
ababbabbabaaaaaaabbababa
babbbbabababbabbbbabaabbbbbabbabbbbabbbb
bbbbabbbaaabbbaaababbbbabbabaabababaaaababbbabbabababbbbbaababbb
ababbbaababababbababbaba
baaababbababbbabaabaaabbaaabaabaaaaaaaaa
baaabbbaabbbbbbbaabbbbabaaaabbaaabbbbbbaaaaaabbbaababaaa
aaaaaaabbaaaabaabbbabbab
bbaaabbbbbaababaababaaba
abbbbbbabbabaabbaaaaabaabbbaabbbaaaabbbabababbaabaabbaabaaababba
bbbbaaaabbbbababaabababb
bbbbabbbbbbbabbabbaabbba
abbbaaaabbbbbbaaaabababbababbbbabbbabaaaabbaaaaaabbbabaa
babababbabbbaaaabbbaabbabbbbabaa
bbaabbabbbbbaababbbbaabbaaabbaababaabaaaaaaabbab
aabaaababbaaabbbbabbaaab
abbaaaabbaaababbbbbbabaa
abbaaabababbaabbbbaaabbabbbabbbb
aabbaaaaaaabbbbaababbbbbaaaabaababaabaaaaabaababbbbabbbb
abbaaabaabbabaaabbabbaba
ababbbaababbaaaaababaaab
bbbbbbaaaabbbbaabbaaaabaaababbbb
bbbaabbabbaaababbababbbb
baaababbbabbabbbbabababa
bbaaabaabaaabbbbabbaabba
aaabbbbaababbbabbaaaaabaaabbaabbaaababbbaabaaaaa
abbaaaababbbabbbaabababb
babaabaabbabaabbaaabaaaabaabbbabbbabbabbbbbbbbab
babaaaababbbabbbbbbaabaabaababababaabbaaabbabaabaaaabbbaabbabbababababbbabaabaab
bbbbababbaababaaaaabbbbaabaaabaabaaaababaabbabbaaabaabab
aaababaababbaabbbabaabaaaaabababbbabbbbaaaabbbabbabababaababbaab
baaaabaaaabbaaaabaabbabababbbbbabaaabbaaabbabbab
aaabbbbbabaaaaaaababbbbaabbaabba
ababaaababbbaaabbaaaaabbbabaaaababaabbbbbabaabaaaabbbaaa
babbbaababbbbaabbbbaaababaabaaaa
abbaaabbaaaaabbbbbbababbbbbbbabababbabaababbbaaaaabaaaabbaabbaab
abaabbbabaaabbbabbbabaabbbaabbaaabbbababbbbaabaa
bbbabbaaaababbaaaaababbb
ababaabbbbbbababaaaabbbabaaabbabbbababba
babaabbbbaabbbaababbabaaaaabaaab
abaaaabaaabbbbbaaaaabbabaabbbbabaababbabbbbbbbabababaabbbbabbbba
babaaaabbbbbabbaaabaaabaabbaababaabbabbaabababaa
abbbabbbbbabbaabaabaabaaabbaaaaababaaabbaaabaaababbaabbaaabbbaaaaabbbbbaabaabaaa
abbabbaaaaaabaaaaaaaaaaabbbababb
aababbbaabaaaababaaabbbbaabbbbbbaaabbbbb
abaaabaaaaababbaababbbbbbbaaaababbbbbbbbabbbbbaa
bbbbbbbbbaaaababaaababababaabbab
aaabaabababaabababaaaaabaabbbababbaabaaaaaaaaaaabbbaabaa
bbabbabbbbaaabaababaabaaabbbaaaabaabaaab
aaabababbabababbaaababbabbaaabbbaabbaaba
abababbaaabbbabaaaaabbbaabbabaaabbaabbaa
babababbbbaaaaaaaabbaaaaaababbbb
baababaabababaabaabbaaaabbabbaabbbaababbabaabbbb
aaaaabbbaababbabaaabbbabbbbbbbabbbbbaaaabaaabaababbbaaba
babaabababaabbbabbbabaaaabbbbbabaaabaaaabbabbaababaaaaabbbbaabbabbaabbba
bbbbabbababababbbbbaababbbaabaaaabaaabaaaaabaaaabbabbbabbaaaaaba
aababbbaaaabbbbbaaabbbabbaabbbbbbbabaaababaaabab
abbaaaaabbaaabbbaaaabbbaaaabbaabbbbaabaa
ababaababaaaababbbbababaaabaabab
aaabaabaabbbabaaabbababa
babababbbbbbabaaabaaabaabbaababb
baaabbbbbabbaaabbbabbbaa
abbbbbbaaaabaababaaaaaaa
baabbaabbbbbaaaaabaaabbb
babababbaaabbabababbababaaaabbbaaabbabbbbbaabaab
baaaabbbaababbbabbaaaaaabbaababb
bababbabbbaaabbbabaaaabaaaababbabababbaa
abbaaaababbaabaaabbabbaaabbbababababaaaaaaabaaababaaabbababbbabbaaaabaaaababbaba
bbbabababbaaabbbaaabbbbbaaabaabb
bbabaaabaabbaaabaabaabbaaabbbaab
bbaaaabbbabaabbbaaaaaaba
bbabbbbabbbbbbbbbbaaaaaabbbaaababaaaaaab
abbaabaabaabaaabababbabbbbaababaabbababa
aaabbbbbbababaabbbabaabbbababbabbaaaabababbaaabaababaaaa
babaabbbbbabbbaabbbbbbbaabbabaaabaabbaaaaabaaaaa
aababbabbabaabaaabbababa
aaaabbbaabbaaabababababa
bbbabababbabbbabaaabbaababbaaabaabbabbabbbbbbbbb
babaabaabaaababbbaabbaabbbbbbbbaabbbaaaaabaabbab
bbaabbbababbbbbaaabaabbabbbabbaaaaaaabbbbbbabbabaaabbbabbbaabaaaabbbbbba
ababbbbbaabaabbabaababbaabbbbbabaaaabaaa
abbbabbbabaaabbaabbaabbbaabbbbbababababa
bbabbabbbbabaabaabbbbbabaaaaabbbbabaaabb
bbbbbaaaababbbabbbbaaaaabbaaabbbbbaaabaaabaaababaaaaaaba
baaaaabbaababaaaababaababababbababbbaabaabbaabaa
bbaaaabbbabbbbbbbabbbaab
aabbbbaabbbbbababaabbbab
bbbaabbbabaabbabbabababbbabbbbaabaabbaab
aaabbabaaabaabbababaabbbabbabaaaabbaabba
abbbbbbaababbbbbbbabbbaabbbaaaaabbabbabaaabbbabaabababbbbaaaaaabbabbbabb
abbaaaabbbbaaaaaabaabaaabbabbabbbbaaabababbabaabaababaab
abbbaabbbbbbabbbaaaaabbaaaaababbabbaaaba
bbabaabbbbbbababaabaaababbbaabbb
aaaaabbbbaaababababbababbbbaaaabbaabbbab
bbbbbabbabaabbabaaaabbbb
bbbaaaaabbbbbbbbaaabbbabaababbabaaaaabbbbaabaabaaaabbaaabbababaaaaaaabba
aabaabbabbbbbbaababbaaba
bababbbaaabbbabaababbbbabbabbaaababbbaaababbaabababaabbbbabbbbba
ababbabbaabaaabaaabbaaabbbbbabbbbbbabaaa
baababaabaaaabbbabbbbabb
bbbbbbabaababaaaababaabbabbbaaba
babbabbaabaaaabbbaabaabbbbaabbba
aabaaabbbaaababaabaaaaaabaaabbabaabaaaaa
aababaaabbbaaaaaaaabbbbbaababababaaababbbabbaaab
bbabababbaaaabbababaabbaaabbaabbbabaaabb
babaabbbbaaabbaaabaabbab
baaaaabaaababbbbaaababbbbbabbaaa
baaababbbbbababaababababbbabaaabbababaaaabbbbabbbbbaaaba
abbbbbbbbbbbabbbabaabbbabaaababababbbaabaabbabbabbbabbba
bbbbbbaabaaaabbbabaaaabbbbbaaabbabbbbbaaaaaabbaa
baaaababaaaaaaabbabbabbaaabbabba
abbaaaabaabaabbbabbaaababaaababbbabbabbbbaabaaaa
aababaaabaaaaabbbbaababb
aaabababbabbbabaabaabbbababaabbb
babbababaaabbbbbabbaabaa
babbbbbbbbaaaaaabaabaababaabbbabaaaababb
aabaaabababaababbaaabbba
ababbbbbabbaababbaaaaaba
aaaabaabaabaabbbabbbabaaabbbabbbbaaaabbaaaabbaaababbaaabaabaaaab
babbbbbabbbbbbabaaababbabbaaaabaaaaaaaba
baaababbbbabbaabababababaabaabbaaaaababb
baaaabaabbabaabbaaaaaaba
bbbbbaaaabbabababbbabbabaabaaabbaaaaaabbbbbbbbaaaabbaaab
abababbababbaabbbbaabbbbbbabbaabaabbabbbababbbaababaaaaaaabbaaab
baaaabaaabbaaabaaaabaabb
baaaabaabaaaabaabbabaabbbaabbbba
aaababaaaaabbbabbabbabba
abbaaabaababbbabababaabababbababbabbabba
ababababbbaaabbbbbabaabbbaabaaab
bbbbbbbaaababbaabbbbbbbbabbabbba
aabbaabbbaaaaabaaabbaaababbaababbaabaabaababababaabbbbab
bbabbbaaabaaabaaaababaababaaabbb
bbaababaaaaaababaaaaaaaabaaabaaabbbbaaababbaabbbbbbaababbabbabaabbabaaabbababbababbaabbb
aababbbababbbbbaaabbaaabbbbbabaa
aaaaababbabbaababbabaababbbbaabbaaabaabbababaaba
abbbaabbbbaabbabbbabbbbbbabbaaaa
baaaababbabbbbabbbabaabbbbabaaba
baaaabbbbbbaaaaaaababbbababbbbbaaaabbbbbabaababa
bbaaaaaaabaaabbaababbabbabaababa
aababbbabbbaaaaabbbaababaaababbabbbbabbabaaaabba
aababaaabbbbbaaaabbaaaaaaaaaabab
abbaaabaabbbabbaababaabbbaababbabababaaa
baababbabbabbabaaaababbaaabaaabbaabbabba
aababbabbababbabbbaabaaabaaabbabaabaaaab
aaabaaaaababbbaabbbaaaaabbaaaaaaabbaabbaaaabaaaaaababbbababaaaababaaaaabbbbaaaba
abaaaabababaaaabbbbbbbbbbbbabbbb
bbbabbaaababbabbaababbbabbbaababbbbbbbabbbbbbabbbaaaaaab
abaabbaaaaabaababaaababaaabbbbba
babbbbaaabbaaaaabbbaaababbaababa
ababbabbbbbbabbaaaaabbbabbabaabbbbbbaabbbaaaaaaaaaaaabaa
aababbbababbabaaaabbbabbbabbbbabbbbbabbbaaaababaaabbabbbababaaabababaaab
bbabaaaabbbabbbbbbbbbabbabbbbbaabbabbbab
ababbbabbaababbabaabbbaabaaaabba
abbabaababbbabbbabababbabababbbb
bbabbbbaaaaaabbbabbbaabbaaaabaababaababb
babbbaabaaaabaaaaaababaaaabaabbabababbaabbbbbbbabbababbabbaabbbabaabbbaa
aaabbbaaabbababbaabbabab
bbabaabbbaaabbbbbaaaaaba
babababbaabbbbaabbbbbbaaaaaaaaaabbaabaabbbbbaaba
bbabaababaaaabbbabbabbab
aababbaabbbbabbaabbabbaabbbaaaaabbaabaaaaabbabbb
ababbbabbabaababababbaab
aabbbbaabbbbbababaaabababbabbaabbbababbaababbaba
abbbaabbaabbbbaaabbbbbbabbabaaabbbaababb
baaaabababbbaaaaaaabbbbaabbaaabbbbaabbaa
bbaaaabaaabbaaababbabbba
bbbaaabbbaabaabbabaaaaabbaabbababaababbbbbaaaabababaabaabbaababa
baabbababaabbbbbbabbabba
baaaaabbabbbabbbababbaab
aaabbbababbaaaabababbbaaabaababa
abbaabaabbbaaabbabaababa
abbbbbbbbabababbbababbaa
abbaaabaabbaababbbbabaab
baababbabaabababbbbbbbabbbbaaaabaaabbbbb
aabbbababbaabbbbaaaabaabbbbaaaaabaaabababaaabbbbaabbabbbbbbabaabaaaaababaaaabbbb
aaaabbbaabbaaabaaabaabbbaaabababbbbaaaba
baaaaabbbbbbbbbbaababbbabbbababaaaabbaab
abaaaaaababbbabaabbbbaaa
aabbaaaabbbbabbbaaaaabab
aaabbaabbaabbbbaaabbbaaaabbbabbabbbbaaba
babbbbbbbbaaaaaabaabbbab
aaabaabbbbbbbbbbaaabababbaaaababbbbabaaaaabbabbbbbabbabbaaaabbaabaabababaabbbabbabaabbbb
aaabbbbabbabbabbababbaba
aaabbbbbaaababababaaabbababababa
aababbaabbbbbabaaaabbbaaaababbbaabbaaabb
babaabbbbaaabababbabbbababaabbab
baabbbaabbaabbbbaaaaaabb
aaaaabbbbabbbbbaaaabababaaaabbbbabbababa
bbbaaaaaababbbaabbababaa
aabbbbabbbabbbaabababbbbbbaabbbbababaababababbaaabbbbbbaababaaababaabbaaaabaaaba
abbaabbbabbabababaabbabb
bbaaababababbabbbababbbb
baabbbaababbabababaabbbaabaaabab
babbbbaababbbbaaabbabbbababaaaaabbaababa
bbbababaabbbbbababbbaaab
ababbbbabbabbbaaababbaab
bbbbaaaaabbbbaaaabbabbbbababbaba
aabbbbaabbaaaabbababaabbbaabbaabbaaaabbbabbbaaba
bbbabbaabbbbbbaababbababaaaabbbababaabaabaaabbba
baabbaababaabbaaaabbabab
babbbbaaabbababbbbaabbbbbbababbbbabaaabb
baabbbaaabbababbbabbbaab
abaaaababbabbaababaaaabb
bbbaabababaabbaaaaabbbaabaaabbbbbabbbbabbababaaa
bbbbbbbaaababbaabaaabbab
ababaabbaabbbabaababbaaabbbabababaaaabba
aaababbabaabbbbbbaaababaaaababbaabbbbbbbaaababbb
babaababbabaabaaabbbabbbbbbaaaaabaababab
ababbaaaaaaabaabaaaabbabbbbbaaaaaaaababaaaaabbab
bbbbabbbbaabbabababbbbabaabbbbbbaabababaaabbabaaaabbbbabbabaabbaaaaababbbbaababa
aaaabbbaaababaabaaaaabaa
bbbaababaabaabbaaababbabaaaabbbaaabaaaabaaaabbbb
abbabbaaabbaaababbbabbaabbaaabbabaaaaaab
ababaabaabbbbbbabaaaaaba
babbaabbbbbbaaaaabbaaabababbabaabbbbbabb
aababaaaaabaabbaaabbaaaababaaaabbbaabaab
bababaabaabaaabaabbbaabbaabaaaaa
babbabbbabbabaaaaaaabbbabaaababbbaaaaaaa
bbabbabbaaababaabbbbbabb
abaabbaaaababaabbbbaaaaabbabaabababbabaabbbbaabaaabbbaabababbaab
baaabbaaabbbaabbbbbbaababbbaaabbaabbaaabbaaaaabaaaabaaaabbbabbabaaabbbbabbbbaabaababbbabbbbbabaa
baaaabbbaabbbbbbbbaaabbbbaaaabbbbbaaaaab
babbabababbaaabaabbabaabaabaaabababbaabbbbbabaab
bbaaaaaaaabbbabaabbabaaabaaababaabaabbbb
bbbbabbbbbabbababbbbbbbbaababbbaabababababbababa
aaaaabbbbaaaabaababbbabababaaaabbbbbaaabaaabaabb
bbaabaaaaabbbbbbbbbbbaaaabaabbab
bbababaaaabaaabbaabbbabbbbbabbaaababbabbababaabbabbbababbabbabbabbbbaaab
bbbbbababbbbbaaaaaabababbaaabbaaaabbaabb
abbbaaaaababbbbbbbabbabbaaabbbaaaaabbabababaaaabbbababbb
abaaabaaaabbbabaabbbabab
bbaaaabbaaabbbabaaabababaaabbabbaabbabbaabaabbbbbbbbbabbbaabaabb
aabbaabababaaabbabaabaaaabbabaaaaaaabbbbaaaaaaab
bbaaababababbaaaababbbaababbbabb
babaabaabbbbbaaabbbaabaa
baaaabbbababbbbabaabbaabaababaaabaababbaabbbbbaa
aabbbabababbbbaaaaababaa
bbaabaaabbbbbaaabbabbaabbabbbbbbbabaaaba
baaaababababbbbaababbaaabaaaabbbbbaaabba
bbaabbbbbabbaabbabbbabbbbbabaabbbbbbbbbabaababbb
ababbabbbbaabbbaabbbbbbaabbbabababbbbbaabbbaabaabbababbb
bbaabaaabaabbababbbbaaba
baaaaabbaabbbabbbabbabab
aaabbbaabbabbbbaabbbabaaaaabbaab
abababbababbaabbaabbabaaabababaa
bbabbabaaababaaaabbabaabbbbbbbbbaaabaabaabbbbbbabbbbbabbabbbbaaa
baaaaabbaaaabbbabbbbbbabaabaabbabababaaabababbbb
bababbabababbbbaabbbabab
aabbaaaaaaabaaabbbaaaaab
bbbbbbaaabbbabbbaabaabbaabaabababbabbbbbabbabbababaabaaaaabbabbb
babaaaabbaababbababbbbbaaaaaaaababaabaab
abbbbbabbbabbbbaaabaaaaa
ababababaaabaababbaaabba
baababaabaaabababbaaababbbbbbabbbabaaabb
bbbbbbbbaabaaababbbbababaaaabaabbbbbabaa
abaabbaaabababababbabaaabbaaabaaabaaaaaa
abbaaababbaabaaabbbaabbabbbbaaab
bbabaabbaabaaabbbaaaabababbaaaabaabbbbaaaabbbbbabbaabbab
abaaaaabbbaaaabaaaaababa
ababbabbabaaaababaaabbaabaaabbab
bbabbbbabbabaabbbbabbabbaabababaabababbb
aaabbbaaabaaaaabbaaababaabbababbabbabbbababbaaabbabaaaaa
bbaaabbbaaabaabbbaabbbba
abbaabababaaaabababbbbababaaaaabbbbbabbabbbabbbabaabaaaa
bbbababaaababaaaaabaaaaa
ababbbabbbbaababbbaaaaaaabbbbbbabbbaaabaaababbbb
aababbabbbbababaabaabbbbbbaabbaabababbababaababaaabbaaaaababbbab
baabaabaaabbaababbbbaaba
bbabbbbbbabaaabbabaabaabbbabaaabbaaabaaa
abaaaabbabbabaabbbaaaabaaaaabbaabbbbababababbabb
ababbbababaaaaabaabbabaaaaabaababaabaababbababbaaabbaabaabbaabbaaaaabbab
abbabaabbababbabaaaabbab
aabbbabaabbbaaaabbabaabbbabbaaaaabababbb
babbbbbbaabbaaaaaabbbabbbbbabaabbbbabbab
aabababaaabbaaabaaaababa
aabababababbbabaaababbababaabbbaaaabaaaababbaaab
abbababbbbaabbbbabbaabba
baaabbaaaabbaaababbaaaabbbaabbba
bbbaababaabababbbbababba
baaababbabbaaaaababaaabb
abaabbaabaabbababaaaababbabaababababbaab
bababaabbbaabbbbbababbba
abbaababbababaabbbbabababbbaababbbbaaabbbbababaaabbababa
abbbabbbbbaaaaababbbbaababbababa
abbbbabaaabbbbabbaabbbab
ababbbaabbbabbbbababbaabbbbaaaab
aaabaaabbbabbbabbbbbbbabaabbbbbbbbbaaabababaabba
abbbbbabbabaabbbababaababaabaabaaabbbbaaaaaaaaabaaabbaab
baaaabbbabbabaaaaaaaabbbabbaaaababababaa
aababababaabaabaabaaaaaaaabababb
baaaabaaaabbaaaabbbbaaaaabbaabba
bbbbbbbabbbbabbbabbbbaab
aabbbabbaabbabaaaaaaabbbababbbbabbabbaabbaabababbbaabbbabbbaaaba
aababbaabbbbbbaaaababbbb
bababaabaabaaabbbbaabaaabbabbabbaabbbaab
bbabbabbabbaaaaabbaaaabbbabaaaaa
bbbbbabaabbabbaabbabbabbbbaaabbbbbaaaabbbbbaabbbaabaababbbbaabbb
aaabababababbbbabbbaabbabbabbbab
aaaaababaaababbbaabaaaabaaaabbaabbbaaaab
baabbbaabbaabaaabbabaaabaaababaabaaababbabbbabaabbaabbaaaaaabbaa
abbabbaaaaabbbbaabbbbbabbabbaaab
baaaababaababbabbbbbabbabaababaaabbaaaabbbabaaaaaabbabba
aababbabaaaabbbaaabaaababbabaaabbabbaaaababaaababbababaabaabbbba
bbaaabababbbabbabbabbabbbaabbababbaabaab
babaabababbbbbbaabbababbabbbaaab
aabababaababbbbbabbaaabaabbbbaba
baaabbbbbbaaabababbbaaaaababbbaabbbbaabbaaaaabaa
bbbbabbbbabbaabbabaabbab
abaabbbabaabbaabbaaaabbaaabbaaaababaaabbabbabbabbbabbbbbabbaaabaaaaabaab
abbbbbbbabbabbaaaabaaababbbbbaaabbaaaaababbbbbaaaabbabbb
aaaabbbaabbbabbaabbabbaabaabbaaa
bbaaaaaaabaabbaaaaaaaaababaaaabbaaabaaaa
baababbaabbaabbbababbaaabababbaa
aabbababaabbababbabbabbbabbbabbaababbabbaaabbabbabaaaabaaabbbbaababbbbbb
bbbbbaaaaababaababaabbbaaabaababaaabaaaa
aaabaabaaabaaabaabaabbbabbbaaaab
babaabbabbbbbbabbbbbbbbbbaaaaaaa
aabaaabbbabbbbaabaaababbbbabbbbb
baababaabaaaaabbabbbabbbbbababaaababbaba
bbaaaabbbbaaabaababaabaaaaabaabb
babbaabbababbaaaabbbbbbbaaaabbbabbbaabbabaaaabbababaaaaa
aaaaaaabbabaababababbbabbbabbaabbbabbbabbaaabaaa
abbaaaaabbbbbaaaabaabbaabababaaabbababbb
aababbaababbbbabbaaaaaba
babbbbabababbaaabbaabbbb
bbbbabbbbbabaabbbababbababaaabbb
bababbabaaaaabbbaabbbaba
abaaabaababbabbbaaaaabbbbbbbbaab
aababbbaaaababbaabbaabbbbbbbbbbbaaaaaabbbbbaaabb
babaababaabbaaabbabababbaaabbbabbbababbbabbaaabb
babaabababbabaaaababbaaababbbbaabbababbbbbbaaaba
babbabbbabaaabaabbbbabaa
aaabbbbaaababababbbbbabaaabbaabbbbbababbabbaaabb
aabaaabaaabbaaaabababaab
bbababbbaaabaaaaabbaaaaaabbbabaaabbbbabbaababaabbbabaabaabbabbaaabbaabab
babbabaaaababbabbabaaaabaaaaabbbaaabbbababbabbaababbbaaabbbababb
aabbbabbaabaabbbabbaaabb
bbbbaaabbabaaabaabbaaabbbbbabaabaabbabbb
aabbaaabbaaabbaabababaaa
abbbaabbbbbbaaaabababbabbbabaabbabbaaaaaaabaaaab
aaaabbbaaaabbbbabaaabbbbaaabbbbbabbaaabababababbbabaaaaabaabaabbbbbaaaabaaaaaabbbbbabaaa
bbbbabbbbbaabaaabbbaaaaaaababaabaaabbaaa
bbbbabbaaaabbbabaabbaaaaaababaaabaabbbaaabaaababbababbbabbababba
bbabbabaabaaaaaabbaababa
bbbaabababbabaabbaaaaaab
bbaaabbbbbbaaabbaaabaaabbbbaaabababbaabbaabbbabbabbabbba
abaabbaaabbbbbbaaaababbaaabaaabaaabbabbbabababbbabababaa
aaabababaabbbbaaabababbb
babaabbbaababbbabbaabbab
aaaaaabaabbabbabaaabbabbaaabaabb
aaaaaaababbbaabbbbabaabaaaabbaaaabaabbab
babbbbbbababaabbaaaaabba
ababbaaaaaaaabbbaabbbababbbaaabaaabbbbba
bbbbbbaaabbbaabbbaabbbaaaababaaabaabaabbbbababaaaabbbaaa
aaaaabaaaaabaabaaababbaaabaaababbbaababaaaabbbababbbaaabaaaaabbbbabbababbbbbbabb
bababaabababbbaaaabaaabaabaaaabbbabaaaaa
bababaabbbabaabbbabbbbaaaaaabbab
aabbbbaaabbbbbbaabaabbbb
aaabaababbbaaaaabbaabbab
abbbbbbabbbaababaaaabbbb
ababaabbbbabbbaababababa
bbabbabbaaabbbbabaaaabaababaabaabbbbabaa
abaaaabbaaabbaaaabbbaabaaabbaaaaababaaabaababaabbaabaaaabababbba
bbaaaabbbaababaaababbbbaaabbaaba
baaaababbaaabbaaabbaaaabaaabbbaabbaaabbbaaaabbab
babbbbbababbaaaaaabaaababaaaaabbabababbaabbbbbabbbaaaaababbaaabb
babbbbbabbbbbbababbaaaaaaabbabbb
babbbabaaaabaaabbbbabbba
abaaabbbbbbaaababaaabbabbaaabbba
baababbaaaaaabbbbbaabbbbababaaabaabbabab
bbaababbbaabaabbaaaababbaaabbaaabbbbbabbbabbbbabaabaabaabbbbaaaaaaaabbbababbaaaaabbaaaab
baaaaabbbbabbabababbbababababbbbaaaabbbb
bbaaababaabbabaababbaaaaaaababaaaaabbabaabbaabbb
bababaababaaaaabaaabbbbbabaabaab
aaabaaabbaaababaabbbabbbabbbaabbababbaab
bbabaababaaaabaaaaaaabab
bbabbabaaabbbabaabbbaaab
babaaaabbabbbabaaaaabaabbbbbbbbaabaaaababaaaaaab
bbaaaabbaaabbabaababaaab
bbbbbababbabaaababaababa
abbbabaabbaaaaaaabaaaaabbabbaaaaabbabbaabbaabaabaaabaabbaabababb
bbabbbbabbbbabbbbbabbabbbaaaababbbaaaaaaaabbaaabaaabbaaa
babbabbbaabaaaaabaaaabbaabbbbbbabbbbaababbbbabaaaabbbbaa
abaaaababaabbabaabaaaabbaaaaaaabbbaaabababababbbabbabbabababbaba
abaabbabbbaaaaaaabbbaaaababbbbbbbbaaaaaa
babbabababbbabbbabaaaaaaabaabaaa
bbabaaababbbbabbbbbabbabaababbbaaaaabbaaaabbabaabbabbbbbbbaaabbababaaaaa
ababaabbbaabbaabbbbbbbbbbbbabbababbbaaab
bbaaaababaaabababaaaaaaa
baabbbbbbbaabbbbbaabbabaaaabbbbabaabbabb
ababbbbbaaaaaaabaaaabbbb
baababaababbabaabaabbbba
aabbbbbbaabaaabbbbbbbbbabababaabbbbaabbbaababbbbbbaababb
bbbbabbaabaaaaaaababbbbabaabbababbaabbabbabaaaaabbaabbab
bbabbabababbaabaabbbbabbaaaabbbbabbbbabb
bbbaababababaababbaaabba
aabbbabaabaabbbaaaabaababbbabbab
abbababbbbabbbbaababababbbbaabbbbaaabbba
aababbaabbaaaabaaaabaaabbbbbabaa
bbaaaababbbbbbbbbbbbbbabaaabaabb
baaaabaababababbbabaabaaabbaaaaabbabbaaa
babaabbbbabaaaabaabaaabbbaabaababbbababb"; 
        private const string test = @"0: 4 1 5
1: 2 3 | 3 2
2: 4 4 | 5 5
3: 4 5 | 5 4
4: ""a""
5: ""b""

ababbb
bababa
abbbab
aaabbb
aaaabbb"; 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            exo2();
        }

        private static void exo1()
        {
            var lines = input.Split(Environment.NewLine);

            var characterMatch = new Dictionary<int, char>();
            var combiMatch = new Dictionary<int, int[][]>();

            int i = 0;
            while (i < lines.Length && lines[i].Length != 0)
            {
                var p = lines[i].Split(':', StringSplitOptions.RemoveEmptyEntries);
                int ruleId = Int32.Parse(p[0].Trim());
                if (p[1].Contains("\""))
                {
                    characterMatch[ruleId] = p[1].Trim()[1];
                }
                else
                {
                    List<int[]> combiRules = new List<int[]>();
                    var orRules = p[1].Split('|');
                    foreach (var orRule in orRules) {
                        combiRules.Add(orRule.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse)
                            .ToArray());
                    }

                    combiMatch[ruleId] = combiRules.ToArray();
                }
                i++;
            }

            i++;
            var messages = new List<string>();
            while (i < lines.Length)
            {
                messages.Add(lines[i++]);
            }

            bool Match(int ruleId, string val, ref int pointer)
            {
                if (characterMatch.TryGetValue(ruleId, out var c)) {
                    return val[pointer++] == c;
                }

                int cachePointer = pointer;
                foreach (var andRule in combiMatch[ruleId])
                {
                    pointer = cachePointer;
                    bool matchCombi = true;
                    foreach (var subRule in andRule)
                    {
                        if (!Match(subRule, val, ref pointer)) {
                            matchCombi = false;
                            break;
                        }
                    }

                    if (matchCombi) {
                        return true;
                    }
                }

                return false;
            }

            int nbValid = 0;
            foreach (var message in messages)
            {
                int p = 0;
                if (Match(0, message, ref p) && p >= message.Length)
                {
                    nbValid++;
                }
            }
            
            Console.WriteLine(nbValid);


        }
          private const string input2 = @"7: 128 83 | 90 111
67: 128 128
73: 83 128
38: 90 55 | 128 126
69: 90 49 | 128 7
82: 122 128 | 111 90
55: 90 128 | 128 128
44: 51 90 | 123 128
25: 128 10 | 90 135
109: 128 16 | 90 68
129: 97 132
21: 97 128 | 111 90
71: 128 95 | 90 110
43: 128 104 | 90 134
120: 90 97 | 128 67
59: 77 90 | 95 128
50: 95 90
127: 90 106 | 128 61
35: 90 104 | 128 45
83: 128 90
10: 62 90 | 63 128
1: 90 112 | 128 103
57: 99 90 | 40 128
40: 128 2 | 90 93
2: 83 128 | 83 90
91: 128 96 | 90 64
45: 128 90 | 90 90
110: 90 90
123: 128 87 | 90 79
104: 128 132 | 90 90
121: 95 128 | 111 90
111: 90 128 | 90 90
124: 128 108 | 90 54
88: 55 128 | 26 90
125: 128 126 | 90 83
58: 90 78 | 128 14
118: 55 90 | 134 128
48: 116 90 | 86 128
130: 23 90 | 97 128
61: 90 43 | 128 56
78: 90 47 | 128 37
128: ""b""
99: 128 114 | 90 7
87: 128 111 | 90 23
84: 128 62 | 90 101
135: 34 90 | 30 128
41: 90 121 | 128 100
63: 45 90 | 122 128
115: 118 90 | 94 128
37: 97 90 | 55 128
23: 132 132
65: 128 45
98: 128 1 | 90 70
36: 90 69 | 128 19
122: 90 128
32: 128 50 | 90 85
114: 23 128 | 67 90
17: 128 83 | 90 55
103: 128 102 | 90 22
79: 128 67 | 90 134
94: 90 111 | 128 97
30: 128 122 | 90 77
89: 132 55
100: 122 128 | 126 90
11: 42 31
18: 21 90 | 7 128
86: 117 128 | 17 90
33: 95 90 | 111 128
6: 65 90 | 100 128
102: 35 90 | 49 128
14: 39 90 | 53 128
66: 83 90 | 67 128
105: 104 128 | 126 90
47: 90 26 | 128 122
16: 90 44 | 128 25
72: 97 128 | 55 90
53: 55 128 | 122 90
112: 128 6 | 90 124
75: 128 82 | 90 94
70: 90 24 | 128 52
31: 98 128 | 109 90
126: 90 90 | 128 128
49: 23 90 | 111 128
28: 90 130 | 128 129
54: 90 110 | 128 45
97: 128 90 | 90 128
80: 127 128 | 119 90
107: 128 133 | 90 92
27: 90 117 | 128 88
60: 90 23 | 128 134
0: 8 11
39: 23 90 | 55 128
13: 134 90 | 67 128
52: 115 90 | 41 128
77: 128 90 | 132 128
117: 128 67 | 90 83
90: ""a""
76: 134 132
26: 128 90 | 128 128
4: 58 128 | 9 90
20: 128 111 | 90 77
42: 46 128 | 15 90
116: 89 128 | 131 90
9: 18 90 | 84 128
5: 90 134 | 128 77
113: 128 76 | 90 20
95: 90 128 | 132 90
92: 113 128 | 32 90
12: 128 72 | 90 66
8: 42
74: 128 111 | 90 122
15: 3 90 | 107 128
24: 28 128 | 81 90
34: 90 67 | 128 95
3: 48 90 | 91 128
131: 132 26
51: 73 128 | 60 90
93: 126 90 | 67 128
108: 134 90 | 95 128
68: 57 128 | 36 90
133: 29 90 | 27 128
64: 38 90 | 59 128
56: 126 132
62: 128 122 | 90 97
85: 128 134 | 90 26
96: 33 90 | 5 128
132: 90 | 128
29: 5 128 | 74 90
81: 128 105 | 90 17
119: 90 12 | 128 75
101: 134 90
22: 128 131 | 90 71
134: 90 90 | 132 128
46: 4 90 | 80 128
106: 13 90 | 89 128
19: 125 128 | 120 90

bbbbababababbbaabbabbabbaabaabaaaabaabaabbabbbbbaabbbaaaaabbaabbaaaaaabb
baabbbbbbbabbbaaaaababbaaabbabbbaababbbb
abbbabaabaaabbaabababbaa
babbabaaababbbababbbabaabbbbbaaaabbbaaba
baabaababbbabababbbbaaaaabababbb
aabaaabbabaaaaaabaaabbaaabbaaababaaaabbaabaababaaaaabbab
abbbaabbbaababbaabbabbab
abbaababbbbbabbabaabaaaa
aaabaaabaabaabbbbbbbaaba
baaababbbabbbababaaabbbbaaabaaabaabbbbba
bbaabaaabaabaabaabbbbaaabbbbbaaaabbbaabbbabbaabbaabaabaabaaaabbb
babbabbbbabbbabaabbbbaaa
bbbaababaabaabbbaabaaabbaaabaabb
aabbbabbbabaaaababbbbbabaaaaabba
bbbbbbabaaaabbbababaaabb
aaababababababbaabbabbaaaaaabaabbabbbbbbabaaaaaabbbbbaabaabbaabb
aabbabaaaaababbaaabaabaa
aababaaaaabbaabaabbbbababaabaaabaabbbababbbbbaaabaaababbaaababba
aabbaaaaabbaabbbabbabaaababbabaaabaabbab
baaababababaabbbabbbbbbbabbabbbbbabababa
aababbababbbabaaaababababababaaa
aaaabbbabbaaaabababaaaabbaabaaab
ababbabbabaaaaaaabbababa
babbbbabababbabbbbabaabbbbbabbabbbbabbbb
bbbbabbbaaabbbaaababbbbabbabaabababaaaababbbabbabababbbbbaababbb
ababbbaababababbababbaba
baaababbababbbabaabaaabbaaabaabaaaaaaaaa
baaabbbaabbbbbbbaabbbbabaaaabbaaabbbbbbaaaaaabbbaababaaa
aaaaaaabbaaaabaabbbabbab
bbaaabbbbbaababaababaaba
abbbbbbabbabaabbaaaaabaabbbaabbbaaaabbbabababbaabaabbaabaaababba
bbbbaaaabbbbababaabababb
bbbbabbbbbbbabbabbaabbba
abbbaaaabbbbbbaaaabababbababbbbabbbabaaaabbaaaaaabbbabaa
babababbabbbaaaabbbaabbabbbbabaa
bbaabbabbbbbaababbbbaabbaaabbaababaabaaaaaaabbab
aabaaababbaaabbbbabbaaab
abbaaaabbaaababbbbbbabaa
abbaaabababbaabbbbaaabbabbbabbbb
aabbaaaaaaabbbbaababbbbbaaaabaababaabaaaaabaababbbbabbbb
abbaaabaabbabaaabbabbaba
ababbbaababbaaaaababaaab
bbbbbbaaaabbbbaabbaaaabaaababbbb
bbbaabbabbaaababbababbbb
baaababbbabbabbbbabababa
bbaaabaabaaabbbbabbaabba
aaabbbbaababbbabbaaaaabaaabbaabbaaababbbaabaaaaa
abbaaaababbbabbbaabababb
babaabaabbabaabbaaabaaaabaabbbabbbabbabbbbbbbbab
babaaaababbbabbbbbbaabaabaababababaabbaaabbabaabaaaabbbaabbabbababababbbabaabaab
bbbbababbaababaaaaabbbbaabaaabaabaaaababaabbabbaaabaabab
aaababaababbaabbbabaabaaaaabababbbabbbbaaaabbbabbabababaababbaab
baaaabaaaabbaaaabaabbabababbbbbabaaabbaaabbabbab
aaabbbbbabaaaaaaababbbbaabbaabba
ababaaababbbaaabbaaaaabbbabaaaababaabbbbbabaabaaaabbbaaa
babbbaababbbbaabbbbaaababaabaaaa
abbaaabbaaaaabbbbbbababbbbbbbabababbabaababbbaaaaabaaaabbaabbaab
abaabbbabaaabbbabbbabaabbbaabbaaabbbababbbbaabaa
bbbabbaaaababbaaaaababbb
ababaabbbbbbababaaaabbbabaaabbabbbababba
babaabbbbaabbbaababbabaaaaabaaab
abaaaabaaabbbbbaaaaabbabaabbbbabaababbabbbbbbbabababaabbbbabbbba
babaaaabbbbbabbaaabaaabaabbaababaabbabbaabababaa
abbbabbbbbabbaabaabaabaaabbaaaaababaaabbaaabaaababbaabbaaabbbaaaaabbbbbaabaabaaa
abbabbaaaaaabaaaaaaaaaaabbbababb
aababbbaabaaaababaaabbbbaabbbbbbaaabbbbb
abaaabaaaaababbaababbbbbbbaaaababbbbbbbbabbbbbaa
bbbbbbbbbaaaababaaababababaabbab
aaabaabababaabababaaaaabaabbbababbaabaaaaaaaaaaabbbaabaa
bbabbabbbbaaabaababaabaaabbbaaaabaabaaab
aaabababbabababbaaababbabbaaabbbaabbaaba
abababbaaabbbabaaaaabbbaabbabaaabbaabbaa
babababbbbaaaaaaaabbaaaaaababbbb
baababaabababaabaabbaaaabbabbaabbbaababbabaabbbb
aaaaabbbaababbabaaabbbabbbbbbbabbbbbaaaabaaabaababbbaaba
babaabababaabbbabbbabaaaabbbbbabaaabaaaabbabbaababaaaaabbbbaabbabbaabbba
bbbbabbababababbbbbaababbbaabaaaabaaabaaaaabaaaabbabbbabbaaaaaba
aababbbaaaabbbbbaaabbbabbaabbbbbbbabaaababaaabab
abbaaaaabbaaabbbaaaabbbaaaabbaabbbbaabaa
ababaababaaaababbbbababaaabaabab
aaabaabaabbbabaaabbababa
babababbbbbbabaaabaaabaabbaababb
baaabbbbbabbaaabbbabbbaa
abbbbbbaaaabaababaaaaaaa
baabbaabbbbbaaaaabaaabbb
babababbaaabbabababbababaaaabbbaaabbabbbbbaabaab
baaaabbbaababbbabbaaaaaabbaababb
bababbabbbaaabbbabaaaabaaaababbabababbaa
abbaaaababbaabaaabbabbaaabbbababababaaaaaaabaaababaaabbababbbabbaaaabaaaababbaba
bbbabababbaaabbbaaabbbbbaaabaabb
bbabaaabaabbaaabaabaabbaaabbbaab
bbaaaabbbabaabbbaaaaaaba
bbabbbbabbbbbbbbbbaaaaaabbbaaababaaaaaab
abbaabaabaabaaabababbabbbbaababaabbababa
aaabbbbbbababaabbbabaabbbababbabbaaaabababbaaabaababaaaa
babaabbbbbabbbaabbbbbbbaabbabaaabaabbaaaaabaaaaa
aababbabbabaabaaabbababa
aaaabbbaabbaaabababababa
bbbabababbabbbabaaabbaababbaaabaabbabbabbbbbbbbb
babaabaabaaababbbaabbaabbbbbbbbaabbbaaaaabaabbab
bbaabbbababbbbbaaabaabbabbbabbaaaaaaabbbbbbabbabaaabbbabbbaabaaaabbbbbba
ababbbbbaabaabbabaababbaabbbbbabaaaabaaa
abbbabbbabaaabbaabbaabbbaabbbbbababababa
bbabbabbbbabaabaabbbbbabaaaaabbbbabaaabb
bbbbbaaaababbbabbbbaaaaabbaaabbbbbaaabaaabaaababaaaaaaba
baaaaabbaababaaaababaababababbababbbaabaabbaabaa
bbaaaabbbabbbbbbbabbbaab
aabbbbaabbbbbababaabbbab
bbbaabbbabaabbabbabababbbabbbbaabaabbaab
aaabbabaaabaabbababaabbbabbabaaaabbaabba
abbbbbbaababbbbbbbabbbaabbbaaaaabbabbabaaabbbabaabababbbbaaaaaabbabbbabb
abbaaaabbbbaaaaaabaabaaabbabbabbbbaaabababbabaabaababaab
abbbaabbbbbbabbbaaaaabbaaaaababbabbaaaba
bbabaabbbbbbababaabaaababbbaabbb
aaaaabbbbaaababababbababbbbaaaabbaabbbab
bbbbbabbabaabbabaaaabbbb
bbbaaaaabbbbbbbbaaabbbabaababbabaaaaabbbbaabaabaaaabbaaabbababaaaaaaabba
aabaabbabbbbbbaababbaaba
bababbbaaabbbabaababbbbabbabbaaababbbaaababbaabababaabbbbabbbbba
ababbabbaabaaabaaabbaaabbbbbabbbbbbabaaa
baababaabaaaabbbabbbbabb
bbbbbbabaababaaaababaabbabbbaaba
babbabbaabaaaabbbaabaabbbbaabbba
aabaaabbbaaababaabaaaaaabaaabbabaabaaaaa
aababaaabbbaaaaaaaabbbbbaababababaaababbbabbaaab
bbabababbaaaabbababaabbaaabbaabbbabaaabb
babaabbbbaaabbaaabaabbab
baaaaabaaababbbbaaababbbbbabbaaa
baaababbbbbababaababababbbabaaabbababaaaabbbbabbbbbaaaba
abbbbbbbbbbbabbbabaabbbabaaababababbbaabaabbabbabbbabbba
bbbbbbaabaaaabbbabaaaabbbbbaaabbabbbbbaaaaaabbaa
baaaababaaaaaaabbabbabbaaabbabba
abbaaaabaabaabbbabbaaababaaababbbabbabbbbaabaaaa
aababaaabaaaaabbbbaababb
aaabababbabbbabaabaabbbababaabbb
babbababaaabbbbbabbaabaa
babbbbbbbbaaaaaabaabaababaabbbabaaaababb
aabaaabababaababbaaabbba
ababbbbbabbaababbaaaaaba
aaaabaabaabaabbbabbbabaaabbbabbbbaaaabbaaaabbaaababbaaabaabaaaab
babbbbbabbbbbbabaaababbabbaaaabaaaaaaaba
baaababbbbabbaabababababaabaabbaaaaababb
baaaabaabbabaabbaaaaaaba
bbbbbaaaabbabababbbabbabaabaaabbaaaaaabbbbbbbbaaaabbaaab
abababbababbaabbbbaabbbbbbabbaabaabbabbbababbbaababaaaaaaabbaaab
baaaabaaabbaaabaaaabaabb
baaaabaabaaaabaabbabaabbbaabbbba
aaababaaaaabbbabbabbabba
abbaaabaababbbabababaabababbababbabbabba
ababababbbaaabbbbbabaabbbaabaaab
bbbbbbbaaababbaabbbbbbbbabbabbba
aabbaabbbaaaaabaaabbaaababbaababbaabaabaababababaabbbbab
bbabbbaaabaaabaaaababaababaaabbb
bbaababaaaaaababaaaaaaaabaaabaaabbbbaaababbaabbbbbbaababbabbabaabbabaaabbababbababbaabbb
aababbbababbbbbaaabbaaabbbbbabaa
aaaaababbabbaababbabaababbbbaabbaaabaabbababaaba
abbbaabbbbaabbabbbabbbbbbabbaaaa
baaaababbabbbbabbbabaabbbbabaaba
baaaabbbbbbaaaaaaababbbababbbbbaaaabbbbbabaababa
bbaaaaaaabaaabbaababbabbabaababa
aababbbabbbaaaaabbbaababaaababbabbbbabbabaaaabba
aababaaabbbbbaaaabbaaaaaaaaaabab
abbaaabaabbbabbaababaabbbaababbabababaaa
baababbabbabbabaaaababbaaabaaabbaabbabba
aababbabbababbabbbaabaaabaaabbabaabaaaab
aaabaaaaababbbaabbbaaaaabbaaaaaaabbaabbaaaabaaaaaababbbababaaaababaaaaabbbbaaaba
abaaaabababaaaabbbbbbbbbbbbabbbb
bbbabbaaababbabbaababbbabbbaababbbbbbbabbbbbbabbbaaaaaab
abaabbaaaaabaababaaababaaabbbbba
babbbbaaabbaaaaabbbaaababbaababa
ababbabbbbbbabbaaaaabbbabbabaabbbbbbaabbbaaaaaaaaaaaabaa
aababbbababbabaaaabbbabbbabbbbabbbbbabbbaaaababaaabbabbbababaaabababaaab
bbabaaaabbbabbbbbbbbbabbabbbbbaabbabbbab
ababbbabbaababbabaabbbaabaaaabba
abbabaababbbabbbabababbabababbbb
bbabbbbaaaaaabbbabbbaabbaaaabaababaababb
babbbaabaaaabaaaaaababaaaabaabbabababbaabbbbbbbabbababbabbaabbbabaabbbaa
aaabbbaaabbababbaabbabab
bbabaabbbaaabbbbbaaaaaba
babababbaabbbbaabbbbbbaaaaaaaaaabbaabaabbbbbaaba
bbabaababaaaabbbabbabbab
aababbaabbbbabbaabbabbaabbbaaaaabbaabaaaaabbabbb
ababbbabbabaababababbaab
aabbbbaabbbbbababaaabababbabbaabbbababbaababbaba
abbbaabbaabbbbaaabbbbbbabbabaaabbbaababb
baaaabababbbaaaaaaabbbbaabbaaabbbbaabbaa
bbaaaabaaabbaaababbabbba
bbbaaabbbaabaabbabaaaaabbaabbababaababbbbbaaaabababaabaabbaababa
baabbababaabbbbbbabbabba
baaaaabbabbbabbbababbaab
aaabbbababbaaaabababbbaaabaababa
abbaabaabbbaaabbabaababa
abbbbbbbbabababbbababbaa
abbaaabaabbaababbbbabaab
baababbabaabababbbbbbbabbbbaaaabaaabbbbb
aabbbababbaabbbbaaaabaabbbbaaaaabaaabababaaabbbbaabbabbbbbbabaabaaaaababaaaabbbb
aaaabbbaabbaaabaaabaabbbaaabababbbbaaaba
baaaaabbbbbbbbbbaababbbabbbababaaaabbaab
abaaaaaababbbabaabbbbaaa
aabbaaaabbbbabbbaaaaabab
aaabbaabbaabbbbaaabbbaaaabbbabbabbbbaaba
babbbbbbbbaaaaaabaabbbab
aaabaabbbbbbbbbbaaabababbaaaababbbbabaaaaabbabbbbbabbabbaaaabbaabaabababaabbbabbabaabbbb
aaabbbbabbabbabbababbaba
aaabbbbbaaababababaaabbababababa
aababbaabbbbbabaaaabbbaaaababbbaabbaaabb
babaabbbbaaabababbabbbababaabbab
baabbbaabbaabbbbaaaaaabb
aaaaabbbbabbbbbaaaabababaaaabbbbabbababa
bbbaaaaaababbbaabbababaa
aabbbbabbbabbbaabababbbbbbaabbbbababaababababbaaabbbbbbaababaaababaabbaaaabaaaba
abbaabbbabbabababaabbabb
bbaaababababbabbbababbbb
baabbbaababbabababaabbbaabaaabab
babbbbaababbbbaaabbabbbababaaaaabbaababa
bbbababaabbbbbababbbaaab
ababbbbabbabbbaaababbaab
bbbbaaaaabbbbaaaabbabbbbababbaba
aabbbbaabbaaaabbababaabbbaabbaabbaaaabbbabbbaaba
bbbabbaabbbbbbaababbababaaaabbbababaabaabaaabbba
baabbaababaabbaaaabbabab
babbbbaaabbababbbbaabbbbbbababbbbabaaabb
baabbbaaabbababbbabbbaab
abaaaababbabbaababaaaabb
bbbaabababaabbaaaaabbbaabaaabbbbbabbbbabbababaaa
bbbbbbbaaababbaabaaabbab
ababaabbaabbbabaababbaaabbbabababaaaabba
aaababbabaabbbbbbaaababaaaababbaabbbbbbbaaababbb
babaababbabaabaaabbbabbbbbbaaaaabaababab
ababbaaaaaaabaabaaaabbabbbbbaaaaaaaababaaaaabbab
bbbbabbbbaabbabababbbbabaabbbbbbaabababaaabbabaaaabbbbabbabaabbaaaaababbbbaababa
aaaabbbaaababaabaaaaabaa
bbbaababaabaabbaaababbabaaaabbbaaabaaaabaaaabbbb
abbabbaaabbaaababbbabbaabbaaabbabaaaaaab
ababaabaabbbbbbabaaaaaba
babbaabbbbbbaaaaabbaaabababbabaabbbbbabb
aababaaaaabaabbaaabbaaaababaaaabbbaabaab
bababaabaabaaabaabbbaabbaabaaaaa
babbabbbabbabaaaaaaabbbabaaababbbaaaaaaa
bbabbabbaaababaabbbbbabb
abaabbaaaababaabbbbaaaaabbabaabababbabaabbbbaabaaabbbaabababbaab
baaabbaaabbbaabbbbbbaababbbaaabbaabbaaabbaaaaabaaaabaaaabbbabbabaaabbbbabbbbaabaababbbabbbbbabaa
baaaabbbaabbbbbbbbaaabbbbaaaabbbbbaaaaab
babbabababbaaabaabbabaabaabaaabababbaabbbbbabaab
bbaaaaaaaabbbabaabbabaaabaaababaabaabbbb
bbbbabbbbbabbababbbbbbbbaababbbaabababababbababa
aaaaabbbbaaaabaababbbabababaaaabbbbbaaabaaabaabb
bbaabaaaaabbbbbbbbbbbaaaabaabbab
bbababaaaabaaabbaabbbabbbbbabbaaababbabbababaabbabbbababbabbabbabbbbaaab
bbbbbababbbbbaaaaaabababbaaabbaaaabbaabb
abbbaaaaababbbbbbbabbabbaaabbbaaaaabbabababaaaabbbababbb
abaaabaaaabbbabaabbbabab
bbaaaabbaaabbbabaaabababaaabbabbaabbabbaabaabbbbbbbbbabbbaabaabb
aabbaabababaaabbabaabaaaabbabaaaaaaabbbbaaaaaaab
bbaaababababbaaaababbbaababbbabb
babaabaabbbbbaaabbbaabaa
baaaabbbababbbbabaabbaabaababaaabaababbaabbbbbaa
aabbbabababbbbaaaaababaa
bbaabaaabbbbbaaabbabbaabbabbbbbbbabaaaba
baaaababababbbbaababbaaabaaaabbbbbaaabba
bbaabbbbbabbaabbabbbabbbbbabaabbbbbbbbbabaababbb
ababbabbbbaabbbaabbbbbbaabbbabababbbbbaabbbaabaabbababbb
bbaabaaabaabbababbbbaaba
baaaaabbaabbbabbbabbabab
aaabbbaabbabbbbaabbbabaaaaabbaab
abababbababbaabbaabbabaaabababaa
bbabbabaaababaaaabbabaabbbbbbbbbaaabaabaabbbbbbabbbbbabbabbbbaaa
baaaaabbaaaabbbabbbbbbabaabaabbabababaaabababbbb
bababbabababbbbaabbbabab
aabbaaaaaaabaaabbbaaaaab
bbbbbbaaabbbabbbaabaabbaabaabababbabbbbbabbabbababaabaaaaabbabbb
babaaaabbaababbababbbbbaaaaaaaababaabaab
abbbbbabbbabbbbaaabaaaaa
ababababaaabaababbaaabba
baababaabaaabababbaaababbbbbbabbbabaaabb
bbbbbbbbaabaaababbbbababaaaabaabbbbbabaa
abaabbaaabababababbabaaabbaaabaaabaaaaaa
abbaaababbaabaaabbbaabbabbbbaaab
bbabaabbaabaaabbbaaaabababbaaaabaabbbbaaaabbbbbabbaabbab
abaaaaabbbaaaabaaaaababa
ababbabbabaaaababaaabbaabaaabbab
bbabbbbabbabaabbbbabbabbaabababaabababbb
aaabbbaaabaaaaabbaaababaabbababbabbabbbababbaaabbabaaaaa
bbaaabbbaaabaabbbaabbbba
abbaabababaaaabababbbbababaaaaabbbbbabbabbbabbbabaabaaaa
bbbababaaababaaaaabaaaaa
ababbbabbbbaababbbaaaaaaabbbbbbabbbaaabaaababbbb
aababbabbbbababaabaabbbbbbaabbaabababbababaababaaabbaaaaababbbab
baabaabaaabbaababbbbaaba
bbabbbbbbabaaabbabaabaabbbabaaabbaaabaaa
abaaaabbabbabaabbbaaaabaaaaabbaabbbbababababbabb
ababbbababaaaaabaabbabaaaaabaababaabaababbababbaaabbaabaabbaabbaaaaabbab
abbabaabbababbabaaaabbab
aabbbabaabbbaaaabbabaabbbabbaaaaabababbb
babbbbbbaabbaaaaaabbbabbbbbabaabbbbabbab
aabababaaabbaaabaaaababa
aabababababbbabaaababbababaabbbaaaabaaaababbaaab
abbababbbbaabbbbabbaabba
baaabbaaaabbaaababbaaaabbbaabbba
bbbaababaabababbbbababba
baaababbabbaaaaababaaabb
abaabbaabaabbababaaaababbabaababababbaab
bababaabbbaabbbbbababbba
abbaababbababaabbbbabababbbaababbbbaaabbbbababaaabbababa
abbbabbbbbaaaaababbbbaababbababa
abbbbabaaabbbbabbaabbbab
ababbbaabbbabbbbababbaabbbbaaaab
aaabaaabbbabbbabbbbbbbabaabbbbbbbbbaaabababaabba
abbbbbabbabaabbbababaababaabaabaaabbbbaaaaaaaaabaaabbaab
baaaabbbabbabaaaaaaaabbbabbaaaababababaa
aababababaabaabaabaaaaaaaabababb
baaaabaaaabbaaaabbbbaaaaabbaabba
bbbbbbbabbbbabbbabbbbaab
aabbbabbaabbabaaaaaaabbbababbbbabbabbaabbaabababbbaabbbabbbaaaba
aababbaabbbbbbaaaababbbb
bababaabaabaaabbbbaabaaabbabbabbaabbbaab
bbabbabbabbaaaaabbaaaabbbabaaaaa
bbbbbabaabbabbaabbabbabbbbaaabbbbbaaaabbbbbaabbbaabaababbbbaabbb
aaabababababbbbabbbaabbabbabbbab
aaaaababaaababbbaabaaaabaaaabbaabbbaaaab
baabbbaabbaabaaabbabaaabaaababaabaaababbabbbabaabbaabbaaaaaabbaa
abbabbaaaaabbbbaabbbbbabbabbaaab
baaaababaababbabbbbbabbabaababaaabbaaaabbbabaaaaaabbabba
aababbabaaaabbbaaabaaababbabaaabbabbaaaababaaababbababaabaabbbba
bbaaabababbbabbabbabbabbbaabbababbaabaab
babaabababbbbbbaabbababbabbbaaab
aabababaababbbbbabbaaabaabbbbaba
baaabbbbbbaaabababbbaaaaababbbaabbbbaabbaaaaabaa
bbbbabbbbabbaabbabaabbab
abaabbbabaabbaabbaaaabbaaabbaaaababaaabbabbabbabbbabbbbbabbaaabaaaaabaab
abbbbbbbabbabbaaaabaaababbbbbaaabbaaaaababbbbbaaaabbabbb
aaaabbbaabbbabbaabbabbaabaabbaaa
bbaaaaaaabaabbaaaaaaaaababaaaabbaaabaaaa
baababbaabbaabbbababbaaabababbaa
aabbababaabbababbabbabbbabbbabbaababbabbaaabbabbabaaaabaaabbbbaababbbbbb
bbbbbaaaaababaababaabbbaaabaababaaabaaaa
aaabaabaaabaaabaabaabbbabbbaaaab
babaabbabbbbbbabbbbbbbbbbaaaaaaa
aabaaabbbabbbbaabaaababbbbabbbbb
baababaabaaaaabbabbbabbbbbababaaababbaba
bbaaaabbbbaaabaababaabaaaaabaabb
babbaabbababbaaaabbbbbbbaaaabbbabbbaabbabaaaabbababaaaaa
aaaaaaabbabaababababbbabbbabbaabbbabbbabbaaabaaa
abbaaaaabbbbbaaaabaabbaabababaaabbababbb
aababbaababbbbabbaaaaaba
babbbbabababbaaabbaabbbb
bbbbabbbbbabaabbbababbababaaabbb
bababbabaaaaabbbaabbbaba
abaaabaababbabbbaaaaabbbbbbbbaab
aababbbaaaababbaabbaabbbbbbbbbbbaaaaaabbbbbaaabb
babaababaabbaaabbabababbaaabbbabbbababbbabbaaabb
babaabababbabaaaababbaaababbbbaabbababbbbbbaaaba
babbabbbabaaabaabbbbabaa
aaabbbbaaababababbbbbabaaabbaabbbbbababbabbaaabb
aabaaabaaabbaaaabababaab
bbababbbaaabaaaaabbaaaaaabbbabaaabbbbabbaababaabbbabaabaabbabbaaabbaabab
babbabaaaababbabbabaaaabaaaaabbbaaabbbababbabbaababbbaaabbbababb
aabbbabbaabaabbbabbaaabb
bbbbaaabbabaaabaabbaaabbbbbabaabaabbabbb
aabbaaabbaaabbaabababaaa
abbbaabbbbbbaaaabababbabbbabaabbabbaaaaaaabaaaab
aaaabbbaaaabbbbabaaabbbbaaabbbbbabbaaabababababbbabaaaaabaabaabbbbbaaaabaaaaaabbbbbabaaa
bbbbabbbbbaabaaabbbaaaaaaababaabaaabbaaa
bbbbabbaaaabbbabaabbaaaaaababaaabaabbbaaabaaababbababbbabbababba
bbabbabaabaaaaaabbaababa
bbbaabababbabaabbaaaaaab
bbaaabbbbbbaaabbaaabaaabbbbaaabababbaabbaabbbabbabbabbba
abaabbaaabbbbbbaaaababbaaabaaabaaabbabbbabababbbabababaa
aaabababaabbbbaaabababbb
babaabbbaababbbabbaabbab
aaaaaabaabbabbabaaabbabbaaabaabb
aaaaaaababbbaabbbbabaabaaaabbaaaabaabbab
babbbbbbababaabbaaaaabba
ababbaaaaaaaabbbaabbbababbbaaabaaabbbbba
bbbbbbaaabbbaabbbaabbbaaaababaaabaabaabbbbababaaaabbbaaa
aaaaabaaaaabaabaaababbaaabaaababbbaababaaaabbbababbbaaabaaaaabbbbabbababbbbbbabb
bababaabababbbaaaabaaabaabaaaabbbabaaaaa
bababaabbbabaabbbabbbbaaaaaabbab
aabbbbaaabbbbbbaabaabbbb
aaabaababbbaaaaabbaabbab
abbbbbbabbbaababaaaabbbb
ababaabbbbabbbaababababa
bbabbabbaaabbbbabaaaabaababaabaabbbbabaa
abaaaabbaaabbaaaabbbaabaaabbaaaaababaaabaababaabbaabaaaabababbba
bbaaaabbbaababaaababbbbaaabbaaba
baaaababbaaabbaaabbaaaabaaabbbaabbaaabbbaaaabbab
babbbbbababbaaaaaabaaababaaaaabbabababbaabbbbbabbbaaaaababbaaabb
babbbbbabbbbbbababbaaaaaaabbabbb
babbbabaaaabaaabbbbabbba
abaaabbbbbbaaababaaabbabbaaabbba
baababbaaaaaabbbbbaabbbbababaaabaabbabab
bbaababbbaabaabbaaaababbaaabbaaabbbbbabbbabbbbabaabaabaabbbbaaaaaaaabbbababbaaaaabbaaaab
baaaaabbbbabbabababbbababababbbbaaaabbbb
bbaaababaabbabaababbaaaaaaababaaaaabbabaabbaabbb
bababaababaaaaabaaabbbbbabaabaab
aaabaaabbaaababaabbbabbbabbbaabbababbaab
bbabaababaaaabaaaaaaabab
bbabbabaaabbbabaabbbaaab
babaaaabbabbbabaaaaabaabbbbbbbbaabaaaababaaaaaab
bbaaaabbaaabbabaababaaab
bbbbbababbabaaababaababa
abbbabaabbaaaaaaabaaaaabbabbaaaaabbabbaabbaabaabaaabaabbaabababb
bbabbbbabbbbabbbbbabbabbbaaaababbbaaaaaaaabbaaabaaabbaaa
babbabbbaabaaaaabaaaabbaabbbbbbabbbbaababbbbabaaaabbbbaa
abaaaababaabbabaabaaaabbaaaaaaabbbaaabababababbbabbabbabababbaba
abaabbabbbaaaaaaabbbaaaababbbbbbbbaaaaaa
babbabababbbabbbabaaaaaaabaabaaa
bbabaaababbbbabbbbbabbabaababbbaaaaabbaaaabbabaabbabbbbbbbaaabbababaaaaa
ababaabbbaabbaabbbbbbbbbbbbabbababbbaaab
bbaaaababaaabababaaaaaaa
baabbbbbbbaabbbbbaabbabaaaabbbbabaabbabb
ababbbbbaaaaaaabaaaabbbb
baababaababbabaabaabbbba
aabbbbbbaabaaabbbbbbbbbabababaabbbbaabbbaababbbbbbaababb
bbbbabbaabaaaaaaababbbbabaabbababbaabbabbabaaaaabbaabbab
bbabbabababbaabaabbbbabbaaaabbbbabbbbabb
bbbaababababaababbaaabba
aabbbabaabaabbbaaaabaababbbabbab
abbababbbbabbbbaababababbbbaabbbbaaabbba
aababbaabbaaaabaaaabaaabbbbbabaa
bbaaaababbbbbbbbbbbbbbabaaabaabb
baaaabaababababbbabaabaaabbaaaaabbabbaaa
babaabbbbabaaaabaabaaabbbaabaababbbababb"; 
        private const string test2 = @"42: 9 14 | 10 1
9: 14 27 | 1 26
10: 23 14 | 28 1
1: ""a""
11: 42 31
5: 1 14 | 15 1
19: 14 1 | 14 14
12: 24 14 | 19 1
16: 15 1 | 14 14
31: 14 17 | 1 13
6: 14 14 | 1 14
2: 1 24 | 14 4
0: 8 11
13: 14 3 | 1 12
15: 1 | 14
17: 14 2 | 1 7
23: 25 1 | 22 14
28: 16 1
4: 1 1
20: 14 14 | 1 15
3: 5 14 | 16 1
27: 1 6 | 14 18
14: ""b""
21: 14 1 | 1 14
25: 1 1 | 1 14
22: 14 14
8: 42
26: 14 22 | 1 20
18: 15 15
7: 14 5 | 1 21
24: 14 1

abbbbbabbbaaaababbaabbbbabababbbabbbbbbabaaaa
bbabbbbaabaabba
babbbbaabbbbbabbbbbbaabaaabaaa
aaabbbbbbaaaabaababaabababbabaaabbababababaaa
bbbbbbbaaaabbbbaaabbabaaa
bbbababbbbaaaaaaaabbababaaababaabab
ababaaaaaabaaab
ababaaaaabbbaba
baabbaaaabbaaaababbaababb
abbbbabbbbaaaababbbbbbaaaababb
aaaaabbaabaaaaababaa
aaaabbaaaabbaaa
aaaabbaabbaaaaaaabbbabbbaaabbaabaaa
babaaabbbaaabaababbaabababaaab
aabbbbbaabbbaaaaaabbbbbababaaaaabbaaabba"; 
        private const string test2b = @"42: 9 14 | 10 1
9: 14 27 | 1 26
10: 23 14 | 28 1
1: ""a""
11: 42 31
5: 1 14 | 15 1
19: 14 1 | 14 14
12: 24 14 | 19 1
16: 15 1 | 14 14
31: 14 17 | 1 13
6: 14 14 | 1 14
2: 1 24 | 14 4
0: 8 11
13: 14 3 | 1 12
15: 1 | 14
17: 14 2 | 1 7
23: 25 1 | 22 14
28: 16 1
4: 1 1
20: 14 14 | 1 15
3: 5 14 | 16 1
27: 1 6 | 14 18
14: ""b""
21: 14 1 | 1 14
25: 1 1 | 1 14
22: 14 14
8: 42
26: 14 22 | 1 20
18: 15 15
7: 14 5 | 1 21
24: 14 1

aaaabbaabbaaaaaaabbbabbbaaabbaabaaa"; //42 match 'babbb' ou

          private static void exo2()
        {
            var lines = input.Split(Environment.NewLine);

            var characterMatch = new Dictionary<int, char>();
            var combiMatch = new Dictionary<int, int[][]>();

            int mIdx = 0;
            while (mIdx < lines.Length && lines[mIdx].Length != 0)
            {
                var p = lines[mIdx].Split(':', StringSplitOptions.RemoveEmptyEntries);
                int ruleId = Int32.Parse(p[0].Trim());
                if (ruleId == 8 || ruleId == 11 ||ruleId == 0)
                {
                    mIdx++;
                    continue;
                }
                if (p[1].Contains("\""))
                {
                    characterMatch[ruleId] = p[1].Trim()[1];
                }
                else
                {
                    List<int[]> combiRules = new List<int[]>();
                    var orRules = p[1].Split('|');
                    foreach (var orRule in orRules) {
                        combiRules.Add(orRule.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse)
                            .ToArray());
                    }

                    combiMatch[ruleId] = combiRules.ToArray();
                }
                mIdx++;
            }

            mIdx++;
            var messages = new List<string>();
            while (mIdx < lines.Length)
            {
                messages.Add(lines[mIdx++]);
            }

            var stringMatch = new Dictionary<int, string[]>();

            string[] ToStringMatch(int ruleId)
            {
                if (stringMatch.TryGetValue(ruleId, out var res))
                {
                    return res;
                }

                if (characterMatch.TryGetValue(ruleId, out var character))
                {
                    return new[] {new string(new[] {character}),};
                }
                List<string> combis = new List<string>();
                foreach (var andRule in combiMatch[ruleId]) {


                    if (andRule.Length == 1)
                    {
                        combis.AddRange(ToStringMatch(andRule[0]));
                        continue;
                    }
                    if (andRule.Length != 2) {
                        throw new Exception($"weird andRule: {ruleId}");
                    }
                    var prefixes = ToStringMatch(andRule[0]);
                    var suffixes = ToStringMatch(andRule[1]);
                    foreach (var prefix in prefixes)
                    {
                        foreach (var suffix in suffixes)
                        {
                            combis.Add(prefix + suffix);
                        }
                    }
                }

                int width = combis[0].Length;
                if (combis.Any(s => s.Length != width))
                {
                    throw new Exception("unaligned");
                }

                var strings = combis.ToArray();
                stringMatch[ruleId] = strings;
                return strings;
            }

            foreach (var combiMatchKey in combiMatch.Keys)
            {
                if (!stringMatch.ContainsKey(combiMatchKey))
                {
                    stringMatch[combiMatchKey] = ToStringMatch(combiMatchKey);
                }
            }

            foreach (var kv in stringMatch)
            {
                Console.WriteLine($"{kv.Key}: \"{string.Join("\" | \"", kv.Value)}\"");
            }

            bool MatchUnRoll(int ruleId, string val, ref int pointer)
            {
                if (pointer >= val.Length) {
                    return false;
                }
                var matches = stringMatch[ruleId];
                foreach (var match in matches)
                {
                    if (val.Substring(pointer).StartsWith(match))
                    {
                        pointer += match.Length;
                        return true;
                    }
                }

                return false;
            }

            bool MatchRuleNTimesUnrolled(int ruleId, string val, int n, ref int pointer)
            {
                bool match = true;
                for (int i = 0; i < n; i++)
                {
                    if (!MatchUnRoll(ruleId, val, ref pointer))
                    {
                        match = false;
                        break;
                    }
                }

                return match;
            }

            bool Match42NAnd42MAnd31MTimesUnrolled( string val ) {
                for (int n = 1; n < 10; n++)
                {
                    //Console.WriteLine($"Try with n:{n}");
                    int pointer = 0;

                    if (!MatchRuleNTimesUnrolled( 42,val, n, ref pointer))
                    {
                        continue;
                    }
                    //Console.WriteLine($"Can match 42 n{n}");

                    int savpointer = pointer;
                    int m = 1;
                    for (; m < 10; m++)
                    {
                        pointer = savpointer;
                        if (!MatchRuleNTimesUnrolled( 42,val, m, ref pointer))
                        {
                            continue;
                        }
                       // Console.WriteLine($"Can match 42 m {m}");
                        if (!MatchRuleNTimesUnrolled( 31,val, m, ref pointer))
                        {
                            continue;
                        }
                        //Console.WriteLine($"Can match 31 m {m}");
                        if ( pointer >= val.Length)
                        {
                            Console.WriteLine($"Match with n:{n} and m: {m}");
                            return true;
                        }
                    }


                }

                return false;
            }


            bool MatchRuleNTimes(int ruleId, string val, int n, ref int pointer)
            {
                bool match = true;
                for (int i = 0; i < n; i++)
                {
                    if (!Match(ruleId, val, ref pointer))
                    {
                        match = false;
                        break;
                    }
                }

                return match;
            }

            bool Match42NAnd42MAnd31MTimes( string val ) {
                for (int n = 1; n < 7; n++)
                {
                    Console.WriteLine($"Try with n:{n}");
                    int pointer = 0;

                    if (!MatchRuleNTimes( 42,val, n, ref pointer))
                    {
                        continue;
                    }
                    Console.WriteLine($"Can match 42 n{n}");

                    bool match11 = true;
                    int m = 1;
                    for (; m < 7; m++) {
                        if (!MatchRuleNTimes( 42,val, m, ref pointer))
                        {
                            match11 = false;
                            break;
                        }
                        Console.WriteLine($"Can match 42 m{m}");
                        if (!MatchRuleNTimes( 31,val, m, ref pointer))
                        {
                            match11 = false;
                            break;
                        }
                        Console.WriteLine($"Can match 31 m{m}");
                    }

                    if (match11 && pointer >= val.Length)
                    {
                        Console.WriteLine($"Match with n:{n} and m: {m}");
                        return true;
                    }
                }

                return false;
            }



            bool Match(int ruleId, string val, ref int pointer)
            {
                if (pointer >= val.Length) {
                    return false;
                }
                if (characterMatch.TryGetValue(ruleId, out var c))
                {
                    var b = val[pointer++] == c;
                    /*if (b)
                    {
                        Console.WriteLine(ruleId);
                    }*/
                    return b ;
                }

                int cachePointer = pointer;
                foreach (var andRule in combiMatch[ruleId])
                {
                    pointer = cachePointer;
                    bool matchCombi = true;
                    foreach (var subRule in andRule)
                    {
                        if (!Match(subRule, val, ref pointer)) {
                            matchCombi = false;
                            break;
                        }
                    }

                    if (matchCombi) {
                        //Console.WriteLine(ruleId);
                        return true;
                    }
                }

                return false;
            }

            int nbValid = 0;
            foreach (var message in messages)
            {
                if (Match42NAnd42MAnd31MTimesUnrolled(message) )
                {
                    nbValid++;
                    Console.WriteLine(message + " valid");
                }
                else
                {
                    Console.WriteLine(message + " invalid");
                }

            }
            
            Console.WriteLine(nbValid);


        }
    }
}
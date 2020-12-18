﻿using System;
using System.Linq;

namespace Day12
{
    class Program
    {
        private const string input = @"N2
R90
S2
F40
R180
F50
R90
W1
F79
W4
F3
E3
F76
L90
N2
L90
S4
W2
S2
F96
R90
F64
E4
N5
R180
F54
S5
L180
N3
F33
E4
S4
L90
S2
E2
F37
N3
W2
L90
S5
R90
E1
F98
R270
E5
F21
L90
F84
E3
F21
S5
F42
E3
L270
E3
L180
S2
E4
S4
W4
R180
F92
N2
E2
R90
F55
S4
L90
E2
R90
N3
W1
L90
F92
R90
N2
L90
W4
R90
F57
N3
F99
E2
R90
S2
W4
L180
N3
F32
R90
F26
E1
N5
R90
S2
F66
W1
L90
F8
E4
S4
F27
W4
F78
R90
S1
E1
R180
W5
R90
F55
E1
F9
E3
F54
N4
W2
F21
W4
N2
L180
F45
S5
F62
L90
E1
N5
F36
W4
R90
N1
F35
E3
R90
W4
S3
R90
F31
R90
N3
W5
F98
N1
E3
R90
S5
S4
W3
F28
E3
F67
R90
F57
L90
L90
F39
N2
F49
W1
N4
L90
S1
F71
R90
F95
R90
F78
R180
N3
F41
N2
R180
W4
E4
N4
W5
R90
F59
S5
F26
R90
S4
F8
R90
S3
R90
F81
S2
W5
F82
L90
S4
F41
E3
R180
F83
W2
S4
W1
R90
S3
F53
W4
F79
N4
W3
E2
F14
W3
R90
F35
R90
F82
S5
R90
F46
E5
R90
S4
L270
E1
S4
W2
S2
E1
L90
F61
L90
F75
S1
F2
W2
R90
S3
W4
R180
F60
R90
S3
E1
F21
L180
F93
N5
F17
N2
F23
L90
F30
R180
F27
N2
F55
L90
S1
E5
R90
W4
F68
W2
R90
E1
N5
F12
S1
F26
E5
W1
L90
N1
L90
W3
R180
F90
L180
E3
F9
L90
F50
L90
S5
F5
F46
R90
E4
L90
F8
S5
W3
S5
W3
F84
R90
F61
S3
F41
R90
F78
L90
E5
N5
F95
N2
F15
R180
S2
L90
E4
L90
S4
R90
F81
F35
R90
F98
E1
S5
N2
F58
L90
F89
W1
L90
F8
L90
N2
F68
S5
W1
S1
F87
L90
F57
W1
R180
F30
E2
F69
W2
R90
S3
R90
W5
N5
F46
R180
F99
F84
S5
F78
S3
F36
N1
W5
L90
W3
R90
S1
R90
F66
R180
L180
S5
F54
L180
F79
E5
L90
E3
F33
S2
S2
L90
F78
E4
F90
L90
F33
S4
W2
F44
L90
S3
W1
L180
F42
N5
F17
R90
E4
L90
E5
S5
E2
N5
W2
R90
W3
L90
F2
W2
N2
F62
N3
L90
N2
W3
F86
N3
W2
L90
E5
R90
L180
F42
N4
E3
F62
E5
F78
R90
N3
R90
W1
N1
E4
L90
F91
N4
W5
F25
N3
R90
E1
R90
E1
N2
F21
L90
F97
S2
L90
S2
E4
F48
S1
R90
F4
N5
R90
R90
N4
F11
W5
N4
F52
L90
W2
L90
R180
F77
S5
F52
N5
W5
N4
L270
W5
F93
S2
F98
N1
E5
N1
L90
F30
L180
W1
S5
L90
S1
R90
R90
F43
E2
F72
W1
N3
F90
L90
N5
F60
E4
R90
E3
L90
S3
F41
S2
L90
N1
F49
L90
S5
F30
S3
R90
F72
R180
N2
W3
S1
R90
N3
E4
S4
F43
R180
S2
E5
S1
L90
W4
L90
E2
N3
F52
N1
F4
W5
F59
L90
W2
N3
W5
S3
L90
W2
N5
E1
F70
S5
L90
E4
R90
R180
E3
S4
F53
E4
L180
F41
S1
E1
L90
W3
S2
F16
S4
R90
R90
W5
N4
E4
N5
L90
E1
N3
F100
S1
F88
S3
F10
W3
L180
S4
L180
N1
E1
S3
F77
W5
E3
L270
N3
L90
F51
N5
F79
S4
E2
L90
E2
F40
R90
S5
W1
L90
N4
S4
R180
E4
S4
R90
F49
L90
S5
E4
R90
S5
L90
S4
R90
E1
N3
F4
E2
L90
E4
R180
S4
E2
F92
E3
L180
S1
R180
W5
R90
F67
S1
R90
F48
W2
L90
S5
F72
R90
N5
E3
F64
F63
W5
F72
W1
F56
R270
E2
N3
F67
S4
F78
E2
R90
E3
L90
S1
F97
F14
L270
W1
F79
N5
E1
S1
R180
W2
F39
S1
W4
R90
E2
F51
S3
E3
L90
S3
F78
R90
S1
W1
F77
S5
F71
S4
L90
W3
F39
S2
E4
S3
F19
E2
N2
E3
F78
N3
F10
S2
W4
L90
W2
W2
L90
F67
N4
W4
R90
S1
W1
F42
E5
N3
R180
W3
S4
W2
S5
W5
L90
E4
R180
N1
L180
E5
L90
N3
E4
F23
S1
F84
R90
E1
L180
E5
E2
F54
E2
S5
E4
L270
L90
R90
E2
R90
N1
L90
F82
L90
W5
F83
S1
F73
L180
F39
F72
S1
L90
W5
R90
S1
W5
F27
W1
L90
N3
W4
F85
L90
N1
R90
S5
E4
S3
R180
F22
S1
F21
S5
L90
E2
F18
S5
E4
S3
F84
";
        private const string test = @"F10
N3
F7
R90
F11";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            exo2();
        }

        public enum Direction
        {
            East = 0,
            South = 1,
            West = 2,
            North = 3
        }

        public static char ToOp(Direction dir)
        {
            switch (dir)
            {
                case Direction.East:
                    return 'E';
                case Direction.South:
                    return 'S';
                case Direction.West:
                    return 'W';
                case Direction.North:
                    return 'N';
                default:
                    throw new ArgumentOutOfRangeException(nameof(dir), dir, null);
            }
        }

        static void exo1()
        {
            var ops = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Direction direction = Direction.East;
            int x = 0;
            int y = 0;

            foreach (var op in ops)
            {
                int val = Int32.Parse(op.Substring(1));

                Move(op[0],  val, ref x,ref y, ref direction);
            }

            Console.WriteLine(Math.Abs(x) + Math.Abs(y));
        }

        private static void Move(char op,  int val,ref int x, ref int y, ref Direction direction)
        {
            switch (op)
            {
                case 'N':
                    x += val;
                    break;
                case 'S':
                    x -= val;
                    break;
                case 'E':
                    y += val;
                    break;
                case 'W':
                    y -= val;
                    break;
                case 'R':
                    direction = (Direction) ((((int) direction) + (val / 90)) % 4);
                    break;
                case 'L':
                    direction = (Direction) ((((int) direction) - val / 90 + 4) % 4);
                    break;
                case 'F':
                    Move(ToOp(direction), val, ref x, ref y, ref direction);
                    break;
                default: throw new Exception();
            }
        }
        static void exo2()
        {
            var ops = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToArray();

           var ship = new ShipState();

            foreach (var op in ops)
            {
                int val = Int32.Parse(op.Substring(1));

                ship.Move(op[0], val);
            }

            Console.WriteLine(Math.Abs(ship.x) + Math.Abs(ship.y));
        }

        public class ShipState
        {
            public int x;
            public int y;
            public int waypointx = 10;
            public int waypointy = 1;

            public void Move(char op,  int val )
            {
                int newX;
                int newY;
                switch (op)
                {
                    case 'N':
                        waypointy += val;
                        break;
                    case 'S':
                        waypointy -= val;
                        break;
                    case 'E':
                        waypointx += val;
                        break;
                    case 'W':
                        waypointx -= val;
                        break;
                    case 'R':
                        val /= 90;

                        for (int i = 0; i < val; i++) {
                            newX = waypointy;
                            newY = -waypointx;
                            waypointx = newX;
                            waypointy = newY;
                        }
                        break;
                    case 'L':
                        val /= 90;
                        for (int i = 0; i < val; i++) {
                            newX = -waypointy;
                            newY = waypointx;
                            waypointx = newX;
                            waypointy = newY;
                        }
                        break;
                    case 'F':
                        x += val * waypointx;
                        y += val * waypointy;
                        break;
                    default: throw new Exception();
                }
            }
        }


    }
}
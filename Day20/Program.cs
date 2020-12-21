using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace Day20
{
    class Program
    {
        private const string input = @"Tile 3571:
##..##....
..##..#..#
#...##....
.....#...#
..........
...###....
#......##.
#...#...#.
#...##...#
#.####.##.

Tile 2687:
#..##..###
..........
.....##..#
.#.#..##.#
#.#..#..##
#.....#...
#...#.....
##....##..
#...#...##
..#.#.#.##

Tile 3049:
##.#.#.###
....##.###
....##....
#.........
#.#...#..#
#..##....#
#.#......#
#..#..##..
#......###
#.#..#...#

Tile 1597:
###..##...
##.....###
.#..#..#.#
#.......#.
#.#.......
.#..#.....
#.....#...
#........#
##.#...##.
.....#.###

Tile 1301:
#.##.#.###
#........#
....#.....
#.....####
.#....#.##
.....#....
#..##..#.#
.....#..##
.#.##..#.#
#...######

Tile 3259:
..#####.#.
.....#...#
#...#.....
...##...#.
.#..#..##.
.#.......#
........##
#.......#.
.#.#...#..
#...#.#..#

Tile 3989:
#..#..####
..........
#........#
.#....#...
..........
#.........
.#........
#........#
...##.####
.######.##

Tile 3803:
#.####...#
.###.#..#.
....##..#.
#........#
..##..#...
####.#....
..#...#...
#..#.....#
..##....#.
#....#...#

Tile 2897:
.#..##.#.#
..#.#...##
#........#
###.#..#.#
...#..#.##
...#....##
....##...#
.....##..#
.#....#...
..##....##

Tile 2843:
##.###..##
#.#.......
#....#....
#..##.##..
.##..#.##.
#....#....
#.#...#.##
..........
.#...#...#
###..#..##

Tile 3023:
.#..###.#.
.........#
..........
.#........
#.#....#.#
....#...#.
#.......#.
##.#.....#
..#...#..#
.....####.

Tile 2887:
#....##...
#...#.....
##...##...
#.....##.#
.......#..
#......#.#
..##..#..#
....#....#
#.###.....
#.####..#.

Tile 1013:
#..####.#.
#.##...#.#
#..#..#...
#..#..#..#
...#......
#.####...#
.#..##..##
...#.#..##
....##..##
#.##.#.#.#

Tile 3733:
###.##.#.#
..#....#..
#...#.#..#
....###..#
.#........
.....#....
........##
##........
#........#
#.#...#..#

Tile 3691:
.##...####
##..##....
#.#.##..##
#........#
#.....##.#
.....#....
##.#.....#
#..#.....#
..#.......
####....#.

Tile 3061:
##.....#..
.....#...#
....##...#
###.#.....
#..#..###.
#.#.###..#
..#......#
#..#.#...#
..#.......
..#.#..#..

Tile 1489:
###.......
.....##...
..#...##..
#.....#...
#.#......#
##.#..####
...##.#...
...#...#.#
..........
.##.##.#.#

Tile 1637:
#########.
.#.....#..
#........#
#........#
.##.....##
.........#
#....#..##
#.....####
...###...#
.#..##..##

Tile 1069:
#.#...####
##...#...#
.....#...#
.......##.
......#..#
#........#
#...#.....
......#...
#.#..#....
####.##.#.

Tile 1039:
#..#######
###.......
.....#....
#.........
....#....#
...####...
.#...##...
#.#....#.#
........##
#.#..#..#.

Tile 2767:
.#.#..#.##
.#..#....#
#..#.#....
#.#..##..#
.####.#.##
#....##...
....##..##
###.....#.
..........
....#.###.

Tile 2957:
####.#####
.......##.
...#.....#
...##..##.
...##.##..
#..#..#..#
.....#....
#..#....#.
.##.......
.##..#.##.

Tile 2789:
.##..#.#.#
#.#.....##
#....#...#
#....##...
..#..#....
#.........
#.#..#..##
#........#
.#.......#
#####...##

Tile 2837:
.....#...#
.....#.#.#
#.......#.
#...#...#.
..#.....#.
..#.#..#..
##.......#
....#....#
#...#.....
##.###....

Tile 3251:
.######...
...#......
.#.#..###.
#..#.##..#
###.#....#
#.#......#
..#..###..
##.#..#..#
...#...###
##.#..##..

Tile 3137:
#####.#..#
#.#..#.##.
#.#..#....
#.........
.........#
.........#
...#......
#...#...#.
....#..#.#
.#.###.#.#

Tile 3433:
.##..####.
...#......
#..##....#
....#....#
#..###....
..#......#
.#..###...
.##.#.....
.........#
.....#....

Tile 2551:
#.########
#.#.......
##..#...##
#.#..###.#
#........#
.#.#....#.
#........#
.##....#..
#........#
##..##.#..

Tile 2647:
..####..##
##....#..#
#.........
###.#.....
#......#..
....#...##
.#..##.#.#
.#.#..#...
.....##.##
.#.#...#..

Tile 1087:
#..###..##
#...#.#.#.
.......#..
..#.#.#..#
#.......#.
#....#....
....#....#
##...##..#
#..#......
.#..#.###.

Tile 1423:
..#....#.#
#........#
.#.##.##..
#.###.#.#.
#.#......#
...##...##
#....#....
....#....#
.........#
#####....#

Tile 1759:
..#.#..#..
##...#...#
....#..#..
#....#....
.##..##..#
...#.#...#
#..#.....#
##.......#
......#..#
#.##......

Tile 1583:
.###.####.
......###.
......#..#
.#...##...
#...#....#
..#.##....
#...##..#.
......#...
#.....###.
####.#....

Tile 1171:
###......#
#...##...#
#####..##.
#.......#.
#.#...#..#
#....#....
....#....#
##.....#.#
#.#..#..##
#.#.#..##.

Tile 2801:
.###.####.
......#...
##..##.#.#
.....#....
#......#..
###..##..#
##.#..##.#
#..#..#...
#..#.#...#
#..###.###

Tile 1559:
.##..#...#
#.##..#...
...##..#..
..#.#.....
...#...#..
.........#
...#.....#
#..##.#..#
##..##....
...###...#

Tile 2609:
##.#..####
..........
#........#
##.###...#
#.#..#....
..#..##..#
#....#.#.#
#.#.......
#....#...#
#.####.#.#

Tile 2287:
#......#.#
.....#.#.#
..#..#...#
##.#..#...
..#..#.###
.......###
#......##.
#.##.##...
......#..#
#####.##.#

Tile 3659:
.###.#####
#.#.......
..........
..#.....##
#..#......
#.#.#...##
#.........
.#...#....
##.....#..
#####.##.#

Tile 3539:
.......#.#
..##...#..
.....#.#.#
##.#......
####......
...#..#...
#.......##
#...#.....
#..#.....#
.##.#....#

Tile 3121:
..##.#...#
.###..#...
##.#.#....
#.....#..#
#.#.......
#.........
....#...##
......###.
#........#
#..###..##

Tile 2237:
...##.....
..........
...#......
#....#...#
#.........
.......#..
#...###..#
.....#...#
.........#
#.####.##.

Tile 1277:
.###...##.
.......###
#.....##..
#.##..###.
#.#..#....
.....#....
#...#....#
#.#......#
#...###..#
...##...##

Tile 2161:
..#####..#
#....##..#
#.....#..#
....#....#
.....#.##.
..........
#......#.#
#..#......
#....#..##
.##.....#.

Tile 3709:
.#..#...##
#..#.....#
...#....#.
..........
.#...#....
..........
....##....
#.........
.........#
..####....

Tile 1117:
##.##.#..#
.....##...
.#.#..#.##
.#...#..#.
#.##.#....
####.....#
##..#.....
#.........
#...##...#
####..#.#.

Tile 2081:
##.##.###.
#...#.....
#.....#...
#.#..#.#..
#.....#..#
...#.....#
#....#....
......#..#
.#.##..#..
###..#.#.#

Tile 1709:
##...#.##.
###..#....
#.......#.
#.....##..
.........#
#....#..##
..#...##..
#...#.....
#...#.#..#
.###.#....

Tile 2927:
...###..##
##.#......
..........
##........
#....#...#
.......##.
#.....#..#
##.#.#....
#......#..
...#.####.

Tile 1499:
#....##.#.
......#...
#........#
......#...
.#.......#
#.#...#.##
..#....#.#
#...#.....
.........#
#.....##.#

Tile 1453:
#.##.####.
..#...##..
.........#
.........#
#..#..#...
.........#
#....#.#..
#.....#..#
.#........
#....#....

Tile 1283:
.#.##..###
..#...#.#.
...##..#..
#.......#.
#......#..
#..##.....
#.......##
....##...#
..#.....##
##.#.#...#

Tile 2063:
......#.##
.........#
....##..#.
.#....##..
##........
.###.###.#
#.#....#..
....#...#.
#......###
#....####.

Tile 3529:
...###.##.
#....#...#
...#.....#
...#.#..#.
.#.#.....#
#...#.....
##..#..#..
#.....#..#
.#........
.#..#####.

Tile 2657:
..#.##..#.
##..#...##
#.....#...
#....##...
.....#..##
#.#..##.##
#.........
#.#...##.#
##....#...
##..####.#

Tile 2089:
.#########
##.#.##..#
#........#
#..###..##
...#......
##..#....#
#...#..#..
#..#....#.
..#.#....#
...###...#

Tile 3779:
#.#...##.#
.##...##..
.....##...
.#....##.#
###..##..#
#.#..#.#..
....##...#
##...#....
.#...#....
#######...

Tile 3217:
...##.....
....##....
.....##..#
##...#.#.#
###.......
...#...#..
...#.....#
#..#.#.###
##.#...#.#
.#.#..##..

Tile 3907:
..#..##.##
#.#.....##
#.......#.
.#...###..
..###.####
##.#..##..
#.........
##...#..#.
#....#....
.#.....#.#

Tile 3547:
#..#.##...
#..###...#
##.......#
.....#....
#...#...#.
#..#..#...
........#.
......##.#
.......#..
.##.#..##.

Tile 3187:
##.#.##...
#...#.##.#
#...#.....
#....#..##
....#.#..#
.....#....
.....#..##
....##...#
..........
#######.##

Tile 1217:
##.#####..
#.......#.
...#....##
#........#
#.#......#
.....#...#
#.........
....#...##
#...#.....
.#...###.#

Tile 3821:
#.###.###.
#.#......#
#..#.#...#
.##...#.##
...#....##
#...#..##.
#......#.#
###..#...#
.........#
#....##.##

Tile 1607:
##..#..##.
#.##....##
###.##.##.
.#....##.#
#.#..#...#
.....#.#..
#.#..#..#.
#.#..#....
..........
......##.#

Tile 1459:
.###.##..#
#.......#.
##........
..#...####
###.......
#....#....
.#.....#.#
###..#..##
.....#....
..#..#..##

Tile 2129:
....#.#..#
#.....##.#
#........#
..........
..#......#
#.....#..#
.#..##...#
#.#.#..#.#
#.........
#.##....##

Tile 1601:
.#.#.#.#.#
..#..##...
#.#.#...#.
....##....
....##.#..
..#.......
#.....#..#
#..##.#...
.........#
...####.#.

Tile 1801:
#.#...#.#.
..#....#..
#..#...#..
......#...
.....#....
#.#..##.##
#.........
...#.#...#
.#....#..#
#.....##..

Tile 2447:
..#.....##
.#..#...##
.....#.#..
.#....#..#
#...####.#
##.##..###
.#.......#
#.##.....#
#.......##
.###.#...#

Tile 2203:
#.....##..
#.#.......
........##
###...#...
..........
#..#.....#
....#.##.#
..##.....#
.#...#...#
#.###..#..

Tile 1381:
.#...#...#
....#.....
##.......#
#.....#...
.........#
.#.......#
.......##.
#.#.....##
.#..#.##..
##.#.##.#.

Tile 3163:
#...####.#
#......##.
...###.#.#
#....##...
#......###
.....#..##
.#..###...
#..##..#..
#.....#...
#.#####.##

Tile 3673:
.#....##.#
..#..####.
#.....#...
...#....#.
#....#...#
#....##.#.
##...#.#..
.#..#.#...
#..#.....#
####.##...

Tile 3919:
....##.##.
##..##....
...##...##
#...#.....
..........
....#..###
.#.....#..
....#..#.#
.##..#....
.#...###.#

Tile 2437:
..##...#.#
#....#...#
#..#.....#
..#.#...##
.......#..
........##
........##
.......#.#
#....#.#.#
##..#.###.

Tile 2969:
##.#.##.#.
#.##....#.
.##......#
#.#.#....#
#.#.......
.........#
....#.#.##
.#.......#
...#..#.##
##.#.##..#

Tile 2621:
.##.##.#..
.##...#...
..........
#.........
#.#.#.#..#
..#..#...#
.......#.#
#.#.....##
...#..#...
#.......##

Tile 3613:
##..#....#
#..##.....
..#.......
..#...#...
...#...#..
...#.....#
..#.....#.
..#.###..#
..........
..#.####..

Tile 2777:
##.#####.#
#.##.#...#
..#.......
.##...##.#
.........#
.#.###.##.
#......##.
#......##.
#...##..##
#..#....##

Tile 2711:
#..#..##..
..........
#.#......#
#.....####
..........
##.......#
........#.
#.......#.
#.#..#...#
#.#.####.#

Tile 2281:
.#.###...#
###....#..
..........
#.#..#..##
.........#
###..#.##.
####..#..#
##..#.....
##..#..#..
#.....#..#

Tile 1579:
....#..#..
#........#
#...#..#..
..##.#.#..
.###.#...#
....##..#.
...##.#...
.#.##....#
.#.......#
##...#...#

Tile 2411:
#.#....##.
..#...#..#
.#..##....
.#..##...#
.....#.#.#
......##..
#.#....###
.#.##....#
..#..#....
..#.###..#

Tile 2963:
.......##.
.....#....
.........#
#.....#..#
.....#.#..
.....#.##.
.#.#...###
#.#.......
.#.......#
###..#..#.

Tile 1693:
#.##..##..
..........
.........#
.##..#...#
.........#
#........#
###......#
..#...#...
.#.##....#
...#.#...#

Tile 2399:
###.#.##..
#...#.....
...#...#.#
###.......
.##.##....
##.....#.#
####......
##.......#
#..#...#.#
#...#.....

Tile 1913:
##.....###
........##
#.....###.
..........
....#...#.
#.#.....#.
#....#...#
..#...#...
....#..#..
#..####...

Tile 3343:
.....#.##.
..#...#...
####.....#
....#.....
......#..#
......#...
#........#
#.......#.
..#...#.#.
.....###.#

Tile 2557:
#.......##
....#...##
#......#.#
#.#.#.#.##
#..##.....
..###.#.#.
#..#......
#...#.....
....#....#
#.##...#.#

Tile 1097:
.#.#.#..##
..#.#.....
##........
.##...##..
..#..#...#
#........#
........##
#.#.#.....
.#.#.....#
#.##..#...

Tile 2591:
##..#..###
......#...
...###.#..
#.......#.
#.#.....#.
#.##..#...
....##.#..
#.#..#...#
#.###..#.#
##........

Tile 3413:
...##...##
..#....#..
##.#....#.
#..#....#.
#........#
#..#......
#.....#.##
##.....#.#
#....#....
####.#...#

Tile 2087:
###..###.#
##......#.
#..#...#.#
#.#.......
##.#.....#
#.#.#.....
...#.....#
..........
#.........
#.##..###.

Tile 3037:
......##..
..#..#....
#.#.......
#.#....#..
.#.#.##..#
#.....#.##
#.....#.#.
.#..##...#
#....##...
...#..###.

Tile 2239:
.####..#..
#.........
.#.......#
#..##.....
##..##..##
#.#....#..
.........#
#.......#.
....#.....
#.###..#.#

Tile 3313:
##.##.#..#
.#.#..#...
.##...##.#
.#.##..#..
##........
..........
#..#.#....
#.........
..........
.##..#..#.

Tile 3361:
.###.#...#
##..#.#..#
...##....#
#..##.....
..........
#......#.#
.........#
..#..##.#.
#..#...###
#...#.#.#.

Tile 3167:
..##..####
#.....#.#.
.....#.#..
...#......
....#.#.##
...#.#.#..
.......#..
##........
#..#...#.#
####.##..#

Tile 1979:
#.#.###...
..#.....##
...#...##.
#.......##
........##
..##..#...
..#......#
#.#....#.#
#..#.....#
.##.......

Tile 1831:
##.##.##.#
#.........
.........#
##.......#
###.....##
..##..##..
##.....#.#
#....#...#
###.##..#.
#..#####..

Tile 1487:
#..#....##
.#..#....#
#....#....
#.........
#.#...#.##
#..##...##
...##..#..
.#...##...
.#........
.#...#..#.

Tile 1987:
###..#....
##..##...#
......#..#
.#.#...#.#
.....#.#..
....#..#..
....###..#
#...##....
###.....#.
...##.####

Tile 3083:
....##..#.
##..#.###.
#..#...##.
#.###.....
.........#
....#.....
.#........
.#........
#.........
#.#.#.##.#

Tile 1543:
...##..###
.........#
.......#.#
#..#..#.##
##....#.#.
....#..#..
#..#......
...#...#.#
##.##..#..
#.###..#..

Tile 1151:
#.#..#####
#.#..#...#
#..#......
....#...#.
..........
#...#.#..#
#..#.#...#
##....#..#
#.........
##.....###

Tile 1009:
##..#...##
#....#...#
.#...#....
#........#
.#..#..#..
.###.##.#.
#......#.#
##.#..##..
#....#.###
####...##.

Tile 3929:
......#.#.
#..#.##.##
....#.#.##
#.##..#...
###..#..#.
.##..###.#
.##......#
....#....#
........#.
.#...###..

Tile 1321:
#.##..#...
.##.....##
#.#..#....
...#.....#
###......#
#.#.#.##.#
##.......#
##......#.
.#...#....
.#..##..##

Tile 2017:
###.#..###
.#..###..#
#..#......
.........#
..#...##..
....#.##.#
...##.#..#
....#...##
#..#..##..
##.#.#.#..

Tile 1747:
....##.#..
#........#
.....#..#.
..#####...
######..#.
##..#.#...
.###..#..#
#.....#...
.##..#..##
..#####...

Tile 3089:
#....#.##.
#.....#..#
..........
#..#.#....
.......#..
#.....#...
........#.
##..#..##.
#.....#..#
#.#.#....#

Tile 3019:
.#..###.##
.#...#...#
#.#.......
###.......
#....#...#
#.##...#..
##........
.#.......#
.#.#......
.#..#...#.

Tile 3079:
...#.###..
#......#..
#.......##
#...#..###
#.......#.
......#.#.
#........#
.#.#...###
..#.#....#
...#...#.#

Tile 1663:
##.##..###
#.....##.#
......#.##
#........#
..#.#.....
....#..#.#
#.#.#..#.#
#.......#.
..#......#
#.#..#....

Tile 1823:
.###...###
#.#.#..##.
..........
.........#
###....#..
..........
##....#.##
#.......##
..#..#...#
......####

Tile 3823:
....#..#..
..#.#..#.#
###.#.##.#
..##....#.
#.........
#....#...#
#.......##
#.#...##..
..#....#..
..#....##.

Tile 1901:
#.#.#....#
..#....#.#
...#..#.#.
.#..#..###
....####..
......#...
#....#....
..#....#..
#......#..
######.#..

Tile 3347:
#.#.....#.
#..#..#...
#.#.......
#..#.#....
...#......
#.........
##.#.....#
#........#
#....#...#
#.#.##.###

Tile 1873:
..###.#.##
.#.#....#.
#........#
..#..#...#
##.....#..
#........#
#.........
.#........
#.#..#.#.#
.##.#...##

Tile 2053:
#.#.#.#..#
#...###..#
##.##.##.#
....##.#.#
#.###....#
#.....#..#
#..##.####
....#..#..
#.........
#..#.#..#.

Tile 2659:
.#....##.#
#.#......#
#..#......
.#.###.#.#
..........
#........#
.......#.#
....#....#
#........#
##..##.#..

Tile 2503:
.#..####.#
#.##......
..#....###
..#..#.###
...##...##
..#.....#.
..........
##.#......
#.#.......
#...#..#.#

Tile 3881:
##.###.###
#......#..
#...#....#
..#.#....#
#..#..#..#
#..#.....#
...#..##.#
#.#.......
#..##....#
...#.##...

Tile 1973:
..#.###.#.
#.##....##
#.......##
##......##
#.........
#.#..#....
.#....###.
..#.#..#..
......#..#
#..#.....#

Tile 3329:
.#.#.###.#
..#.#.....
.#.......#
#..#.##.##
#.##..####
..#.##..##
....#.....
#...#.#.#.
...#.#...#
.#...##..#

Tile 3331:
#......###
#......#.#
#.#.#.#..#
........#.
.##.####..
#..#..#..#
.#.......#
......#.##
......#.#.
.##...#.#.

Tile 1307:
##.#.#..#.
.........#
.#....##.#
#.........
#.........
#....#.#..
........##
......##..
..#.##...#
..##...##.

Tile 2543:
.#.#.##.##
#........#
..##......
#.........
##...#...#
.###..##.#
.##......#
.#........
.....#.#..
...######.

Tile 2003:
#.#..#.#.#
.....#....
#.#.#.....
####.#..##
..###....#
....#.#...
#.####...#
.##...#.##
#.#.#..#..
...#.....#

Tile 3301:
##....##.#
.....#...#
#........#
..........
###.##.#..
.....#...#
#.#......#
....##...#
#........#
.#.#...#.#

Tile 2297:
#..#.##..#
...#.#.##.
..###..#..
##..#.....
####..#..#
..#.#..#..
.....#...#
#...#.....
#.....#..#
##....#...

Tile 2311:
##.....#.#
##........
#........#
#...##....
#......#..
.........#
.........#
#..#.#....
.....#...#
###.#..##.

Tile 1361:
.#.##.#..#
#.#..#...#
#....###..
..###.#...
#..#.....#
#..#...##.
#.#.....#.
.......#.#
##.##.....
#.###.#..#

Tile 1481:
.####.#.##
..........
.........#
###.#.#...
##....##.#
..#...#.##
..##.#.#..
#.#.....##
.......#..
....###...

Tile 1153:
.##.##..##
###......#
#....##...
......#.#.
#....#....
.....##..#
.....#...#
#.........
#...#....#
##..#.#...

Tile 2153:
#.###.#..#
..#.##....
..##....#.
##...#...#
#...#.....
........#.
#..##...#.
..#.......
#...##.#..
#.#.#.#...

Tile 2377:
.##..##.#.
...##..#.#
#.#.#.....
#.##......
#.....#..#
#...#....#
...##....#
...###....
.#.##...##
.###.##...

Tile 3863:
.##.###.##
.......#.#
#........#
##.#.#...#
##...#...#
#...##....
#..#..#.##
.....#####
##.#..###.
....###...

Tile 1163:
##..######
#........#
.#.#...###
..#..#...#
##..#...##
#.#.......
#.#..#....
#..#.#....
###..#...#
.#####.###

Tile 2207:
.#..#.#.##
##.....#.#
#..#.....#
#..#....##
.........#
...#.....#
#...#..#..
..#.....##
.....#....
#.##.....#

Tile 1201:
#.##.##..#
#.#.......
#..#.....#
.###...#..
#.#......#
........##
.........#
.##....#.#
..##.#...#
.......###

Tile 1619:
#.....#.#.
...#.##..#
#.....#...
#...#.....
#..#...#.#
#..##.#...
.#...#.#..
#......##.
#.........
#.##...###

Tile 3389:
...#..##..
#........#
#...#.....
#.#....#.#
###....#.#
#.#....###
#..##..#.#
.##.#.#..#
#...###...
#...#....#

Tile 3359:
.###..##..
#........#
###...#.#.
........##
....#..#.#
.#.#......
#........#
.......#.#
.#.....#..
##.###....
";
        private const string test = @"Tile 2311:
..##.#..#.
##..#.....
#...##..#.
####.#...#
##.##.###.
##...#.###
.#.#.#..##
..#....#..
###...#.#.
..###..###

Tile 1951:
#.##...##.
#.####...#
.....#..##
#...######
.##.#....#
.###.#####
###.##.##.
.###....#.
..#.#..#.#
#...##.#..

Tile 1171:
####...##.
#..##.#..#
##.#..#.#.
.###.####.
..###.####
.##....##.
.#...####.
#.##.####.
####..#...
.....##...

Tile 1427:
###.##.#..
.#..#.##..
.#.##.#..#
#.#.#.##.#
....#...##
...##..##.
...#.#####
.#.####.#.
..#..###.#
..##.#..#.

Tile 1489:
##.#.#....
..##...#..
.##..##...
..#...#...
#####...#.
#..#.#.#.#
...#.#.#..
##.#...##.
..##.##.##
###.##.#..

Tile 2473:
#....####.
#..#.##...
#.##..#...
######.#.#
.#...#.#.#
.#########
.###.#..#.
########.#
##...##.#.
..###.#.#.

Tile 2971:
..#.#....#
#...###...
#.#.###...
##.##..#..
.#####..##
.#..####.#
#..#.#..#.
..####.###
..#.#.###.
...#.#.#.#

Tile 2729:
...#.#.#.#
####.#....
..#.#.....
....#..#.#
.##..##.#.
.#.####...
####.#.#..
##.####...
##..#.##..
#.##...##.

Tile 3079:
#.#.#####.
.#..######
..#.......
######....
####.#..#.
.#...#.##.
#.#####.##
..#.###...
..#.......
..#.###...";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            exo2();
        }

         static void OutputImage(string[] tile)
        {
            foreach (var s in tile)
            {
                Console.WriteLine(s);
            }
        }

         static bool AreEqual(string[] a, string[] b)
         {
             if (a.Length != b.Length)
             {
                 throw new Exception();
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

         static string[] Rotate(string[] tile, int nb)
         {
             var cote = tile.Length;
             var res = new List<string>(tile.Length);
             for (; nb > 0; nb--)
             {
                 for (int i = 0; i < cote; i++)
                 {
                     var chars = new char[cote];
                     for (int j = 0; j < chars.Length; j++) {
                         chars[j] = tile[j][cote -1 -i];
                     }

                     res.Add(new string(chars));
                 }

                 tile = res.ToArray();
                 res.Clear();
             }


             return tile;
         }
         static string[] FlipHorizontal(string[] tile) {
             return tile.Reverse().ToArray();
         }

         static string[] FlipVertical(string[] tile) {
             var cote = tile.Length;
             var res = new List<string>();
             for (int i = 0; i < cote; i++)
             {
                 var chars = new char[cote];
                 for (int j = 0; j < chars.Length; j++) {
                     chars[j] = tile[i][cote-1-j];
                 }

                 res.Add(new string(chars));
             }


             return res.ToArray();
         }

         static string[] expected1951 = @"
#...##.#..
..#.#..#.#
.###....#.
###.##.##.
.###.#####
.##.#....#
#...######
.....#..##
#.####...#
#.##...##.".Split( Environment.NewLine,StringSplitOptions.RemoveEmptyEntries);

         static string[] expected3079 = @"
#.#.#####.
.#..######
..#.......
######....
####.#..#.
.#...#.##.
#.#####.##
..#.###...
..#.......
..#.###...".Split( Environment.NewLine,StringSplitOptions.RemoveEmptyEntries);
         static string[] expected2971 = @"
...#.#.#.#
..#.#.###.
..####.###
#..#.#..#.
.#..####.#
.#####..##
##.##..#..
#.#.###...
#...###...
..#.#....#".Split( Environment.NewLine,StringSplitOptions.RemoveEmptyEntries);

         static string[] expected1171 = @"
.##...####
#..#.##..#
.#.#..#.##
.####.###.
####.###..
.##....##.
.####...#.
.####.##.#
...#..####
...##.....".Split( Environment.NewLine,StringSplitOptions.RemoveEmptyEntries);
         static string[] expected2311 = @"
..###..###
###...#.#.
..#....#..
.#.#.#..##
##...#.###
##.##.###.
####.#...#
#...##..#.
##..#.....
..##.#..#.".Split( Environment.NewLine,StringSplitOptions.RemoveEmptyEntries);
         static string[] expected2729 = @"
#.##...##.
##..#.##..
##.####...
####.#.#..
.#.####...
.##..##.#.
....#..#.#
..#.#.....
####.#....
...#.#.#.#".Split( Environment.NewLine,StringSplitOptions.RemoveEmptyEntries);


         public class TileCompo : IEquatable<TileCompo>
         {
             public TileCompo(int id, int rotate, bool vFlip, bool hFlip, string[] content)
             {
                 Id = id;
                 Rotate = rotate;
                 VFlip = vFlip;
                 HFlip = hFlip;
                 Content = content;
                 var left = new char[Content.Length];
                 for (int i = 0; i < left.Length; i++)
                 {
                     left[i] = Content[i][0];
                 }
                 LeftEdge = new string( left);

                 var right = new char[Content.Length];
                 for (int i = 0; i < left.Length; i++)
                 {
                     right[i] = Content[i][Content.Length-1];
                 }
                 RightEdge = new string( right);

             }

             public int Id { get; }

             public int Rotate { get; }

             public bool VFlip { get; }

             public bool HFlip { get; }

             public bool Equals(TileCompo other)
             {
                 if (ReferenceEquals(null, other)) return false;
                 if (ReferenceEquals(this, other)) return true;
                 return Id == other.Id && Rotate == other.Rotate && VFlip == other.VFlip && HFlip == other.HFlip;
             }

             public override bool Equals(object obj)
             {
                 if (ReferenceEquals(null, obj)) return false;
                 if (ReferenceEquals(this, obj)) return true;
                 if (obj.GetType() != this.GetType()) return false;
                 return Equals((TileCompo) obj);
             }

             public override int GetHashCode()
             {
                 unchecked
                 {
                     var hashCode = Id;
                     hashCode = (hashCode * 397) ^ Rotate;
                     hashCode = (hashCode * 397) ^ VFlip.GetHashCode();
                     hashCode = (hashCode * 397) ^ HFlip.GetHashCode();
                     return hashCode;
                 }
             }

             public string[] Content { get; }

             public string TopEdge => Content[0];
             public string LeftEdge { get; }
             public string RightEdge { get; }
             public string BottomEdge => Content[^1];
         }
         private static void exo1()
        {
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var regexHeader = new Regex("^Tile (?<Id>[0-9]+):");

            int currentTile = -1;
            var tiles = new Dictionary<int, string[]>();
            List<string> current = new List<string>();
            foreach (var line in lines)
            {
                var match = regexHeader.Match(line);
                if (match.Success)
                {
                    if (currentTile != -1)
                    {
                        tiles[currentTile] = current.ToArray();
                    }
                    currentTile = Int32.Parse(match.Groups["Id"].Value);
                    current.Clear();
                    continue;
                }
                current.Add(line);
            }
            tiles[currentTile] = current.ToArray();

            bool HasMatch(string[] original, string[] expected)
            {
                for (int r = 0; r < 4; r++)
                {
                    var rotated = Rotate(original, r);
                    if (AreEqual(rotated, expected))
                    {
                        Console.WriteLine($"found for rotating {r} and no flipping");
                        return true;
                    }
                    if (AreEqual(FlipHorizontal(rotated), expected))
                    {
                        Console.WriteLine($"found for rotating {r} and horizontal flipping");
                        return true;
                    }
                    if (AreEqual(FlipVertical(rotated), expected))
                    {
                        Console.WriteLine($"found for rotating {r} and vertical flipping");
                        return true;
                    }
                }

                return false;
            }

           /* if (!HasMatch(tiles[1951], expected1951))
            {
                Console.WriteLine("not found for 1951");
            }

            if (!HasMatch(tiles[1171], expected1171))
            {
                Console.WriteLine("not found for 1171");
            }
            if (!HasMatch(tiles[2971], expected2971))
            {
                Console.WriteLine("not found for 2971");
            }
            if (!HasMatch(tiles[3079], expected3079))
            {
                Console.WriteLine("not found for 3079");
            }

            if (!HasMatch(tiles[2311], expected2311))
            {
                Console.WriteLine("not found for 2311");
            }
            if (!HasMatch(tiles[2729], expected2729))
            {
                Console.WriteLine("not found for 2729");
            }*/


            var byTopEdge = new Dictionary<string, List<TileCompo>>();
            var byLeftEdge = new Dictionary<string, List<TileCompo>>();
            var byRightEdge = new Dictionary<string, List<TileCompo>>();
            var byBottomEdge = new Dictionary<string, List<TileCompo>>();
            var allCompos = new List<TileCompo>();

            void Index(TileCompo tile)
            {
                allCompos.Add(tile);
                if (!byTopEdge.TryGetValue(tile.TopEdge, out var l))
                {
                    l = new List<TileCompo>();
                    byTopEdge[tile.TopEdge] = l;
                }
                l.Add( tile);
                if (!byBottomEdge.TryGetValue(tile.BottomEdge, out l))
                {
                    l = new List<TileCompo>();
                    byBottomEdge[tile.BottomEdge] = l;
                }
                l.Add( tile);

                if (!byLeftEdge.TryGetValue(tile.LeftEdge, out l))
                {
                    l = new List<TileCompo>();
                    byLeftEdge[tile.LeftEdge] = l;
                }
                l.Add( tile);

                if (!byRightEdge.TryGetValue(tile.RightEdge, out l))
                {
                    l = new List<TileCompo>();
                    byRightEdge[tile.RightEdge] = l;
                }
                l.Add( tile);
            }
            foreach (var kv in tiles)
            {
                for (int r = 0; r < 4; r++)
                {
                    var rotated = Rotate(kv.Value, r);
                    Index( new TileCompo(kv.Key, r, false, false, rotated));
                    Index( new TileCompo(kv.Key, r, true, false, FlipVertical(rotated)));
                    Index( new TileCompo(kv.Key, r, false, true, FlipHorizontal(rotated)));
                }
            }

            //search for topleft



            IReadOnlyList<TileCompo> EligibleTopLeft(HashSet<int> notAvailable)
            { var eligibleTopWithoutMatchingAnyBottom = allCompos.Where( v=> !notAvailable.Contains(v.Id)).Where(v =>
                {
                    if (!byBottomEdge.TryGetValue(v.TopEdge, out var l))
                    {
                        return true;
                    }
                    return l.All(t => t.Id == v.Id);
                }).ToArray();

                var eligibleTopLeftWithoutMatchingARight = eligibleTopWithoutMatchingAnyBottom.Where(v =>
                {
                    if (!byRightEdge.TryGetValue(v.LeftEdge, out var l))
                    {
                        return true;
                    }
                    return l.All(t => t.Id == v.Id);
                });
                return eligibleTopLeftWithoutMatchingARight.ToArray();
            }
            IReadOnlyList<TileCompo> EligibleTopRight(HashSet<int> notAvailable)
            { var eligibleTopWithoutMatchingAnyBottom = allCompos.Where( v=> !notAvailable.Contains(v.Id)).Where(v =>
                {
                    if (!byBottomEdge.TryGetValue(v.TopEdge, out var l))
                    {
                        return true;
                    }
                    return l.All(t => t.Id == v.Id);
                }).ToArray();


                var eligibleTopRightWithoutMatchingALeft = eligibleTopWithoutMatchingAnyBottom.Where(v =>
                {
                    if (!byLeftEdge.TryGetValue(v.RightEdge, out var l))
                    {
                        return true;
                    }
                    return l.All(t => t.Id == v.Id);
                });
                return eligibleTopRightWithoutMatchingALeft.ToArray();
            }

            IReadOnlyList<TileCompo> EligibleBottomLeft(HashSet<int> notAvailable)
            {
                var eligibleBottomWithoutMatchingAnyTop = allCompos.Where( v=> !notAvailable.Contains(v.Id)).Where(v =>
                {
                    if (!byTopEdge.TryGetValue(v.BottomEdge, out var l))
                    {
                        return true;
                    }
                    return l.All(t => t.Id == v.Id);
                }).ToArray();


                var eligibleBottomLeftWithoutMatchingARight = eligibleBottomWithoutMatchingAnyTop.Where(v =>
                {
                    if (!byRightEdge.TryGetValue(v.LeftEdge, out var l))
                    {
                        return true;
                    }
                    return l.All(t => t.Id == v.Id);
                });
                return eligibleBottomLeftWithoutMatchingARight.ToArray();
            }
            IReadOnlyList<TileCompo> EligibleBottomRight(HashSet<int> notAvailable)
            {
                var eligibleBottomWithoutMatchingAnyTop = allCompos.Where( v=> !notAvailable.Contains(v.Id)).Where(v =>
                {
                    if (!byTopEdge.TryGetValue(v.BottomEdge, out var l))
                    {
                        return true;
                    }
                    return l.All(t => t.Id == v.Id);
                }).ToArray();


                var eligibleBottomRightWithoutMatchingALeft = eligibleBottomWithoutMatchingAnyTop.Where(v =>
                {
                    if (!byLeftEdge.TryGetValue(v.RightEdge, out var l))
                    {
                        return true;
                    }
                    return l.All(t => t.Id == v.Id);
                });
                return eligibleBottomRightWithoutMatchingALeft.ToArray();
            }


            Console.WriteLine(string.Join(",", EligibleTopLeft(new HashSet<int>()).Select(t => t.Id)));
            Console.WriteLine(string.Join(",", EligibleBottomLeft(new HashSet<int>()).Select(t => t.Id)));
            Console.WriteLine(string.Join(",", EligibleTopRight(new HashSet<int>()).Select(t => t.Id)));
            Console.WriteLine(string.Join(",", EligibleBottomRight(new HashSet<int>()).Select(t => t.Id)));

            var currentSelection = new HashSet<int>();
            foreach (var tl in EligibleTopLeft(currentSelection))
            {
                currentSelection.Add(tl.Id);
                foreach (var tr in EligibleTopRight(currentSelection))
                {
                    currentSelection.Add(tr.Id);
                    foreach (var br in EligibleBottomRight(currentSelection))
                    {
                        currentSelection.Add(br.Id);
                        foreach (var bl in EligibleBottomLeft(currentSelection))
                        {
                            currentSelection.Add(bl.Id);
                           //Console.WriteLine(string.Join(",", currentSelection));
                           long mul = 1;
                           foreach (var tmp in currentSelection)
                           {
                               mul *= tmp;
                           }
                           Console.WriteLine(mul);
                           //Environment.Exit(0);
                           currentSelection.Remove(bl.Id);
                        }
                        currentSelection.Remove(br.Id);

                    }
                    currentSelection.Remove(tr.Id);

                }
                currentSelection.Remove(tl.Id);

            }



        }
         private static void exo2()
        {
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var regexHeader = new Regex("^Tile (?<Id>[0-9]+):");

            int currentTile = -1;
            var tiles = new Dictionary<int, string[]>();
            List<string> current = new List<string>();
            foreach (var line in lines)
            {
                var match = regexHeader.Match(line);
                if (match.Success)
                {
                    if (currentTile != -1)
                    {
                        tiles[currentTile] = current.ToArray();
                    }
                    currentTile = Int32.Parse(match.Groups["Id"].Value);
                    current.Clear();
                    continue;
                }
                current.Add(line);
            }
            tiles[currentTile] = current.ToArray();

            int nbTileSide = (int) Math.Sqrt(tiles.Count);

            int tileWidth = tiles.First().Value.Length;
            var byTopEdge = new Dictionary<string, List<TileCompo>>();
            var byLeftEdge = new Dictionary<string, List<TileCompo>>();
            var byRightEdge = new Dictionary<string, List<TileCompo>>();
            var byBottomEdge = new Dictionary<string, List<TileCompo>>();
            var allCompos = new List<TileCompo>();

            void Index(TileCompo tile)
            {
                allCompos.Add(tile);
                if (!byTopEdge.TryGetValue(tile.TopEdge, out var l))
                {
                    l = new List<TileCompo>();
                    byTopEdge[tile.TopEdge] = l;
                }
                l.Add( tile);
                if (!byBottomEdge.TryGetValue(tile.BottomEdge, out l))
                {
                    l = new List<TileCompo>();
                    byBottomEdge[tile.BottomEdge] = l;
                }
                l.Add( tile);

                if (!byLeftEdge.TryGetValue(tile.LeftEdge, out l))
                {
                    l = new List<TileCompo>();
                    byLeftEdge[tile.LeftEdge] = l;
                }
                l.Add( tile);

                if (!byRightEdge.TryGetValue(tile.RightEdge, out l))
                {
                    l = new List<TileCompo>();
                    byRightEdge[tile.RightEdge] = l;
                }
                l.Add( tile);
            }
            foreach (var kv in tiles)
            {
                List<TileCompo> tileVariants = new List<TileCompo>();

                void AddIfNotPresent(TileCompo cv)
                {
                    if (tileVariants.Any(v => AreEqual(v.Content, cv.Content)))
                    {
                        return;
                    }
                    tileVariants.Add(cv);
                }
                for (int r = 0; r < 4; r++)
                {
                    var rotated = Rotate(kv.Value, r);
                    AddIfNotPresent( new TileCompo(kv.Key, r, false, false, rotated));
                    AddIfNotPresent( new TileCompo(kv.Key, r, true, false, FlipVertical(rotated)));
                    AddIfNotPresent( new TileCompo(kv.Key, r, false, true, FlipHorizontal(rotated)));
                }

                foreach (var tileVariant in tileVariants)
                {
                    Index(tileVariant);
                }
            }

            Console.WriteLine($"Total combis: {allCompos.Count}");

            //search for topleft

            var composOnTop = allCompos.Where(v =>
            {
                if (!byBottomEdge.TryGetValue(v.TopEdge, out var l))
                {
                    return true;
                }

                return l.All(t => t.Id == v.Id);
            }).ToHashSet();

            var composOnBottom = allCompos.Where(v =>
            {
                if (!byTopEdge.TryGetValue(v.BottomEdge, out var l))
                {
                    return true;
                }
                return l.All(t => t.Id == v.Id);
            }).ToArray();
            
            var composOnRight = allCompos.Where(v =>
            {
                if (!byLeftEdge.TryGetValue(v.RightEdge, out var l))
                {
                    return true;
                }
                return l.All(t => t.Id == v.Id);
            }).ToArray();
            
            var composOnLeft = allCompos.Where(v =>
            {
                if (!byRightEdge.TryGetValue(v.LeftEdge, out var l))
                {
                    return true;
                }
                return l.All(t => t.Id == v.Id);
            }).ToArray();


            IReadOnlyList<TileCompo> EligibleTopLeft(HashSet<int> notAvailable)
            { 
               return composOnTop.Where( v=> !notAvailable.Contains(v.Id) && composOnLeft.Contains(v)).ToArray();
            }
            IReadOnlyList<TileCompo> EligibleTopRight(HashSet<int> notAvailable)
            { 
                return composOnTop.Where( v=> !notAvailable.Contains(v.Id) && composOnRight.Contains(v)).ToArray();
            }

            IReadOnlyList<TileCompo> EligibleBottomLeft(HashSet<int> notAvailable)
            {
                return composOnBottom.Where( v=> !notAvailable.Contains(v.Id) && composOnLeft.Contains(v)).ToArray();
            }
            IReadOnlyList<TileCompo> EligibleBottomRight(HashSet<int> notAvailable)
            {
                return composOnBottom.Where( v=> !notAvailable.Contains(v.Id) && composOnRight.Contains(v)).ToArray();
            }


            Console.WriteLine(string.Join(",", EligibleTopLeft(new HashSet<int>()).Select(t => t.Id)));
            Console.WriteLine(string.Join(",", EligibleBottomLeft(new HashSet<int>()).Select(t => t.Id)));
            Console.WriteLine(string.Join(",", EligibleTopRight(new HashSet<int>()).Select(t => t.Id)));
            Console.WriteLine(string.Join(",", EligibleBottomRight(new HashSet<int>()).Select(t => t.Id)));

            var currentSelection = new HashSet<int>();
            var possibleEdgesCombis = new List<( TileCompo tl, TileCompo tr, TileCompo br, TileCompo bl)>();
            foreach (var tl in EligibleTopLeft(currentSelection))
            {
                currentSelection.Add(tl.Id);
                foreach (var tr in EligibleTopRight(currentSelection))
                {
                    currentSelection.Add(tr.Id);
                    foreach (var br in EligibleBottomRight(currentSelection))
                    {
                        currentSelection.Add(br.Id);
                        foreach (var bl in EligibleBottomLeft(currentSelection))
                        {
                            currentSelection.Add(bl.Id);
                           //Console.WriteLine(string.Join(",", currentSelection));
                           long mul = 1;
                           foreach (var tmp in currentSelection)
                           {
                               mul *= tmp;
                           }
                           Console.WriteLine(mul);
                           //Environment.Exit(0);
                           possibleEdgesCombis.Add((tl, tr, br, bl));
                           currentSelection.Remove(bl.Id);
                        }
                        currentSelection.Remove(br.Id);

                    }
                    currentSelection.Remove(tr.Id);

                }
                currentSelection.Remove(tl.Id);

            }

            var tileCompos = Enumerable.Range(0,nbTileSide).Select( i=> new TileCompo[nbTileSide]).ToArray();
            currentSelection.Clear();

            Console.WriteLine($"combis:{possibleEdgesCombis.Count}");

            //var notSelected = new HashSet<TileCompo>();

            bool CanFill(int i, int j) {
                if (j == nbTileSide)
                {
                    j = 0;
                    i++;
                }
                //Console.WriteLine($"{i} / {j}");

                if (i >= nbTileSide) {//alrady filled
                    return true;
                }
               
                if (tileCompos[i][j] != null)
                {
                    return CanFill(i , j + 1);
                }

                TileCompo[] eligible = allCompos.Where(v => !currentSelection.Contains(v.Id)).ToArray();
                bool checkTop = false;
                bool checkBottom = false;
                bool checkLeft = false;
                bool checkRight = false;

                if (i == 0)
                {
                    eligible = eligible.Where(v => composOnTop.Contains(v)).ToArray();
                    checkLeft = true;
                    if (j == nbTileSide - 2) {
                        checkRight = true;
                    }
                }
                else if (i == nbTileSide - 1) {
                     eligible = eligible.Where(v => composOnBottom.Contains(v)).ToArray();
                     checkTop = true;
                     checkLeft = true;
                     if (j == nbTileSide - 2) {
                         checkRight = true;
                     }
                }
                else if (j == 0)
                {
                    eligible = eligible.Where(v => composOnLeft.Contains(v)).ToArray();
                    checkTop = true;
                    if (i == nbTileSide - 2) {
                        checkBottom = true;
                    }
                }
                else if (j == nbTileSide - 1) {
                    eligible = eligible.Where(v => composOnRight.Contains(v)).ToArray();
                    checkTop = true;
                    checkLeft = true;
                    if (i == nbTileSide - 2) {
                        checkBottom = true;
                    }
                }
                else
                {
                    checkLeft = true;
                    checkTop = true;
                }
                if (eligible.Length == 0) {
                    return false;
                }
                if (checkTop) {
                    eligible =  eligible.Where(t => t.TopEdge == tileCompos[i-1][j].BottomEdge).ToArray();
                }
                if (eligible.Length == 0) {
                    return false;
                }
                
                if (checkBottom) {
                    eligible =  eligible.Where(t => t.BottomEdge == tileCompos[i+1][j].TopEdge).ToArray();
                }
                if (eligible.Length == 0) {
                    return false;
                }

                if (checkLeft) {
                    eligible =  eligible.Where(t => t.LeftEdge == tileCompos[i][j-1].RightEdge).ToArray();
                }
                if (eligible.Length == 0) {
                    return false;
                }

                if (checkRight) {
                    eligible =  eligible.Where(t => t.RightEdge == tileCompos[i][j+1].LeftEdge).ToArray();
                }
                if (eligible.Length == 0) {
                    return false;
                }

                if (eligible.Length > 3)
                {
                    Console.WriteLine($"Nb candidate: {eligible.Length}");
                }
                foreach (var candidate in eligible)
                {
                    currentSelection.Add(candidate.Id);
                    //notSelected.Remove(candidate);
                    tileCompos[i][j] = candidate;
                    if (CanFill(i, j + 1)) {
                        return true;
                    }
                    tileCompos[i][j] = null;
                    currentSelection.Remove(candidate.Id);
                    //notSelected.Add(candidate);

                }
                return false;
            }
            
            

            foreach (var tuple in possibleEdgesCombis)
            {
                tileCompos[0][0] = tuple.tl;
                tileCompos[0][nbTileSide-1] = tuple.tr;
                tileCompos[nbTileSide-1][nbTileSide-1] = tuple.br;
                tileCompos[nbTileSide-1][0] = tuple.bl;
                currentSelection.Add(tuple.tl.Id);
                currentSelection.Add(tuple.tr.Id);
                currentSelection.Add(tuple.bl.Id);
                currentSelection.Add(tuple.br.Id);
                Console.WriteLine(string.Join(",", currentSelection));
                if (CanFill(0, 1))
                {
                    Console.WriteLine("found");
                    break;
                }
                else
                {
                    Console.WriteLine("not found");
                }

            }

            int finalImageWidth = nbTileSide * (tileWidth - 2);
            var imageb = new List<string>();

            for (int i = 0; i < nbTileSide; i++)
            {
                
                for (int k = 1; k < tileWidth - 1; k++)
                {
                    var aLine = new List<char>(finalImageWidth);
                    for (int j = 0; j < nbTileSide; j++)
                    {

                        aLine.AddRange(tileCompos[i][j].Content[k].Substring(1, tileWidth - 2));
                    }
                    imageb.Add(new string(aLine.ToArray()));

                }

            }

            var finalImage = imageb.ToArray();



            ( int x, int y)[] monsterPat = MonsterPat();
            void OuputFinalImage(string[] img)
            {
                int nbMonster = 0;
                int nbHash = 0;
                for (int i = 0; i < img.Length; i++) {
                    for (int j = 0; j < img[i].Length; j++) {
                        if (HasMonster(img, i, j, monsterPat))
                        {
                            nbMonster++;
                            Console.WriteLine($"Has monster on {i} / {j}");
                        }

                        if (HasHash(img, i, j))
                        {
                            nbHash++;
                        }
                        
                    }
                    
                }


                if (nbMonster > 0)
                {
                    OutputImage(img);
                    Console.WriteLine($"Total Hash: {nbHash} - ( {nbMonster} * 15) = {nbHash-nbMonster*15}");

                }
                Console.WriteLine();
            }
            
            
            for( int r = 0;r<4;r++)
            {
                var rotated = Rotate(finalImage, r);
                OuputFinalImage(rotated);
                OuputFinalImage(FlipVertical(rotated));
                OuputFinalImage(FlipHorizontal(rotated));
            }
        }

         static bool HasMonster(string[] img, int i, int j,( int x, int y)[] monsterPat )
         {
             foreach (var (x, y) in monsterPat)
             {
                 if (!HasHash(img,i + x, j + y))
                 {
                     return false;
                 }
             }

             return true;
         }
         static bool HasHash(string[] img, int i, int j )
         {
             if (i < 0 || i >= img.Length || j < 0 || j >= img.Length || img[i][j] != '#')
             {
                 return false;
             }

             return true;
         }

         static ( int x, int y)[] MonsterPat()
         {
             var lines = monsterPattern.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
             var res = new List<(int, int)>(14);
             for (int i = 0; i < lines.Length; i++)
             {
                 for (int j = 0; j < lines[i].Length; j++)
                 {
                     if (lines[i][j] == '#')
                     {
                         res.Add((i,j));
                     }
                 }
             }

             return res.ToArray();
         }

         private const string monsterPattern = @"
                  # 
#    ##    ##    ###
 #  #  #  #  #  #   ";
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            exo2();
        }

        private const string input = @"seweswweswnwseeeesenwneseeseee
wwswwwnewnenwsweneswwwwwseww
eneneeesweeneneeeswnene
nenwswwsenenwnwnenenenenwnesenwnenenenenene
eneeenwneseneeseseseswsewswseswsenwe
eeneneenenwneseneesweneene
wwwwnenenwwwwwswsww
wnwnwenwnwnwnwnenwwwnwnwnwseswnwnenw
sewsweswnwnweswswnwswe
swenwnwnenwnwnweneeswsenwswneswneswsew
seswsweseswneswswneswnwsenwswsenwswsesenw
swsenesewswnenwnewseswseenwnweseseseew
senwseswseswnwswswswseseeseseseswswesw
eeeeneeenweneeeeneesweenewwne
sewnwnwnwnwnwnwnwswnwwnenwnwnwnwnwnwnwe
swenenwneenwwnwwenwwnwwenwseswswnwe
seswseseeseswnwswswse
nenenenwswnenenenenene
wnwseswwwnwwswwswswseswnewwswseww
seeswwnenewwnwswsenewwswwwswswsww
wnesewnwwnwnenwwewsewnwneeseseswwnw
nesewsesesesesesewsweseseseseewnwsw
swswswsewseeswswswswswneswswwsewsesenesw
nesewswwwswswwwwswswwsewnwswnesew
seseesweswnweeswseenwnenweenwwe
swswnweswnwswswswseswseswswswsesesww
nwenenwsenenwnwnenenwneneneneneneneswnesw
eenwewnwsesweesesenwnewnwnwsenesw
wswswswneseseseswse
nwnwnwnwnwenwnwnwwnwsenwnwnenwnwnenew
swsesesewseeseseseseneeseenwesesesese
neseneswsenewsesenwwwswswsenweswnee
swswnwwswsweswswswwswswwwneswwswsw
swswswnewwswswnesweswwswwswnwwwww
neeesewnwnenweswswnwswsenenenwsenwsene
nwnwswnwswenwwwnwwenweenwwnwnww
neswswnwswsenwwswswsweswseswsw
neweeneneseeweeeseeeneswnweene
swenwneswsewswneswwnwswnwswswswswswwe
nenwswneswnenwsenwnenwsew
nwnwnwnenwnwswwnwnwnwneswsenenwnenenwnwnw
wseswsewnewseswswnweseseneswswnenenwse
neeeeeswneneneneneneeneeswnwnwneee
eneswneenwnenwsewswseeeenwseseew
swswswsewseeswenwseenwseswswswseswnwswse
seseeseewseseeseswsesenenwseseseeenee
neswswswswswswnwwswswwswswsewswnesww
wsenenwneneneswnwnwnenenenwnenwnenenwnw
wnwsenesenwwswsewsweenwwwwwswsw
swnwneseswseswnwswsewseswswseswswsweeswsw
seswswswnwneswswwnwswseswnwseswswswenesw
nwnwnwnwnwsenwnwnwwenwnw
nweeeeeeeeeeeswseenewsewne
neneneneseneeesenewwnwenewneneswne
nwwnwnwnwnwnwnwwwwsenwewnw
nwswnenenwneneseneneseenwnwnwnenwne
seneneneneeeenwsenenwsweeneeenenene
wnwwnwwnwswwswwnwnwnenwwwnwnwne
swwenewswwweewswswwswnwswswnwsw
newneswsenenwsenenwswesenwnwnwnenwnenese
neneswneweneneneeneneeeeeneesenw
seweseswsewsenwesenenwsese
newewseneesweswseneswnenewwsenwe
nesenwsewnwnwseswnwswsenenwewwnwsene
nwnewwsenewwnesewwse
swswesweneneneswenwswnenenesenewnee
swnwseenwnewneneseewne
nwwwnwnwenwnwwnwnwnwnw
eseseneswneseswsesenwwwsewnesesesee
nenwnwnwnwnwnwnwnwnwnenenwnwnesewsenesw
nenenenenenwneneswswnenenwwnwneneneenw
seswseswneewneswwseseswseseswswseswswse
wsewneseeseseseseneswsesesenesese
sweswswwswswswswswswswwneesweeww
neswswnwswswswswwswswsweseeswswswewsw
nwneenesenwswenenesenwswnenenewsenene
eweeeeeneeseesenwesweeeeee
wseeenwnweeswnesweeneeenenwseee
esenwseseesenwwseeeeeeeseesee
wwwnewwwswwsewwwewnewwwnwwse
swswseswseswsenwswswnwseswseswesenwese
senwseseseseenwseeseseseseeseswsesese
wewnewwswnwwnewnwswswseewwsww
wswswswswswwswswnwweeswwwwwww
eeenweewenesweeeeeseee
swwswesewswsenewwneswwwswwneeww
nwnwnenenwseneseenenwnenwnenwnenwswnenw
swwswsweeswwswwswwswneswwwnesesesw
nwneswneneneneneenwneneswnenenenenwnenw
nwwwswsewesenwwsweneswnenwseswwsw
sesesesewseneseseseseseesewsewsesesene
nenwneeswswswsewswnwnwwswneswsenew
senenwnwswnwswesewswnwnwnwnweenwneneswse
esewweeeeesenwneeseesweeeene
newwseseeseeseseseseseenwewsesese
seneseeeswweeesewneseseewseene
swseeseseeseswsewnweneswnwenesewnwse
eweneeewesenwneeneenewenesesw
wswnwneseswswnenenenwenenenewneneenw
seeneswsesewseseswnesenwseswswnwsesese
seewesewewsenewneneneswsenwesese
senwnwnwsewnwnwnwswnewnwnwenwnenenwswnwnw
swnwnwnenwwwsenwnenwnwnwnwenwwesewnwnw
seswswneswswswswswswwswneseswswwswswswsw
neseneswnenwwnenenwnwwnesenwnenwnenene
nwseseswswwswsewseswenwnwweeswesese
seneswswswseenweewswnewswwswnwswswne
sesenwswneeenwswseswswneewnenwneswe
ewewwwwwswwnwswwwnwewwww
swnenewesewwwswwsewwnwswwnwnene
wswnwsenwnwswenwnwenwnweswwwneee
weenewswswewnwnweesewnwsweswwsw
eeseeeseeeweeeseneeee
wnwenwnwnwenwnwnwnwnwswweneneswswnee
seseseswsewnwsewseeesenwseseswesese
weweesweeneeneeseeeweeseee
swseneesweenwneswnenwneewwwswswsw
nesewwenesenenwneneeneneneese
esesenewnwnweseseweeeeeeeswsw
nwswwwneswswseeswswnwswswnewsenwswesw
weeeseeseseseesesewnesenweeese
sewsesewnesesesesewneseeenesenwesese
swsesesenesenwsesewseseswseswseseswswse
neswswswwswswswswwswswswswswsw
nwnwnwnwnwnenwnwnwnwsenwnewnenw
seneneenwnwnwneswnwnwnenwnwnwnwnwnwnenw
swnweeeeeeeesew
neseswwnweeeeswseeseeeseeeswene
eeneeeseeneeseeeeewneeenwsw
senwswseesesesesweeenwseee
wwwwswwwsewswswswnewwswneswwsew
eseeneseeseswwseeweeeeneeee
wwnewwwwwwswwswwwewwwnewsew
sewwneeeeeesweeswenesesweneee
nenwnwenwnwswnwnwwswnww
swswseneswswesesenwsesewseswsesesesesenw
seeseseenwweseseseneeseeeeseese
newnenwseswwnwwwwnw
swwnewewwwwwwwwsewwwnwwwnw
swwnwnwnwswenwnwneenw
wnwnwswnenwnwweswweseswwswwewsw
nwenwnwnenwswewswnwnwenwnwnwwnwnenw
esewseseseeeeneseseeeewsenesw
swwwswwnwwnwwweswswsewwswwnesw
senwswnenwnwneenwswnwnwneenwnwnwnenwnww
wwnwwwwwwnewewwwwwsenwswsww
nwnwnwnwnwsewnwnwnwnwnw
swnweseswseseswenwwseneseneswnweswswsw
enenenewseseneseeeneneeneenenwnwne
neneneewwenesenenenenwneneneneneene
neeeneeeneneweeeneee
neseeswswswnwswwswswwswswnwswwswswsw
wwwnenewwnweseseswsenewnwnwnwwse
swwwwsewswswswswswswswwsweneswsw
seneseeseswsesesesesewseseseswsenw
nwwwwnwnwwnwsenwwwwww
wwwwwswnewewseneseswnewswwseewnw
neswnweeswneewwneeeeeneneenenese
neneeneewewsesewnwseeene
seneneneenwnwnwnwnenwnwnenwnwnenwnwswwe
wswswwwseswneswwswwsw
nenwnwesewneneewwwseswwsw
wnewnwwwwwnwnwewwwwswewseww
seeeeseenwsenweswsesesesenwseseee
nenwwsenenwnwnenwnenwnenenesenwnwnwnwnw
wwnwsewwswnewwswewwwwwwsww
seseseeeeseesenwseseseseseese
nweseseseswenesesesesewseseseseseneese
nwswswswwswsweswwsweswswswswswneswsw
wwwsewwwsewwwwwnwwenewnww
nwwnwwwwnwwsesenenwnwwwnwnwwwnw
newnewsewswneenesenenenenenwnesenwe
wnwswswnwwenwnweenwnwewnw
newnenesweneseenenenee
nesweneneneneseewneweeweewswee
wwwwswwwwwwwewww
nwnwsweswwnwnewnwnwnwnenwswwnwneswnw
esenesewswswswswswseswseseswswsw
nwnenenwwnesenenesweneswnenenenesenene
swwewnwwnewwwweswnwsewwnwnenw
swwwneseweseswwswneneswneneseswswnesw
nenwwneneneswnenenenenwnenenenesenw
swswswswseswswnwswseswswsw
swswswsweseswswswwswswswswneswswwsww
neseswseswseswswneneswswsewwswneswswsw
swwswwswwwswnwwwwwwswesww
swswsesewnwswswswseseseswswswne
nwseswswswswswseswseswse
sesewwsesewseesenesenwwseseesesesee
swnwwswswswsweswswwswswswswswswsw
nwnenenwnwnwsenenwwnwsenwseewnwesenww
wwswnwwwwenwwwwwnwsenewewwne
wsenesenwwnesenesenww
eeeeeswnwseseeeseneswenwsewswsee
swwwewwwewwswwwswnw
eeneswnweeswseeenwseeswnwweseee
nenwnwswneenenenwwnenwswneneneneneeenwsw
seseseswneesewwsenwseseesese
newnenenenwneseneenewnenenenesenenenenw
nenwswweseeswsenwsenwsewneswseneswnw
eeneewsenweeeneesewee
nwwnwwsewnwwwwwnwnenwsenweww
neneneswnewnenwneneswnenenenenenenwnesene
seseeseseswseesesenwseseswswsesenwsww
seeswnenwswwnenesenenwnwnwnenenenenene
wneneneswnenenwnwwee
newswwwwsewnwseswneenwwseewnewne
swswwwwswneeswwweseswnew
swnwseeseeewesweneeswenwswwwne
eweseeeeeeeeeenweseeeeenw
wwnwwsenewwwwwwnwnewseswswwsew
neeseseeeesesesesesesesenwsewsesew
nwnenwnenenenenwnwnenenenenenwenenesesw
senenenwnenenenenenewneneneene
senwseswwseswswseseneswswswswsenwseee
nenwwnesenenwseswsenewnenwswnenese
nenwnwnwsenwnwnwwwnwnwwwwnwwnw
seseeswsenwneeeesewwsenesenenwsewse
eeseeesenwseesweeewenwsesesee
eswnwnwwsenwnwnwwnwwne
swswsesenwswseswswswesw
nwwnwwnwnwnwnwnwnwse
newsesenwnwsewsenenewwse
swnwnwwsenwnwnenenwnwnenwnw
swswwnewewwsesenewnwseswswswswswsw
eeeneseeeseseeseeeweseese
neneneneneneseswenweseneweenewnwene
nwnwwnwnwnwnwnwnwwnwnwnwnwnwesenwnenw
senenenewswseeenwswesweeneene
nwnwnwenwnwnwnewsenwnwnenwsenenenwnwwnw
nwswswswseswswnwswswseswesenwswswswseseswsw
senwwnesenwswseseswseseswenwswesesee
weeseeeeseenee
nwnenwnwswnwnwnwnweswnenwswsee
wwwnewwwnwewneswneswnwswwsenwnww
wseswneeseseswenwsesenwnenewse
seneenwswnewneneeeeneeeneneneenenwne
sweneweeseeeseeeneewseee
eswseseenwsesesesewseenenwswnwseeswse
swneswwnwwwwwwseswwswwswswwsene
sesenesewswsesenesesesesesesesesesesese
weneweswewseseeeeneeseeenee
seeseeseenesweseesweeeeswneenwe
weseewnweeeswseseeeswswnewsenene
nenesenenenwnwnenesenenenwnenwwnwnwnenesew
nwweeeeeeeeeeseeseee
neswnenenenwnenenenwnwnwnwnenwne
neneenweeeswwseeswswenweweswnenw
wnwnwnwswewnwwwnewwnewnwwsenwnw
seeswseseswnewnwsesesesesesesesenewnwse
wnewsewewwwnwnwweeswwwnwswnw
seeseeseeeeeeeeeeenwweneew
eeeeseenwsweesenwnweeesenwswee
swwswnwseswswswswswswsweneswswswswswsw
nwnenwwnwwnwenwnwnwsenwnwnwnwwnwnww
swnewneneenewnenwswnwsenewnwneesee
wwwwwsewwwwnwnewnwwnenwseswnw
swsewweweswwwswnwwewwnewwwe
wnwenwswswwwwwwwwwwswewwne
nenenenenenenenenenenesesenenwnenwwnenwe
nwnenwenwenwwnwsenwnwnwwsenwnwnwwnwnw
seswnwnenwenwseswwenesenewneswnwnwnene
enenenwswnwnwnwnenenesenwnwsenwwnwnwnw
swsewwsewseenwnwnewnwwwnwnwnewse
seseswnwswswswswwseswne
nwwnwsewnwnwnwnwnwnwnwnwnwenwnwswnwnwe
swnenenesesenenenenwnenenewnesewneenene
seswsewswseseswseswswswnewneseswseswse
nwsewsenwnwnwwnwnwwswnewnenwwsewwwnw
seeeeseneswnwneenenwnenwneesenwe
wwneeenewseeesesesesweeesesese
swwswswsewseswswneneewneeswnwsesewe
nwneswswswsweswseswswswswseswswswnewswsw
nwnwwsenwwnwnwnwnwwwwnwnwenwsenwww
neenwswnwneenwnwwnwnenwnwswnwswnwnwe
nwswnwnwnwwnwswnwnwnwnwswneewnwnwnwnwenw
swswneseswseeeeeeseseneseesenwsewe
neseesesesewseweeweeneswseeeene
swseeswsesewswswseseeswseswnwsenwswnese
swwswwswsewswwswnwswseswwnenwswsww
nwneewnwnwnwnwwnwnwnwnwseswwnenwnwnwse
nwnwenenwnwnwnwwwenenewneswe
eseeneeneneeseneweenweneeewsw
wswswswsewswswnewweswnewwwswwwsw
newnenenwenenenenwnene
swwnwwswwwswwwenwwwewwwswwsw
neneeneneswwneneenenwseneeneneneeenwne
newnwswsweswseseswnwnwswswswseseswnee
eneeneeneweneneneswnweneesenenene
sweeeswnwneeneneenweeeneesw
neswsenwesesesesweseseweseseeeese
nwseswnwnwswneneenwnwnwwwnenesenenwnenw
sweeeeseeneesweseesenwneesweee
wwswneesewnwseseeeeweswesewsww
sesweswswseeswswsenwswswswwseswneswsesww
swneneneeseneenewnew
sesewsesenwnwesesesewseeeseswsesesese
swseswseswswewswnenwswneenwnwneswne
neneneneneneneneswenenenenwsw
weswwnwwwnwwswswnwnwewweeenwnw
wnwwwwwnwwswwnwnwsewnwwnwwwewe
nwwswwswnwneswsewseeswseseswnewnenwnesw
nwnwnweswsenwsenwswnesenwwnwsenwswee
nwwneseswswweseswseswswnenewseswswnww
eeesweneenwneeeneneswesewneswneene
weeneswswewseeeeeeenwneee
nwnwnwenwnwnwnwwwnwsewsewwwnenwnw
neenenwwneneeswseneswnewnene
enwnwnwnwnwnwnwnwnwenwsenwnwwswnwnwnwnwnw
wnwswseseneseseseswsesesewsenweeseew
swnweswnesenesewseneseseseenweeseew
nwseeeseseeseesesenwswneseseweseesw
wwwswwswneswwwwweww
seswwenwseneewneeneeswneneeswnwnew
nwswseswwwneswswswswwnwseswswesweswsw
sewswwwwswswsenwsenewwwwwwnwsww
nenenenenenwswnenenenenenenene
seseneseseesenwswsewseswswseseseswseseese
swwnesewnwseneswnenesweeeneswewne
nwnwnwwwnwwnwwnwnwswewenwnwnwnwnw
nwnwnwswwnwwsesenwnwwnwsenwenweneswnwnw
seswseeswnwseseswseswseswseseswseseswnw
swswsweswswsenewneswswsenwwswswswswe
sweswswswwwswswwnewwswnewswswnesw
weseseswswseseswsese
wnwwnwwwwwwwewwnwnw
neseeeseeswnwwnesee
nenesewswnesenenenwwnwnenweseeswwenw
seseseneswwsewnwweeeewnesesesesese
seswnewnwsenwswseseswsenwseesesesesesesese
neneneswnenwnwnesenenenenwnenesenesenenene
swneswswnewsenesweswseswwseswswswswsesw
nwnwneswsweeeneeneeeneneesenwnenene
senwnwswnwnweswwnwsenwswnwnesenwswwee
eneseswenwneseswneesenwwneeweewwsw
seewswswswenwnwwwnwnwnwwnwnwwnwne
eneenwnewswnwnewsewseneeswnwenesww
nenesenenenenwnesesenesewnenwnenwwnenese
eenesewsweeeweseweeeseneseee
weneeseesenesesesesesesesewesesee
swswwswwwswwwswnwswwnesweswwneswwsw
neswneseneneewnenenwsenwnenewneneenew
neseeswsweswwseeneenenewwnenwene
eeeneeneeeeweeeeee
nwenwwwwnwwwwwwwnw
nwswnwnwnwnwwnwnwnwnwsenwsewenwnwnwnw
swseneneneswnenenwnenenwneneswnenenenee
nenwnenwsenwnwnwwnwnenwnene
eeneeeeneeeeeeenesw
esweeeweseeeneneeenwseeswnwswswne
nenenenwnesenwnenenwnenenenenene
swnwewswwswnwswwswswnesweswswswwse
wenwneneenesweeneneeeeseneenenwe
nwnewnwnwenwswswnwnenwsenwee
wswnwesenwwswswewneswwweweswwnenw
seweswneeswneswneneeneneneneenewnesee
nenwnwnewneeneeeesweneneswneneswne
nenwenenenenenesweneneneeenenewee
nesenwneneneneneneseneswnwnenenenwnewse
wnwwsesewsewwswwneswneswwnewswww
nwnwsenenwnwnwnwnwwwenenwwwwswwww
neeseeeseseeseeseeesw
neneneswnwneneseneswwneseeneewne
nwswsewwswswewwwwwwwwwnwswsw
swswseseneseesenesenwswsesesesese
eenwwseswwwswsweeswswswswswswsese
eswneswswswswswnewwswswswweswenwe
nwseseswseswswseseseseseswnwseseneswsesw
swseeswenwseeeeseseneseseeeesenee
seeseswwwsesewseseseseseeeenwesee
seswswseseseseseseseeswenwswswswnwsesenese
nwnwwnwsenwwnwnwnwwnwnwnw
nenwnwswnwnweswnwnwenenwneeneswnwnenw
neenewneneneneeneenenwewnesenenene
swswwwnwwnenwswsesewsewww
nwnwnwwneeswswnwesenwnwsewnwwenwnwsww
wsewwwnenwsewwwsewwnewnwwsww
neeneneesweswneeewsweneneenenwenee
nwnewneeneneeseswesewenwneswneewe
wswwnewswswswswneswswswwwswsw
nwwwneneswsenewnwneeeswsweneswenwe
wswswswwswnenewewswswswwnwswseswsewsw
newwnwnwnwnenwnweswnenwnenwnwsenenene
nenwnenenenenenenwwnweneswnenenwsesenew
sesenwnewnwnwnwswsweswnwswwwwsewsee
wnwnwsenwnwnwnwnwenenwseeswnenwswnwsesw
nwnwwnwnwnenwsenwnwswnwenwswnwwenwnw
eeeeseseseeeeeweseneweesee
eswesewenweneeneeseseeseeeee
enenewnenenenenesweswnewnesenenenenenene
swnweeenwnenwnwewneswnewwswwenw
sweswseeesweeeeneeseeeeeneesenw
wnwnwswnwnenwnwnwnwnwneswnweswnwnenenw
swswswswswswwswwnwswsweswswewswwsw
nwenwnewwnwswwnwnwesenwsesenewnwnwnw
wwswwwwwwwwsenw
swwnwsewwnewwnwswnwnewwnwnwnwne
eeeesenweeenenenenweeeeswe
enesweswswewswswseswnwswnw
eswseswnwsenwsewesenenewwwseesenwse
sesewwnewwnewwwewwwnwswnwwww
nenenewnenenenenesenenenenenenenene
nenwnenenwnenwnewnwnenesenenwneswnwnwswne
seseeswnwnwseswsesewseeseseesewesenw
swsenewsewswseneseseeeeseswnweenwse
eswwnwwwewwswne
sewseneewswswseswwseeseswewseswnw
wswwwwwsewwwwwwwwwnwsenew
wnwnenenwswwwwewswsewwwesenwe
wweewnwnwsesenwwewnwwwwwsww
neenwneneeswnwnwneseenesene
nenwsenewnwnenwneswnenenwenwwne
neeseneenwneseenwseenewneswneenesew
nwnwnewnwnwwneswenwnwnwwnwsenwsenwwnw
neneweneseneewwswwnwnwsenwnewnenesene
nwnwnwnwnwnwnwnwnwwswenewnwnwnwenwnesw
weseeneeneeeeseeesesenwnwswswese
senenesewnenenwnenenenewnenenenene
wnwsenwnwwsenwnewwnwenwwwnwnwnww
enwnwnwnwnwsweswnwsenwnwwneneswwnwe
eswnenenwneneweneneeneenenenenwswe
nesesewseswseseeseswsesenesesesesenese
swnwneswnenenwswesweeesweewnweenwsw
swnwnwswswswwseneewwneewswwswswsw
ewnwswnenwwwswnwsenwnwnwnwwwwwnewnw
seseseseseeeesenw
nwnwwnwswwenwwnwnwnwnwswnwnwnwenwnwnw
nenwnenenenesenwnwswnwneneswnwenenwneese
wnwwwwswwewewwwwswnewwwsww
nwswsewswwswneswswnewswwswseswnwww
neenewneneneswenwwnewnwnwnenwsesenw
seseesesesesesesesesweswwsenwsesesese
nwewnwswneseseseewsesenwseseseeseese
ewneeeeeeesweewenewse
wnwwwwwwwwnwnwwsenenwwwwenw
wseswswswswwnenenwwewenwswnew
nenwsenenwnwnwnwnwwnwnwnw
wneeneenenenwsesewnewwsenenwswswsw
eeeeenweeswewsweeeeeenwee
wenwseswseswswnwswswswswneswseswseee
nenenwnwwenwnwnwnwnwnwnwnw
wsewwwnwnewwwwwwwwsewwww
wwwwswnwwswwswewenwswwwwnwswwse
seneswwwwewnewwwwswwswwswwwe
nesewswneswswnwwwsewwwwswswwnesw
swewseswnwnwswweseeswwswnwnweswsw
nwnwnwenwnwswwsenewswnwnwnwnweenwnwsw
swenwswswseswswswswswswswswwswseseese
nwseswnwneswwswwnweeswewnwnwwwew
nwseswwnwenwewwnwnwswwnwnwnwnwseww
enweneeeeeeeenwsweesweew
nesenenwnwwwnwwswnwnwnwwnwwse
weneeeseseneeenweeeneneenwewe
senwnwnwnwswneneswnwnwnewnwsenwwnesee
nwneseneswnenenwnwnwwnw
wnwnwwswnwnwnwnwesewnwnwswnwnwwnwnenwe
nwswwswswwseewsweseswneeneseesew
enwwnwwswwswenwwsweenwnwewnwse
seewwwswnwwswwwwswswewwswswwnw
nenwnenwneenwsenenewnwwnenwnwnenwnw
swswseseswswswneswswswswswswsesweswsenwsene
neneneswswneneseneweswnenwseswseswwsw
wwweneswwwwwswsenew
swswswnwseswswswswswswswsw
nwnenesenenwnenwnwnwnw
eeesenwseeswseeeenwneswseeenwsenew
seeeeseseeswsesenweeeewsewsese
swseneswswseneswnwswswseseswseseswwsewsesw
nwswnenenwneenwsenwswnwnenenwnwnwsenenwsw
nwseseeeenwswswnwswese
nweneneenenwsenenenenese
wswswswwwwewwwneswwesewneswwswnw
nwsenwwnenwnenwsenewnwnwnesenenenwnwne
nenwswnwenwseswnenwwnwnwnwnwwenwnenenw
wseswweswenenwswwswseneewwwnew
seeswseseesewenenwswewe
swswwswswsenenwneswseswswswswswswswswsw
wnwsewsenenenwnwsewnwwenenwswnwnwsenw
seneeseeneswsesenweseswweeswsenwswe
nenenenwnwneenewesesenenenenewsenenene
eneeneeeeeeeeseenew
";
        private const string test = @"sesenwnenenewseeswwswswwnenewsewsw
neeenesenwnwwswnenewnwwsewnenwseswesw
seswneswswsenwwnwse
nwnwneseeswswnenewneswwnewseswneseene
swweswneswnenwsewnwneneseenw
eesenwseswswnenwswnwnwsewwnwsene
sewnenenenesenwsewnenwwwse
wenwwweseeeweswwwnwwe
wsweesenenewnwwnwsenewsenwwsesesenwne
neeswseenwwswnwswswnw
nenwswwsewswnenenewsenwsenwnesesenew
enewnwewneswsewnwswenweswnenwsenwsw
sweneswneswneneenwnewenewwneswswnese
swwesenesewenwneswnwwneseswwne
enesenwswwswneneswsenwnewswseenwsese
wnwnesenesenenwwnenwsewesewsesesew
nenewswnwewswnenesenwnesewesw
eneswnwswnwsenenwnwnwwseeswneewsenese
neswnwewnwnwseenwseesewsenwsweewe
wseweeenwnesenwwwswnew";
        private static void exo1()
        {
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var blackTiles = new HashSet<Position>();

            Console.WriteLine( -3 % 2);
            foreach (var line in lines)
            {
                int index = 0;
                var current = new Position(0, 0);
                while (index < line.Length)
                {
                    if (line[index] == 'e')
                    {
                        current = current.GetNeighBor(Direction.E);
                        index++;
                        continue;
                    }
                    if (line[index] == 'w')
                    {
                        current = current.GetNeighBor(Direction.W);
                        index++;
                        continue;
                    }
                    if (line[index] == 's')
                    {
                        index++;
                        current = current.GetNeighBor(line[index ] == 'e' ? Direction.SE : Direction.SW);
                        index++;
                        continue;
                    }
                    if (line[index] == 'n')
                    {
                        index++;
                        current = current.GetNeighBor(line[index ] == 'e' ? Direction.NE : Direction.NW);
                        index++;
                        continue;
                    }

                    throw new Exception();
                }

                if (blackTiles.Contains(current))
                {
                    blackTiles.Remove(current);
                }
                else
                {
                    blackTiles.Add(current);
                }
            }
            Console.WriteLine(blackTiles.Count);
        }

        public  enum Direction {
            E=0,
            W=1,
            SE=2,
            SW=3,
            NE=4,
            NW=5
        }

        public readonly struct Position : IEquatable<Position>
        {
            public Position(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; }
            public int Y { get; }

            public bool Equals(Position other)
            {
                return X == other.X && Y == other.Y;
            }

            public override bool Equals(object obj)
            {
                return obj is Position other && Equals(other);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return (X * 397) ^ Y;
                }
            }

            public Position GetNeighBor(Direction dir)
            {
                switch (dir)
                {
                    case Direction.E:
                        return new Position(X, Y + 1);
                    case Direction.W:
                        return new Position(X, Y - 1);
                    case Direction.SE:
                        return new Position(X + 1, Math.Abs(X % 2) == 1 ? Y + 1 : Y ); 
                    case Direction.SW:
                        return new Position(X + 1, Math.Abs(X % 2) == 0 ? Y - 1 : Y ); 
                    case Direction.NE:
                        return new Position(X - 1, Math.Abs(X % 2) == 1 ? Y + 1 : Y ); 
                    case Direction.NW:
                        return new Position(X - 1, Math.Abs(X % 2) == 0 ? Y - 1 : Y ); 
                    default:
                        throw new ArgumentOutOfRangeException(nameof(dir), dir, null);
                }
            }
        }
        private static void exo2()
        {
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var blackTiles = new HashSet<Position>();

            Console.WriteLine( -3 % 2);
            foreach (var line in lines)
            {
                int index = 0;
                var current = new Position(0, 0);
                while (index < line.Length)
                {
                    if (line[index] == 'e')
                    {
                        current = current.GetNeighBor(Direction.E);
                        index++;
                        continue;
                    }
                    if (line[index] == 'w')
                    {
                        current = current.GetNeighBor(Direction.W);
                        index++;
                        continue;
                    }
                    if (line[index] == 's')
                    {
                        index++;
                        current = current.GetNeighBor(line[index ] == 'e' ? Direction.SE : Direction.SW);
                        index++;
                        continue;
                    }
                    if (line[index] == 'n')
                    {
                        index++;
                        current = current.GetNeighBor(line[index ] == 'e' ? Direction.NE : Direction.NW);
                        index++;
                        continue;
                    }

                    throw new Exception();
                }

                if (blackTiles.Contains(current))
                {
                    blackTiles.Remove(current);
                }
                else
                {
                    blackTiles.Add(current);
                }
            }
            Console.WriteLine(blackTiles.Count);

            var blackTilesNext = new HashSet<Position>();

            bool IsBlack(Position p)
            {
                return blackTiles.Contains(p);
            }
           

            Position[] neighbors = new Position[6];

            void Populate(Position p)
            {
                for (int i = 0; i < 6; i++)
                {
                    neighbors[i] = p.GetNeighBor((Direction) i);
                }
            }
            int NbBlackVoisin()
            {
                int res = 0;
                foreach (var n in neighbors)
                {
                    if (IsBlack(n))
                    {
                        res++;
                    }
                }
                return res;
            }

            for (int day = 0; day < 100; day++) {

                foreach (var blackTile in blackTiles)
                {
                    Populate(blackTile);
                    var nbBlackVoisin = NbBlackVoisin();
                    if (nbBlackVoisin == 1 || nbBlackVoisin == 2)
                    {
                        blackTilesNext.Add(blackTile);
                    }

                    foreach (var n in neighbors.ToArray()) {
                        if (IsBlack(n))
                        {
                            continue;
                        }
                        Populate(n);
                        if (NbBlackVoisin() == 2)
                        {
                            blackTilesNext.Add(n);
                        }
                    }
                }
                
                var tmp = blackTiles;
                blackTiles = blackTilesNext;
                blackTilesNext = tmp;
                blackTilesNext.Clear();
                Console.WriteLine($"Day {day+1}: {blackTiles.Count}");

            }
            
        }
        
    }
}
using System;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace Day11
{
    class Program
    {
        private const string input = @"LLLLLLLLLL.LLLL.LLLLLLL.LLLLL.LLLLLLLLLLLLLLLLLLLLLL.LL.LLLLLLLLLLL.LLLLLL.LL.LLLL.LLLLLL.LLLLLLL
LL.LLLLLLL.LLLLLLLLLLLL.LLLLL.LLLLLLLL.LLLLLLLLL.LLLLLL.LLLLLLLL.LLLLLLLLL.LL.LLLL.LLLLLL.LLLLLLL
LLLLLL.LLLLLLLLLLLLLLLL.LLL.L.LLLLLLLL.LLLL.LLLL.LLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLLL.LLLL.L.LLLLLLL
LLLLLLLLLL.LLLL.LLLLLLLLLLLLL.LLLLLLLL.LLLLLLLLL.LLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLL
LLLLLLLLLLLLLLL.LLLLLLL.LLLLL.LLLLLL.L.LLLLLLLLL.LLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLL
LLLLLLLLLL.LLLLLLLLLLLL.LLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLL.LLLLLLLLL.LLLLLLL.LLLLLL.LLLLLLL
LLLLLLLLLL.LLLL.LLLLLLL.LLLLL.LLLLLLLL.LLLLLLLLLLLLLLLLLLL.LLLLLLL.LLLLLLLLLLLLLLL.LLLLLL.LLLLLLL
LLLLLLLLLL.LLLL.LLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLL
L.L....L...L..LLLLLL.L.LLL..L...L.....L.L...L..L.LL.....L..L..LL...L........L..LLLLLLL.L......L..
LLLLLLLLLL.LLLLLLLL.LLL.LLLLLLLLLLLLLL.LLLLLLLLL.LLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL
LLLLLLLLLLLLLLLLLLLLLLL.LLLL..LLLLLLLL.LL.LLLLLLL.LLLLLLLLLLLLLL.LL.LLLLLLLLLLLLLL.LLLLLLLLLLLLLL
LLL.LLLLLL.LLLL.LLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLLL.LLLLLLL.L.LLLLLLL.LLLLLLLLLLLLLL
LLLLLLLLLLLLLLL..L.LLLL.LLLLL.LLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLLLLLLL
LLLLLLL.LLLLLLL.LLLLLLL.LLLLL.LLL.LLLLLLLLLLLL.LLLLLLLL.LLLLLLLL.LLLLLLLLL.LLLLLLLLLLLLLL.LLLLLLL
LLLLLLLLLL.LLLLLLLLLLLLLLLLLL.LLLLLLLL.LLLLLLLLL.LLLLLL.LLLLLLLL.LLLLLLLLL.LLLLLLL.LLLLLLLLLLLLLL
LLLLLLLLLL.LLLL.LLLLLLLLLL.LL.LLLLLLLL.LLLLLLLL...LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLL
LLLLLLLLLLLLL.LLLLLLLLL.LLLLL.LLLLLLL..LLLLLL.LLLLLLLLLLL.LLLLLL.LLLLLLLLL.LL.LLLLLLLLLLLLLLLLLLL
..L...L..LL.L....LL.L...LLLL......L...L....L...L.L...L..L..L...L.....L..L...................LLL.L
LLLLLLLLLLLL.LLLLLLL.LL.LLLLL.LLLLLLLL.LLLLLLLLL.LLLLL..LLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLL
LLLLLLLLLL.LLLL.LLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLL.LL.LLLL.LLLLLL.LLLLLLL
LLLLLLLLLL.LLLL.LLLLLLLLLLLLLLLLLLLLLL.LLLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLL.L.LLLLLLLLLLLL.LLLLLLL
LLLLLLLLLLLLLLL.LLLLLLL.LLLLL.LLLLLLLLLLLLLLLLLL.LLLLLL.L.LLLLLL.LLLLLLLLLLL.LLLL..LLLLLL.LLLLLLL
LLLLLLLLLL.LLLL.LLLLLLLLLLLLL.LLLLLLLL.LLLLLLLLLLLLLLLL.LLLLLLLL.LL.LLLLLLLLLLLLLLLLLLLLLLLLLLLLL
LL..LL.....LLL......LL.........L...L..L......L.....LL........LLLL.....L..................LL....L.
LLLLLLLLLL.LLLL.LLLLLLL.LLLLL.LLLLLLLL.LLLLLLLLL.L.LLLLLLLLLLLLL.LLLLL.LLLLLLLLLL.LLLLLLL.LLLLLLL
LLLLLLLLLLLLLLLLLLL.LLL.LLL.L.LLLLLLLLLLLLLLLLLL.LL.L.L.LLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLL.LLLLLLLL
LL.LLLLLLL.LLLLLLLLLLLL.LLLLLLLLLLLLLL.LLLLLLLLL.LLLLLL.LLLLLLLL.LLLLLLLLL.LLLLLLL.LLL.LL.LLLLLL.
LLLLLLLLLL.LLLL.LLLLLLL.LLLLL.LLLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLLLLLLLLLLLLL.LLLLLLL.LLLLLL.LLLLLLL
.LLLLLLLLLLLL.L.LLLLLLL.LLLLL.LLLLLLLL.LLLLLLLLL.LLLLLL.LLLLLLLL.LLLLLLLLLLLLLL.LLLLLLLLL.LLLLLLL
...L..L...L.....L....LL..L.....L.L..L...LLLL..L....LL.L....L.L.L......LL...L...L..LLLL.L..L......
LLLLLLLLLL.LLLLLLLLLLLL.LLLLL.LLLLLLLL.LLLL.LLLLLLLLLLL.LLLLLL...LLL.LLLLL.LLL.LLL.LLLLL..LLLLLLL
LLLLLLLLLL.LLLL.LLLLLLL.LLLLL.LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL.LLL.LLLLLLLLLL.LLLLLLL
LLLLLLLLLLLLLLLLLLLLLLL.LLLLL.LLLLLLLLLLLLLLLLLLLLLLL.L.LLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLL
LLLLLLLLLL.LLLL.LLLLLLLLLLLLL.LLLLLLLL.LL.LL.LLL.LLLLL..LLLLLLLL.LLLLLLLLL.LLLL.LLLLLLLLLLLLLLLLL
L.LLLLLLLLLLL.L..LLLLLL.LLLLL.LLLLLLLL..LLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLL
.L....LL....L......LLL...L..L..L.L.L.LLL.L.L........L....L..LL......L......L.L..LLLL.L.L..L......
LLLLLLLLLL.LLLLLLLLLLLL.LLLLLLLLLLLLLL.LLLLLLLLLLLLLLLL.LLLLLLLL.LLLLLLLL..LLLLLLL..LL.LLLLLLLLLL
LLLLLLLLLLLLLLLLLLLLLLL.LLLLL.LLLLLLLL.LLLL.LLLL.LLLLLL.LLLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLLLLL
LLLLLLLLLL..LLL.LLLLL.L.LL.LL.LLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLL.LLLLLLLLLLLLLL
LLLLL.LLLLLLLLL.LLLLLLLLLLLLL.LLLLLLLL.LLLLLLLLL.LLLLLLLLLLLLL.L.LLLLLLLLL.LLLLL.L.LLLLLLLLLLLLLL
LLLLLL.....L......L.......L..L.LLL...L.L...LLL....L.......L.L..L...LL....LL.L...L...LLL.L...L..LL
LLLLLLLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLL.LLLLLLLLL.LLLLLL.LLLLLLLL.LLLLLLLLL.LLLLLLLLLLLLLL.LLLLLLL
LLLLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLLLL.LLLLLL.LLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLL.L.LLLLL
LLLLLLLLLLLLLLL.LL.LLLL.LLLLL.LLLLLLLL.LLLLLLLLL.LLLLLL.LLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLL.LLLLLLL
LLLLLLLLLLLLLLLLLLLLLLL.LLLLL.LLLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLLL.LLLLLL.LL.LLLLLLLLLLLLLLLLLLLLLL
....L..L.L.L...L.....L...LLL.....L.......L..LLL.LL...L.....L..L.L...L.L.L...LL...LL.L....LL.....L
LLLLLLLLLL.LLLL.LLLLLLL.LLLLL.LLLLLLLL.LLLLLLLLL.LLLLLL.LLLLLLLL.LLLLLLLLLLLLL.LLLLLLLLLL.LLL.LLL
LLL.LLLLLL.LLLL.LLLLLLL.LLLLLLLLLLLLLLLLLLL.LLLLLLLL.LL.LLLLLLLLLLLLLLL.LLLLLLLLLL.LLLLLL.LLLLLLL
LLLLLLLLLL.LLLL.LLLLLLLLLLLLL.LLLLLLLL.LLLLLLLLLLLLLL.L.LLLLLLLLLLL.LLLLLL.LLLLLL..LLLLLLLLLLLLLL
LL.LLLLLLLLLLLL.LLLLLLL.LLLLL.LLLLLLLLLLLLLLLLLL.LLLLLL.LL.LLLL..LLLLLLLLL.LLLLLLL.LLLLLL.LLLLLLL
LLLLLLLLLL.LLLL.LLLL.LL.LLLLLLLLLLLLLL.LLLLLLLLL.LLLLLL.LLLLLLLL.LLLLLLLLL.LLLLLLL.LLLLLL.L.LLLLL
LLL.LLLLLL.LLLL.LLLLLLL.LLLLL.LLLLLLLL.LLLLLLLLL.LL.LLLLLL..LLLL.LLLLLLLLL.LLLLLLL.LLLLLLLLL.LL.L
LLLLLLLLLL.LLLL.LLLLLLL.LLLLL.LLLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLLL.LLLLLLLLL.LLLLLLLLLLLLLLLLLLLLLL
......L......LLL......L.LL...L..L.L.L..L.L.......L.L....L..LL.......L......L.....L.LLLLLL...L...L
LLLLLLLLLLLLLLL.LLLLLLL.LLLLL.LLLLLLLL.LLLLLLL.LLLLLLLLL.LLLLLLLLLLLLLLLLL.LLLLLLLLLLL..L.L.LLLLL
LLLLLLLLLLLLLLL.LLLLLLL.LLLL.LLLLLLLLL.LLLLLLLLLLLLLLLL.LLLLL.LLLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLLL
LLLLLLLLLL.LLLL.LLLLL.L.LLL.L.LLLLLLLL.LLLLLLL.LLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLL
LLLLLLLLLL.LLLL.LL.LLLL.LLLLL.LLLLLLLL.LLLLLLLLL.LLLLLL.LLLLLLLL.LLLLLLLLL.LLLLLLL..LLLLL.LLLLLLL
LL.LLLLLLLLLLLL.LLLLLLL.LLLLL.LLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLL.LLLLLLLLLLLLLL
.LLLLL.LLL.LLLLLLLLLLLL.LLLLL.LLLLLLLL.LLLLLL.LL.LLLLLLLLLLLL.LL.LLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLL
LLLLLLLLLL.LLLL.LLLLLLLLLLLLL.LLLLLLLL.LLL.LL.L.LLLL.L.LLLLLLLLL.LLLLLLLLL.LLLLLLLLLLLLLL.LLLLLLL
LLLLLLLLLL.LLLLLLLLLLLL.LLLL..LLL.LLLL.LLLLLLLLL.LLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLL
LLLLLLLLLLLLLLLLLLLL.LL.LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL.L.L.LLLLLLL.L.LLLLL.LLLLLL.LLLLLLL
.L....L...L..LL.....L.LL...L.L..LLL...L..L..L..L..L.LLLLL....LLLL.........L..L..L..L..L...LL....L
LLLLLLLLLL.LLLL.LLLLLLL.LLLL..LLLLLLLLLLLLLLLLL..L.LLLL.LLLLLLLL.LLLLLLLLL.LLLLLLL.LLLLLL.LLLLLLL
LLLLLLLLLLLLLLL.LLLLLLL.LLLLL.LLLLLLLL.LLLLLLL.L.LLLLLLLLLLLLLLLLL.LLLLLLL.LLLLLLL.LLLLLL.LLLLLLL
LLLLL.LLLL.LLLL.LLLLLLL.LLLLL.LLLLLLLL.LLLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL..LLLL
LLLLLLLLLL.LLLL.LLLLLLL.LLLLL.LLLLLLLL.LLLLLLLLL.LLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLL
LL.LLLLLLLLLLLL.LLLLLLL.LLLLL.LLLL.L.L.LLLLLLLLL.LLLLLL.LLLLLLLLLLLLLLLLLL.LLLLLLL.LLLLLL.LLLLLLL
LLLLL.LLLL.LLLL.LLLLLLL.LLLLL.LLLLLLLLLLLLLLLLLL.LLLLLLLLL.LLLLLLLLLLLLLLL.LLLLLLL.LLLLLL.LLLLLLL
..L.L...L.L........L.......L......LLLLL......L.LLL.LL.........L.L....L..L.L.L...L..LL.L......LL..
LLLLLLLLLL.LL.L.LLLLLLL.LLLLL.LLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLL.LLLLLLL.LLLLLL.LLLLLLL
LLLLLLLLLL.LLLL.LLLLLLLLL.LLL.LLLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLLLLLLLLLL.LL.LLLLLLL.LLLLLL.LLLLLLL
LLL.LLLLLLLLL.L.LLLLLLL.LLLLLLLLLLLL.L.LLLLLLLL..LLLLLLLLLLLLLLL.LLLL.LLLLLLLLLL.L.LLLLLLLLLLLLL.
LLLLLLLLLLLLLLL.LLLLLLL.LLLLL.LLLLLLLLLLLLLLL.LL.LLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL
LLLLLLLLLL.LLLL.LLLLLLL.LLLLL.LLLLLLLL.LLLLLLLLL.LLLLLL.L.LLLLLL.LL.LLLLLL.LLLLLLL.LL.LLL.LLLLLLL
LLLLLLLLLLLLLLLLLLLLLLL.LL.LL.LLLLLLLL.LLLLLLLLL.LLLLLL.LLLLLLLL.LLLLLLLLL.LLLLLLLLLLLLLL.LLLLLLL
LLLLLLLLLL.LLLLLLLLLL.L.LLLLL.LLLLLLLL.LLLLLLLLL.LLL.LL.LLLLLLLL.LLLLLLLLL.LLLLLLL.LLLLLLLLLLLLLL
LLLLLLLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLLL.LLLLLL.LL.LLLLL.LLLLLLLLL.LLLLLLL.LLLLLLLLLLLLLL
LLLLLLLL.L.LLLL.LLLLLLL.LLLL..LLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLLL.LLLLLLLLL.LLLLLLL.LLLLLL.LLLL.LL
.....LL.L...L..L.L..LL.L.......L...L...LLL.L.L..L.LL.L...LL..L.LL.LLL......LL.L..L.LL......L.....
LLL.LLLLLL.LLLLLLLLLLLL.LLLLLL..LLLLLL.LLLLLLLLL.LLLLLL.LLLLLLLL.LLLLLLLLL.LLLLLLLLLL.LLLLLLLL..L
LLLLLLLLLL.LLLL.LLLLL.L.LLLLL.LLLLLLLL.LLLLLLLLLLLLLLLL.LLLLLLLL.L..LLLLLL.LLLLLLL.LLLLL.LLLLLLLL
LLLLLLLLLL.LLL..LLLLLLL.LLLLL.LLLLLLLL.LLLLLLL.LLLLLLLL.LLLLLLLL.LLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLL
LLLLLLLLLL.LLLLLLLLLLLL.LLLLL.LLLLLLLL.LLLLLLLLLLLLLLL..LLLLLL.LLLLLLLLL.L.LLLLL.LLLLLLLL.LLLLLLL
LLLLLLLLLL.LLLL.LLLLLLL.LLLLL.LLL.LLLLLLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLLLL.LLLLLLL.LLLLLL.LLLLLLL
LLLLLLLLLLLLLLL.LLLLLLLLLLLLL.LLLLLLLL.LLLLLLLLL.LLLLLLLLLLLL.LL.LLL.LLLLLLLLL.LLLLLLLLLL.LLLLLLL
LLLLLLLLLLLLLLL.LLLLLLLLLLLLLLL.LLLLLL.LLLLLLLLL.LLLLLL.LLLLLLLL.LLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLL
LL.LLLLLLLLLLLL.LLLLLLL.LLLL..LLLLLLL..LLLLLLLLL.LLLLLLLLLLLLLLL.LLLLLLLLL.LLLLLLLLLLLLLL.LLLLLLL
LLLLLLLL.L.LLLLLLLLLLLL.LLLLLLLLLLLLL..LLLLLLLLL.LLLLLL.LLLLLLLLLLLLLLLLLL.LLLLLLL.LLLLLL.LLLLLLL
LLLLLLLL.LLLLLLLLLLLLLL.LLLLL.LLLLLLLLLL.LLLLLLL.LLLLLL.LLLLLL.L.LLLLLLLLL.LLLLLLL.LL.LLL.LLLLLLL
LLLLLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLLL.LLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLL
LLLLLLLLLLLLLLL.LLLLLLL.LLLLL.LLLLL.LLLLL.LLLLLL.L.LLLL.LLLLLLLL.LLLLLLLLLLLLLLLLL.LLL.LL.LLLLLL.
";
        private const string test1 = @"L.LL.LL.LL
LLLLLLL.LL
L.L.L..L..
LLLL.LL.LL
L.LL.LL.LL
L.LLLLL.LL
..L.L.....
LLLLLLLLLL
L.LLLLLL.L
L.LLLLL.LL";
        private const string test2 = @"";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            exo2();
        }

        public enum PositionState
        {
            Floor,
            Occupied,
            Free
        }

        public static PositionState From(char c)
        {
            return c switch
            {
                '.' => PositionState.Floor,
                'L' => PositionState.Free,
                '#' => PositionState.Occupied,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public static char To(PositionState c)
        {
            return c switch
            {
                PositionState.Floor => '.',
                PositionState.Free => 'L',
                PositionState.Occupied => '#',
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        static void exo1()
        {
           var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

           var current = lines.Select(l => l.Select(From).ToArray()).ToArray();
           var next = current.Select(c => ( PositionState[])c.Clone()).ToArray();
           var nbCol = next[0].Length;
           PositionState NextState(int x, int y) {
               var currentState = current[x][y];
               if ( currentState== PositionState.Free)
               {
                   bool allFreeAround = true;
                   for (int i = x - 1; i <= x + 1; i++) {
                       if (i < 0 || i >= current.Length) {
                           continue;
                       }
                       if (!allFreeAround) {
                           break;
                       }
                       for (int j = y - 1; j <= y + 1; j++) {
                           if ( j < 0 || j >= nbCol || ( i == x && j == y)) {
                               continue;
                           }

                           if (current[i][j] == PositionState.Occupied)
                           {
                               allFreeAround = false;
                               break;
                           }

                       }
                   }

                   if (allFreeAround)
                   {
                       return PositionState.Occupied;
                   }

               }
               if ( currentState== PositionState.Occupied)
               {
                   int nbOccupied = 0;
                   for (int i = x - 1; i <= x + 1; i++) {
                       if (i < 0 || i >= current.Length){
                           continue;
                       }
                       for (int j = y - 1; j <= y + 1; j++) {
                           if ( j < 0 || j >= nbCol || ( i == x && j == y) ) {
                               continue;
                           }

                           if (current[i][j] == PositionState.Occupied)
                           {
                               nbOccupied++;
                           }

                       }
                   }

                   if (nbOccupied >= 4)
                   {
                       return PositionState.Free;
                   }

               }

               return currentState;

           }

           int nbRound = 0;
           while (true) {

               for (int i = 0; i < next.Length; i++) {
                   for (int j = 0; j < nbCol; j++) {
                       next[i][j] = NextState(i, j);
                   }
               }
               Console.WriteLine("nbRound " + nbRound++);
               foreach (var line in next)
               {
                   Console.WriteLine(line.Select( To ).ToArray());
               }


               bool allEqual = true;
               for (int i = 0; i < next.Length; i++)
               {
                   for (int j = 0; j < next[i].Length; j++)
                   {
                       if (next[i][j] != current[i][j])
                       {
                           allEqual = false;
                           break;
                       }
                   }

                   if (!allEqual)
                   {
                       break;
                   }
               }

               if (allEqual)
               {
                   break;
               }

               var tmp = current;
               current = next;
               next = tmp;
           }

           int nb = 0;
           for (int i = 0; i < next.Length; i++)
           {
               for (int j = 0; j < nbCol; j++)
               {
                   if (next[i][j] == PositionState.Occupied)
                   {
                       nb++;
                   }
               }

           }
           Console.WriteLine(nb);
        }

         static void exo2()
        {
           var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

           var current = lines.Select(l => l.Select(From).ToArray()).ToArray();
           var next = current.Select(c => ( PositionState[])c.Clone()).ToArray();
           var nbCol = next[0].Length;

           PositionState FirstVisibleSeatState(int x, int y, int xStepper, int yStepper)
           {
               x += xStepper;
               y += yStepper;
               while (x >= 0 && x < current.Length && y >= 0 && y < nbCol) {
                   if (current[x][y] != PositionState.Floor)
                   {
                       return current[x][y];
                   }
                   x += xStepper;
                   y += yStepper;
               }

               return PositionState.Floor;
           }
           PositionState NextState(int x, int y) {
               var currentState = current[x][y];
               if ( currentState== PositionState.Free)
               {
                   bool allFreeAround = true;

                   for (int i = - 1; i <=1; i++) {
                       if (!allFreeAround) {
                           break;
                       }
                       for (int j = - 1; j <= 1; j++) {
                           if ( i == 0 && j == 0 ) {
                               continue;
                           }

                           if (FirstVisibleSeatState(x,y,i,j) == PositionState.Occupied)
                           {
                               allFreeAround = false;
                               break;
                           }

                       }
                   }

                   if (allFreeAround)
                   {
                       return PositionState.Occupied;
                   }

               }
               if ( currentState== PositionState.Occupied)
               {
                   int nbOccupied = 0;
                   for (int i = - 1; i <=1; i++) {
                       for (int j = - 1; j <= 1; j++) {
                           if ( i == 0 && j == 0 ) {
                               continue;
                           }

                           if (FirstVisibleSeatState(x,y,i,j) == PositionState.Occupied)
                           {
                               nbOccupied++;
                           }

                       }
                   }

                   if (nbOccupied >= 5)
                   {
                       return PositionState.Free;
                   }

               }

               return currentState;

           }

           int nbRound = 0;
           while (true) {

               for (int i = 0; i < next.Length; i++) {
                   for (int j = 0; j < nbCol; j++) {
                       next[i][j] = NextState(i, j);
                   }
               }
               Console.WriteLine("nbRound " + nbRound++);
               foreach (var line in next)
               {
                   Console.WriteLine(line.Select( To ).ToArray());
               }
               Console.WriteLine();


               bool allEqual = true;
               for (int i = 0; i < next.Length; i++)
               {
                   for (int j = 0; j < next[i].Length; j++)
                   {
                       if (next[i][j] != current[i][j])
                       {
                           allEqual = false;
                           break;
                       }
                   }

                   if (!allEqual)
                   {
                       break;
                   }
               }

               if (allEqual)
               {
                   break;
               }

               var tmp = current;
               current = next;
               next = tmp;
           }

           int nb = 0;
           for (int i = 0; i < next.Length; i++)
           {
               for (int j = 0; j < nbCol; j++)
               {
                   if (next[i][j] == PositionState.Occupied)
                   {
                       nb++;
                   }
               }

           }
           Console.WriteLine(nb);
        }
    }
}
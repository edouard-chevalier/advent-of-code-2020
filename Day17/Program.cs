using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day17
{
    class Program
    {
        private const string input = @"##..####
.###....
#.###.##
#....#..
...#..#.
#.#...##
..#.#.#.
.##...#.
";
        private const string test = @"
.#.
..#
###";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            exo2();
        }

        public class Layer
        {
            public Layer(int z, int width)
            {
                Z = z;
                Actives = Enumerable.Range(0, width).Select(i => new BitArray(width)).ToArray();
            }
            public int Z { get; }
            public BitArray[] Actives { get; }

            public int Width => Actives.Length;

            public int NbActive()
            {
                int res = 0;
                foreach (var bitArray in Actives)
                {
                    for (int i = 0; i < bitArray.Count; i++)
                    {
                        if (bitArray.Get(i))
                        {
                            res++;
                        }
                    }
                }

                return res;
            }

            public bool Active(int i, int j) {
                if (i < 0 || i >= Width || j < 0 || j >= Width)
                {
                    return false;
                }

                return Actives[i].Get(j);
            }

            public override string ToString()
            {
                var sb = new StringBuilder( $"z={Z}\n");
                foreach (var bitArray in Actives)
                {
                    for (int i = 0; i < bitArray.Count; i++)
                    {
                        sb.Append(bitArray.Get(i) ? '#' : '.');
                    }
                    sb.AppendLine();

                }
                return sb.ToString();
            }
        }
        static void exo1()
        {
            var lines = test.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var currentLayers = new List<Layer>();
            var firstLayer = new Layer(0, lines.Length);
            currentLayers.Add(firstLayer);
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                for (int j = 0; j < line.Length; j++) {
                    if (line[j] == '#') {
                        firstLayer.Actives[i].Set(j, true);
                    }
                }
            }
            
            var nextLayers = new List<Layer>();
            int currentWidth = firstLayer.Width;

            for (int cycle = 0; cycle < 6; cycle++) {
                currentWidth += 2;
                for (int layer = 0; layer <= currentLayers.Count; layer++)
                {
                    var currentLayer = layer != currentLayers.Count ? currentLayers[layer] : null;
                    var newLayer = new Layer(layer, currentWidth );
                    for (int x = 0; x < newLayer.Width; x++) {
                        for (int y = 0; y < newLayer.Width; y++) {
                            int nbActive = 0;
                            for (int i = x - 1; i <= x + 1; i++) {
                                for (int j = y - 1; j <= y + 1; j++) {
                                    if (layer != 0 && currentLayers[layer-1].Active( i-1,j-1)) {
                                        nbActive++;
                                        if (layer == 0) {
                                            nbActive++;
                                        }
                                    }

                                    if (currentLayer != null && !(i == x && j == y) && currentLayer.Active(i - 1, j - 1))
                                    {
                                        nbActive++;
                                    }
                                }
                            }

                            if (currentLayer!= null && currentLayer.Active(x - 1, y - 1)) {
                                if (nbActive == 2 || nbActive == 3) {
                                    newLayer.Actives[x].Set(y, true);
                                }
                            }
                            else {
                                if ( nbActive == 3) {
                                    newLayer.Actives[x].Set(y, true);
                                }
                            }
                        }
                    }

                    nextLayers.Add(newLayer);
                }
                
                
                var tmp = currentLayers;
                currentLayers = nextLayers;
                nextLayers = tmp;
                nextLayers.Clear();
                Console.WriteLine();
                Console.WriteLine($"cycle {cycle}");
                foreach (var layer in currentLayers) {
                    Console.WriteLine(layer);
                }
            }

            int count = currentLayers[0].NbActive();
            for (int i = 1; i < currentLayers.Count; i++)
            {
                count += currentLayers[i].NbActive() * 2;
            }
            Console.WriteLine(count);
        }

        public readonly struct Position : IEquatable<Position>
        {
            public Position(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public int X { get; }
            public int Y { get; }
            public int Z { get; }

            public bool Equals(Position other)
            {
                return X == other.X && Y == other.Y && Z == other.Z;
            }

            public override bool Equals(object obj)
            {
                return obj is Position other && Equals(other);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    var hashCode = X;
                    hashCode = (hashCode * 397) ^ Y;
                    hashCode = (hashCode * 397) ^ Z;
                    return hashCode;
                }
            }
        }
        static void exo1b()
        {
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var currentActives = new HashSet<Position>();
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                for (int j = 0; j < line.Length; j++) {
                    if (line[j] == '#')
                    {
                        currentActives.Add(new Position(i, j, 0));
                    }
                }
            }
            var nextActives = new HashSet<Position>();


            int maxPos = lines.Length;
            for (int cycle = 0; cycle < 6; cycle++) {
                maxPos++;
                for (int x = -maxPos; x <= maxPos; x++)
                {
                    for (int y = -maxPos; y <= maxPos; y++)
                    {
                        for (int z = -maxPos; z <= maxPos; z++)
                        {
                            int nbActive = 0;
                            for (int i = x - 1; i <= x + 1; i++)
                            {
                                for (int j = y - 1; j <= y + 1; j++)
                                {
                                    for (int k = z - 1; k <= z + 1; k++)
                                    {
                                        if (!(i == x && j == y && k == z) &&
                                            currentActives.Contains(new Position(i, j, k)))
                                        {
                                            nbActive++;
                                        }
                                    }
                                }
                            }

                            var position = new Position(x, y, z);
                            if (currentActives.Contains(position))
                            {
                                if (nbActive == 2 || nbActive == 3)
                                {
                                    nextActives.Add(position);
                                }
                            }
                            else
                            {
                                if (nbActive == 3)
                                {
                                    nextActives.Add(position);
                                }
                            }
                        }
                    }
                }


                var tmp = currentActives;
                currentActives = nextActives;
                nextActives = tmp;
                nextActives.Clear();
                Console.WriteLine();
                Console.WriteLine($"cycle {cycle}");
            }

            Console.WriteLine(currentActives.Count);
        }
         public readonly struct HyperPosition : IEquatable<HyperPosition>
         {
            public HyperPosition(int x, int y, int z, int w)
            {
                X = x;
                Y = y;
                Z = z;
                W = w;
            }

            public bool Equals(HyperPosition other)
            {
                return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
            }

            public override bool Equals(object obj)
            {
                return obj is HyperPosition other && Equals(other);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    var hashCode = X;
                    hashCode = (hashCode * 397) ^ Y;
                    hashCode = (hashCode * 397) ^ Z;
                    hashCode = (hashCode * 397) ^ W;
                    return hashCode;
                }
            }

            public int X { get; }
            public int Y { get; }
            public int Z { get; }
            public int W { get; }

       
        }
        static void exo2()
        {
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var currentActives = new HashSet<HyperPosition>();
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                for (int j = 0; j < line.Length; j++) {
                    if (line[j] == '#')
                    {
                        currentActives.Add(new HyperPosition(i, j, 0,0));
                    }
                }
            }
            var nextActives = new HashSet<HyperPosition>();


            int maxPos = lines.Length;
            for (int cycle = 0; cycle < 6; cycle++) {
                maxPos++;
                for (int x = -maxPos; x <= maxPos; x++)
                {
                    for (int y = -maxPos; y <= maxPos; y++)
                    {
                        for (int z = -maxPos; z <= maxPos; z++)
                        {
                            for (int w = -maxPos; w <= maxPos; w++)
                            {
                                int nbActive = 0;
                                for (int i = x - 1; i <= x + 1; i++)
                                {
                                    for (int j = y - 1; j <= y + 1; j++)
                                    {
                                        for (int k = z - 1; k <= z + 1; k++)
                                        {
                                            for (int l = w - 1; l <= w + 1; l++)
                                            {
                                                if (!(i == x && j == y && k == z && l == w) &&
                                                    currentActives.Contains(new HyperPosition(i, j, k, l)))
                                                {
                                                    nbActive++;
                                                }
                                            }
                                        }
                                    }
                                }

                                var position = new HyperPosition(x, y, z, w);
                                if (currentActives.Contains(position))
                                {
                                    if (nbActive == 2 || nbActive == 3)
                                    {
                                        nextActives.Add(position);
                                    }
                                }
                                else
                                {
                                    if (nbActive == 3)
                                    {
                                        nextActives.Add(position);
                                    }
                                }
                            }
                        }
                    }
                }


                var tmp = currentActives;
                currentActives = nextActives;
                nextActives = tmp;
                nextActives.Clear();
                Console.WriteLine();
                Console.WriteLine($"cycle {cycle}");
            }

            Console.WriteLine(currentActives.Count);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            exo2b();
        }

        private static int[] input = new[] {4,6,7,5,2,8,1,9,3};

        private static int[] test = new[] {3, 8, 9, 1, 2, 5, 4, 6, 7};

        private static int[] TakeNext3(int index, List<int> a)
        {
            index++;
            var res = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                if (index >= a.Count)
                {
                    res.Add( a[0]);
                    a.RemoveAt( 0);
                }
                else
                {
                    res.Add(a[index]);
                    a.RemoveAt(index);
                }
            }

            return res.ToArray();
        }

        private static void AddAfter(List<int> a, int[] added, int index)
        {
            var res = a.Take(index + 1).ToList();
            res.AddRange(added);
            res.AddRange(a.Skip(index +1));

            a.Clear();
            a.AddRange(res);
        }

        private static void Print(IEnumerable<int> a)
        {
            Console.WriteLine(String.Join(" ", a));
        }
        private static void exo1()
        {
            var nums = input.ToList();


            int currentCup = nums[0];

            for (int i = 0; i < 100; i++)
            {
                int index = nums.IndexOf(currentCup);
                int[] three = TakeNext3(index, nums);

                //select desctrination
                int destCup = currentCup;
                destCup--;
                if (destCup == 0) {
                    destCup = 9;
                }

                while (three.Contains(destCup))
                {
                    destCup--;
                    if (destCup == 0) {
                        destCup = 9;
                    }
                }
                AddAfter(nums, three, nums.IndexOf(destCup));
                index = (nums.IndexOf(currentCup) + 1) % nums.Count;
                currentCup = nums[index];

                Print(nums);
            }

        }
        
        private static void exo2b()
        {
            var start = input.ToList();
            var nums = new LinkedList<int>(start);
            foreach (var i in Enumerable.Range(10, 1000000- 9))
            {
                nums.AddLast(i);
            }
            
            Console.Write(nums.Last.Value);
            LinkedListNode<int>[] nodeIndex = new LinkedListNode<int>[nums.Count+1];
            var c = nums.First;
            while( c!=null)
            {
                nodeIndex[c.Value] = c;
                c = c.Next;
            }
            


            var currentCup = nums.First;

            LinkedListNode<int>[] three = new LinkedListNode<int>[3];

            int[] threeLabel = new int[3];
            for (int i = 0; i < 10000000; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {
                    if (currentCup.Next == null)
                    {
                        three[j] = nums.First;
                    }
                    else
                    {
                        three[j] = currentCup.Next;
                    }

                    threeLabel[j] = three[j].Value;

                    nums.Remove(three[j]);
                }

                //select desctrination
                int destCupLabel = currentCup.Value;
                destCupLabel--;
                if (destCupLabel == 0) {
                    destCupLabel = 1000000;
                }
                

                while (threeLabel.Contains(destCupLabel))
                {
                    destCupLabel--;
                    if (destCupLabel == 0) {
                        destCupLabel = 1000000;
                    }
                }


                var destCup = nodeIndex[destCupLabel];
                foreach (var node in threeLabel)
                {
                    //nums.AddAfter(destCup, node);
                    
                    destCup = nums.AddAfter(destCup, node);
                    nodeIndex[node] = destCup;
                }
                
                
               
                if (currentCup.Next == null)
                {
                    currentCup = nums.First;
                }
                else
                {
                    currentCup = currentCup.Next;
                }

                if (i % 10000 == 0)
                {
                    Console.WriteLine(i);
                }
                //Print(nums);
            }
            Console.WriteLine(nodeIndex[1].Next.Value);
            Console.WriteLine(nodeIndex[1].Next.Next.Value);
            
            Console.WriteLine( ((long) nodeIndex[1].Next.Value) * ((long)nodeIndex[1].Next.Next.Value));

        }

        public struct Range
        {
            public Range(int min, int max)
            {
                Min = min;
                Max = max;
            }
            public Range(int val): this(val,val)
            {
            }

            public int Min { get; set; }
            public int Max { get; set; }

            public bool Contains(int i)
            {
                return i >= Min && i <= Max;
            }

            public override string ToString()
            {
                return Min == Max ? $"{Min}" : $"{Min}-{Max}";
            }
        }

        public static int IndexOf(List<Range> a, int val)
        {
            for (int i = 0; i < a.Count; i++) {
                if (a[i].Contains(val))
                {
                    return i;
                }
            }

            throw new Exception();
        }
        
        private static (int x, int y, int z) TakeNext3(int val, List<Range> a) {

            //On cherche le premier container pr prendre les 3
            // val devient la première à prendre.
            int idx = IndexOf(a, val);
            if (a[idx].Max == val) {
                if (++idx == a.Count)
                {
                    idx= 0;
                }

                val = a[idx].Min;
            }
            else {
                val++;
            }
            
            //tout est dedans, on splitte.//TODO check if on remove all.
            if (a[idx].Max > (val + 2))
            {
                if (a[idx].Min == val) {
                    a[idx] = new Range(val+3, a[idx].Max);
                }
                else {
                    a.Insert(idx+1 , new Range(val+3,a[idx].Max));
                    a[idx] = new Range(a[idx].Min, val-1);
                }
                
                return (val, val + 1, val + 2);
            }
            //tout est dedans, à la limite.
            if (a[idx].Max == (val + 2))
            {
                if (a[idx].Min == val) {
                    a.RemoveAt(idx);
                }
                else
                {
                    a[idx] = new Range(a[idx].Min, val - 1);
                }
                return (val, val + 1, val + 2);
            }

            int x, y, z;
            //On en prend 2 puis 1
            if (a[idx].Max == (val + 1))
            {
                if (a[idx].Min == val)
                {
                    a.RemoveAt(idx);
                    if (idx == a.Count)
                    {
                        idx = 0;
                    }
                }
                else
                {
                    a[idx] = new Range(a[idx].Min, val - 1);
                    if (++idx == a.Count)
                    {
                        idx = 0;
                    }
                }

                x = val;
                y = val + 1;
                
               

                z = a[idx].Min;
                if (a[idx].Min == a[idx].Max)
                {
                    a.RemoveAt(idx);
                }
                else
                {
                    a[idx] = new Range(a[idx].Min+1, a[idx].Max);
                }

                return (x, y, z);
            }
            //on en prend 1 
            x = val;
            a.RemoveAt(idx);
            if (idx == a.Count)
            {
                idx = 0;
            }
            //puis 2;
            y = a[idx].Min;
            //il y en qu'un seul: 1 puis 1
            if (a[idx].Min == a[idx].Max)
            {
                a.RemoveAt(idx);
                if (idx == a.Count)
                {
                    idx = 0;
                }
                z = a[idx].Min;
                if (a[idx].Min == a[idx].Max)
                {
                    a.RemoveAt(idx);
                }
                else
                {
                    a[idx] = new Range(a[idx].Min+1, a[idx].Max);
                }
                return (x, y, z);
            }
            
            z = a[idx].Min + 1;
            if (a[idx].Min + 1 == a[idx].Max)
            {
                a.RemoveAt(idx);
            }
            else
            {
                a[idx] = new Range(a[idx].Min+2, a[idx].Max);
            }

            return (x, y, z);
        }

        private static int GetNextAfter(List<Range> a, int val)
        {
            int idx = IndexOf(a, val);
            if (a[idx].Max == val) {
                if (++idx == a.Count)
                {
                    idx= 0;
                }

                val = a[idx].Min;
            }
            else {
                val++;
            }

            return val;
        }

        private static void AddAfter(List<Range> a, int val, int x, int y, int z)
        {
            int idx = IndexOf(a, val);
            if (y == x + 1 && z == y + 1)
            {
                //On splitte en deux si besoin
                if (a[idx].Max != val) {
                    a.Insert(idx+1, new Range(val+1, a[idx].Max));
                    a[idx] = new Range(a[idx].Min, val);
                }
                a.Insert(idx+1, new Range(x, z));
                return;
            }

            var ranges = new[] {new Range(x), new Range(y), new Range(z)};
            //On splitte en deux si besoin
            if (a[idx].Max != val) {
                a.Insert(idx+1, new Range(val+1, a[idx].Max));
                a[idx] = new Range(a[idx].Min, val);
            }
            a.InsertRange(idx+1, ranges);
        }

        private static void Print(IReadOnlyList<Range> a)
        {
            Console.WriteLine(String.Join(" ", a));
        }
        private static void exo2()
        {
            var start = test.ToList();

            var nums = start.Select(i => new Range(i)).Concat(new[] {new Range(10, 1000000)}).ToList();
            int currentCup = nums[0].Min;

            for (int i = 0; i < 10000000; i++)
            {
               /* if (i % 1000 == 0)
                {
                    Print(nums);
                }*/
               if (i % 10000 == 0)
               {
                   Console.WriteLine($"{i} : {nums.Count}");
               }

                var three = TakeNext3(currentCup, nums);
                

                //select desctrination
                int destCup = currentCup;
                destCup--;
                if (destCup == 0) {
                    destCup = 1000000;
                }

                while (destCup == three.x || destCup == three.y || destCup == three.z)
                {
                    destCup--;
                    if (destCup == 0) {
                        destCup = 1000000;
                    }
                }
                /*if (i % 1000 == 0)
                {
                    Console.WriteLine($"pick up after {currentCup}: {three.x}, {three.y}, {three.z} to {destCup}");
                }*/
                AddAfter(nums, destCup,three.x, three.y, three.z);
                currentCup = GetNextAfter(nums,currentCup);

            }
            Print(nums);

        }
    }
}
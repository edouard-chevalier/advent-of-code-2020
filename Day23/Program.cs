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
            exo1();
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

        private static void Print(IReadOnlyList<int> a)
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
    }
}
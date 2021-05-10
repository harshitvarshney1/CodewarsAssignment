using System;
using System.Collections.Generic;
using System.Linq;

namespace Delete_occurance
{
    class Kata
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            var res = new List<int>();

            foreach (var n in arr)
            {
                if (res.Count(i => i == n) < x)
                {
                    res.Add(n);
                }
            }
            res.ForEach(i => Console.WriteLine(i.ToString()));
            return res.ToArray();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Kata.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);
        }
    }
}

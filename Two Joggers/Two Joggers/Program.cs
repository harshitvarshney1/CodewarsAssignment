using System;

namespace Two_Joggers
{
    class Kata
    {
        public static Tuple<int, int> NbrOfLaps(int x, int y)
        {
            int lcm = 1, i;
            int max = (x > y) ? x : y;
            for (i = max; ; i += max)
            {
                if (i % x == 0 && i % y == 0)
                {
                    lcm = i;
                    break;
                }
            }
            int a = lcm / x;
            int b = lcm / y;

            return new Tuple<int, int>(a, b);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.NbrOfLaps(3, 5));
        }
    }
}

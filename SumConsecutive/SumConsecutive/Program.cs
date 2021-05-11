using System;
using System.Collections.Generic;

namespace SumConsecutive
{
    class Program
    {     
        static void Main(string[] args)
        {
            var sc = SumConsecutives(new List<int>() { 1, 1, 3, 4,4, 7, 2, 2, 4, 4 });
            sc.ForEach(i => Console.WriteLine(i.ToString()));
        }
        public static List<int> SumConsecutives(List<int> s)
        {
            List<int> ret = new List<int>();
            int last = s[0], sum = 0;
            foreach (int i in s)
            {
                if (i == last) sum += last;
                else
                {
                    ret.Add(sum);
                    sum = last = i;
                }
            }
            ret.Add(sum);
            return ret;
        }
    }
    
}

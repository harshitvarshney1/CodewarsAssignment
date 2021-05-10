﻿using System;

namespace Enough_is_Enough
{
    class Program
    {
        public static void Main()
        {
            //Initialize array   
            int[] arr = new int[] { 1, 2, 8, 3, 2, 2, 2, 5, 1 };
            //Array fr will store frequencies of element  
            int[] fr = new int[arr.Length];
            int limit = 2;
            int visited = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        //To avoid counting same element again  
                        fr[j] = visited;
                    }
                }
                if (fr[i] != visited)
                    fr[i] = count;
            }

            //Displays the frequency of each element present in array  
            Console.WriteLine("---------------------");
            Console.WriteLine(" Element | Frequency");
            Console.WriteLine("---------------------");
            for (int i = 0; i < fr.Length; i++)
            {
                if (fr[i] != visited && fr[i]<=limit)
                    Console.WriteLine("    " + arr[i] + "    |    " + fr[i]);
            }
            Console.WriteLine("---------------------");
        }
    }
}

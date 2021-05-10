using System;

namespace Sumofdifferencebtpandhcf
{
    public class Program
    {
        public static void SumDifferencesBetweenProductsAndLCMs(int[,] arr)
        {
            int m = arr.GetLength(0);
            int lcm = 0, x, y;
            int n = arr.GetLength(1);
            Console.WriteLine(m);
            Console.WriteLine(n);
            int[] arr_product = new int[m];
            int[] arr_lcm = new int[m];
            int sum = 0;
            int product = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    product *= arr[i, j];
                }

                arr_product[i] = product;
                product = 1;
            }
            for (int i = 0; i < arr_product.Length; i++)
            {
                Console.WriteLine(arr_product[i]);
            }
            for (int i = 0; i < m; i++)
            {
                int k = 0;

                x = arr[i, k];
                y = arr[i, k + 1];
                while (arr[i, k] != arr[i, k + 1])
                {
                    if (arr[i, k] > arr[i, k + 1])
                    {
                        arr[i, k] = arr[i, k] - arr[i, k + 1];
                    }
                    else
                    {
                        arr[i, k + 1] = arr[i, k + 1] - arr[i, k];
                    }
                }
                lcm = (x * y) / arr[i, k];
                arr_lcm[i] = lcm;
            }
            for (int i = 0; i < arr_product.Length; i++)
            {
                Console.WriteLine(arr_lcm[i]);
            }
            for (int i = 0; i < m; i++)
            {
                sum += arr_product[i] - arr_lcm[i];
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
           // int[,] arr = new int[,] { { 15, 18 }, { 4, 5 }, { 12, 60 } };
            SumDifferencesBetweenProductsAndLCMs(new int[,] { { 15, 18 }, { 4, 5 }, { 12, 60 } });
        }
    }
}

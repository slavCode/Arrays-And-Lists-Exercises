using System;
using System.Linq;

namespace FoldAndSum
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = input.Length / 4;

            int[] firstRow = new int[k * 2];
            int[] secondRow = new int[k * 2];
            for (int i = 0; i < k; i++)
            {
                firstRow[i] = input[k - 1 - i];
            }
            for (int i = 0; i < k; i++)
            {
                firstRow[k + i] = input[((k * 4) - 1) - i];
            }

            for (int i = 0; i < k * 2; i++)
            {
                secondRow[i] = input[k + i];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                Console.Write(firstRow[i] + secondRow[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

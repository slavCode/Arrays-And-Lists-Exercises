using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateaAndSum
{
    internal class Program
    {
        static void Main()
        {
            long[] sequence = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            long[] sum = new long[sequence.Length];

            for (int i = 0; i < rotations; i++)
            {
                var lastNum = sequence.Skip(sequence.Length - 1).Take(1).ToArray();
                var otherNums = sequence.Take(sequence.Length - 1).ToArray();
                var sumArr = lastNum.Concat(otherNums).ToArray();
                for (int k = 0; k < sumArr.Length; k++)
                {
                    sum[k] += sumArr[k];

                }
                sequence = sumArr;


            }
            Console.WriteLine(string.Join(" ", sum));

        }
    }
}

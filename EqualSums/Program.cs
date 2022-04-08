using System;
using System.Linq;

namespace EqualSums
{
    internal class Program
    {
        static void Main()
        {
            //50/100 pts
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (numbers.Length == 1) Console.WriteLine("0");
            else if (numbers.Length <= 3) Console.WriteLine("no");
            else
            {

                int leftSum = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    leftSum += numbers[i];

                    int rightSumIndex = i + 1;
                    int rightSum = numbers[rightSumIndex + 1];
                    for (int j = rightSumIndex; j < numbers.Length - 2; j++)
                    {
                        int num = numbers[j + 2];
                        rightSum += num;
                        if (rightSum > leftSum) break;
                    }

                    if (leftSum == rightSum)
                    {
                        Console.WriteLine(i + 1);
                        break;
                    }

                }
            }
        }
    }
}

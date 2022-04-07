using System;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bestLen = 1;
            int bestStart = 0;
            int currLength = 1;
            int currStart = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                int number = numbers[i];
                int prevNum = numbers[i - 1];
                if (number > prevNum)
                {
                    currLength++;
                    if (currLength > bestLen)
                    {
                        bestLen = currLength;
                        bestStart = currStart;
                    }
                }
                else
                {
                    currLength = 1;
                    currStart = i;
                }
            }

            for (int i = bestStart; i < bestLen + bestStart; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

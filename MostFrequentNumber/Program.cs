using System;
using System.Linq;

namespace MostFrequentNumber
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bestCounter = 0;
            int mostFreqNum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currCounter = 0;

                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    if (numbers[i] == numbers[j]) currCounter++;
                }

                if (currCounter > bestCounter)
                {
                    bestCounter = currCounter;
                    mostFreqNum = numbers[i];
                }
            }
            Console.WriteLine(mostFreqNum);
        }
    }
}

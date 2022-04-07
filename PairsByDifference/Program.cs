using System;
using System.Linq;

namespace PairsByDifference
{
    internal class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int numToCompare = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (Math.Abs(numToCompare - numbers[j]) == diff) counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}

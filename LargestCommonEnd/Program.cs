using System;
using System.Linq;

namespace LargestCommonEnd
{
    internal class Program
    {
        static void Main()
        {
            var firstLine = Console.ReadLine().Split().ToArray();
            var secondLine = Console.ReadLine().Split().ToArray();

            var longestLine = GetLineWithLongestCount(firstLine, secondLine);
            var shortestLine = GetLineWithShortestCount(firstLine, secondLine);

            int diffrence = longestLine.Length - shortestLine.Length;
            int count = 0;
            for (int i = 0; i < shortestLine.Length; i++)
            {
                if (firstLine[i] == secondLine[i]) count++;
            }

            if (diffrence != 0)
            {
                for (int i = longestLine.Length - 1; i >= diffrence; i--)
                {
                    if (longestLine[i] == shortestLine[i - diffrence]) count++;
                }
            }

            Console.WriteLine(count);
        }

        private static string[] GetLineWithLongestCount(string[] firstLine, string[] secondLine)
        {
            if (firstLine.Length > secondLine.Length) return firstLine;
            return secondLine;
        }

        private static string[] GetLineWithShortestCount(string[] firstLine, string[] secondLine)
        {
            if (firstLine.Length < secondLine.Length) return firstLine;
            return secondLine;
        }
    }
}

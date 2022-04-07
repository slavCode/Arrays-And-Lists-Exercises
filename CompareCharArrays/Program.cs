using System;
using System.Collections.Generic;
using System.Linq;

namespace CompareCharArrays
{
    internal class Program
    {
        static void Main()
        {
            string[] firstRow = Console.ReadLine().Split(' ').ToArray();
            string[] secondRow = Console.ReadLine().Split(' ').ToArray();

            List<char> firstLetters = new List<char>();
            List<char> secondLetters = new List<char>();

            for (int i = 0; i < firstRow.Length; i++)
            {
                firstLetters.Add(char.Parse(firstRow[i]));
            }
            for (int i = 0; i < secondRow.Length; i++)
            {
                secondLetters.Add(char.Parse(secondRow[i]));
            }

            bool areDifferent = false;
            int len = Math.Min(firstLetters.Count, secondLetters.Count);
            for (int i = 0; i < len; i++)
            {
                if (firstLetters[i] > secondLetters[i])
                {
                    Console.WriteLine(String.Join("", secondRow));
                    Console.WriteLine(String.Join("", firstRow));
                    areDifferent = true;
                    break;
                }

                else if (firstLetters[i] < secondLetters[i])
                {
                    Console.WriteLine(String.Join("", firstRow));
                    Console.WriteLine(String.Join("", secondRow));
                    areDifferent = true;
                    break;
                }
            }
            if (!areDifferent)
            {
                if (firstLetters.Count >= secondLetters.Count)
                {
                    Console.WriteLine(String.Join("", secondRow));
                    Console.WriteLine(String.Join("", firstRow));
                }
                else
                {
                    Console.WriteLine(String.Join("", secondRow));
                    Console.WriteLine(String.Join("", firstRow));
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    internal class Program
    {
        static void Main()
        {
            //var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //var inputBombAndPower = Console.ReadLine().Split();

            //int bomb = int.Parse(inputBombAndPower[0]);
            //int power = int.Parse(inputBombAndPower[1]);

            //int bombLength = power * 2 + 1;
            //int bombStartIndex = bomb - power;
            //int bombEndIndex = bomb + power;

            //int sum = 0;

            //var numbersAfterBomb = new List<int>();
            //for (int i = bombStartIndex; i < numbers.Count; i++)
            //{
            //    if (bombStartIndex + bombLength > numbers.Count)
            //    {
            //        bombLength = numbers.Count - bombStartIndex;
            //    }
            //    numbers.RemoveRange(i, bombLength);

            //    //bombStartIndex = bombEndIndex;
            //    bombEndIndex += bombLength;
            //}

            //foreach (var item in numbers)
            //{
            //    sum += item;
            //}

            //Console.WriteLine(sum);



            List<long> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            numbers = RemoveBombedNumbers(numbers);
            Console.WriteLine(numbers.Sum());



        }

        private static List<long> RemoveBombedNumbers(List<long> numbers)
        {
            int[] bombData = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int bombNumber = bombData[0];
            int bombRange = bombData[1];

            while (numbers.IndexOf(bombNumber) != -1)
            {
                int bombIndex = numbers.IndexOf(bombNumber);
                int bombRangeStart = Math.Max(bombIndex - bombRange, 0);
                int bombRangeEnd = Math.Min(bombIndex + bombRange, numbers.Count - 1);
                numbers.RemoveRange(bombRangeStart, bombRangeEnd - bombRangeStart + 1);
            }
            return numbers;
        }
    }
}

using System;
using System.Linq;

namespace SumReversedNumbers
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToList();

            var result = 0;
            foreach (var item in input)
            {
                char[] charArray = item.ToCharArray();
                Array.Reverse(charArray);

                string reversedStr = new string(charArray);
                int reversedInt = int.Parse(reversedStr);

                result += reversedInt;
            }

            Console.WriteLine(result);
        }
    }
}

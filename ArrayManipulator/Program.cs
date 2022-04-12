using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    internal class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = "";
            while (command != "print")
            {
                var input = Console.ReadLine().Split();
                command = input[0];
                int index = int.Parse(input[1]);
                int element = 0;
                switch (command)
                {
                    case "add":
                        element = int.Parse(input[2]);

                        numbers[index] = element;
                        break;

                    case "addMany":
                        var elements = new List<int>();
                        for (int i = 1; i < input.Length; i++) elements.Add(i);

                        numbers.InsertRange(index, elements);
                        break;

                    case "contains":
                        Console.WriteLine(numbers.IndexOf(index));
                        break;

                    case "remove":
                        numbers.RemoveAt(index);
                        break;

                    case "shift":
                        var shiftedNums = new List<int>();
                        for (int i = 0; i < numbers.Count % index; i++)
                        {
                            numbers.Insert(i, numbers[i - numbers.Count - 1]);
                        }
                        break;

                    case "sumPairs":
                        break;

                    case "print":
                        Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        return;
                }
            }
        }
    }
}

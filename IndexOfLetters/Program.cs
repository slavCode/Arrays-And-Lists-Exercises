using System;

namespace IndexOfLetters
{
    internal class Program
    {
        static void Main()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            var alphabetArr = new char[alphabet.Length];
            for (int i = 0; i < alphabet.Length; i++) alphabetArr[i] = alphabet[i];

            var input = Console.ReadLine();
            var inputChar = new char[input.Length];
            for (int i = 0; i < input.Length; i++) inputChar[i] = input[i];

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabetArr.Length; j++)
                {
                    if (inputChar[i] == alphabetArr[j]) Console.WriteLine($"{inputChar[i]} -> {j}");
                }
            }
        }
    }
}

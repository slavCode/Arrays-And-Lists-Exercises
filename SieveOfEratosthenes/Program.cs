using System;

namespace SieveOfEratosthenes
{
    internal class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            bool[] primes = new bool[number + 1];

            primes[0] = false;
            primes[1] = false;
            for (int i = 2; i < number; i++) primes[i] = true;

            for (int i = 2; i < number; i++)
            {
                if (primes[i])
                    for (int p = 2 * i; p <= number; p += i)
                        primes[p] = false;
            }

            for (int j = 2; j < number; j++)
            {
                if (primes[j]) Console.Write(j + " ");

            }
            Console.WriteLine();
        }
    }
}

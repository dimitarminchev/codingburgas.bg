using System;

namespace RationalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < line.Length; i+=2) 
            {
                RationalNumber rationalNumber = new RationalNumber(line[i], line[i + 1]);

                Console.Write(rationalNumber.ToString() + "; ");
            }
            Console.WriteLine();

        }
    }
}
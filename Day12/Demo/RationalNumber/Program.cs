using System;

namespace RationalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<string> result = new List<string>();

            for (int i = 0; i < line.Length; i+=2) 
            {
                RationalNumber rationalNumber = new RationalNumber(line[i], line[i + 1]);

                result.Add(rationalNumber.ToString());
            }

            Console.WriteLine(string.Join("; ", result));
        }
    }
}
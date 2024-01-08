using System;

namespace EvenNumber
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < line.Length; i++)
            {
                if (EvenNumber.isEven(line[i]))
                {
                    Console.Write(line[i] + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}
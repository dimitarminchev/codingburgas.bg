using System;

namespace factoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong sum = 1;
            for (ulong i = 1; i < (n+1); i++) 
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}
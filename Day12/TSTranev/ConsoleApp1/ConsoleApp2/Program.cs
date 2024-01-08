using System;

namespace MyApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] l = input.Select(c => int.Parse(c.ToString())).ToArray();

            for(int i = 0; i < l.Length; i+=2)
            {
                if (l[i] == l.Length - 1)
                {
                    Console.Write(l[i] + "/" + l[i + 1]);
                    break;
                }
                Console.Write(l[i] + "/" + l[i+1]+";");
            }
        }
    }
}
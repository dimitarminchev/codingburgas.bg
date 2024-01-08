using System;

namespace EvenNumber
{
    internal class Program
    {
       public static class Even
        {
            public static bool isOk(int l, int k)
            {
               if(l % k == 0)
                {
                    return true;
                }
               return false;
                  
            }
        }

        static void Main(string[] args) {
            string input = Console.ReadLine();
            int[] l = input.Select(c => int.Parse(c.ToString())).ToArray();
            int k = int.Parse(input);
            for (int i = 0; i < l.Length; i++)
            {
                Even.isOk(l[i], k);
                if (Even.isOk(l[i], k))
                {
                    Console.Write(l[i] + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}
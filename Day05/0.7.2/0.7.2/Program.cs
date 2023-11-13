using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace _0._7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int maxLead = 0; int Winner = 0;
            for (int i = 0; i < a; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int s = int.Parse(line[0]), t = int.Parse(line[1]);
                int lead = s - t;
                if (lead < 0)
                {
                    lead *= -1;
                }
                if (lead > maxLead)
                {
                    maxLead = lead;
                    if (s > t)
                    {
                        Winner = 1;
                    }
                    else
                    {
                        Winner = 2;
                    }
                }
            }
            Console.WriteLine($"{Winner} {maxLead}");
        }
    }
}
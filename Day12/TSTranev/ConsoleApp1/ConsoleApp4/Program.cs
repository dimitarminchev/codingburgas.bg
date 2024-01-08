namespace ConsoleApp4
{
    internal class Program
    {
        public static class EvenNumber
        {
            public static bool isEven(int n)
            {
                if (n % 2 == 0)
                {
                    return true;
                }
                return false;
            }
        }
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
}
namespace KNumber
{
    internal class Program
    {
        public class KNumber 
        {
            public static bool isDividable(int a, int b)
            {
                if (a % b == 0) 
                {
                    return true;
                }
                return false;
            }
        }

        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            List<int> result = new List<int>();

            for (int i = 0; i < line.Length; i++)
            {
                if (KNumber.isDividable(line[i], k)) 
                {
                    result.Add(line[i]);
                }
            }

            Console.WriteLine(string.Join(',', result));

        }
    }
}
namespace KNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < line.Length; i++)
            {
                if (KNumber.isDividable(line[i], k)) 
                {
                    numbers.Add(line[i]);
                }
            }

            Console.WriteLine(string.Join(",", numbers));

        }
    }
}
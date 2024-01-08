namespace EvenNumber
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<int> ints = new List<int>();

            for (int i = 0; i < line.Length; i++)
            {
                if (EvenNumber.isEven(line[i]))
                {
                    ints.Add(line[i]);
                }
            }

            Console.WriteLine(string.Join(",", ints));
        }
    }
}
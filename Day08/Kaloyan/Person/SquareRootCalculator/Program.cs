namespace SquareRootCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                list.Add(num);
            }

            foreach (int num in list) 
            {
                Console.WriteLine(SquareRootCalculator.GetRoot(num));
            }
        }
    }
}
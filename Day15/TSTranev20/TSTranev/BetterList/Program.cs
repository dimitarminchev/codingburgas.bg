namespace BetterList
{
    public class Program
    {
        static void Main(string[] args)
        {
            BetterList<int> list = new BetterList<int>();

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rand.Next(1, 100));
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", list.Get(i));
            }

            Console.WriteLine();

            Console.WriteLine("Min = {0}", list.Min());
            Console.WriteLine("Max = {0}", list.Max());
        }
    }
}
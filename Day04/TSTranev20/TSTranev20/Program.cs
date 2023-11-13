namespace TSTranev20
{
    public partial class Program
    {

        public static void Main(string[] args)
        {
            Dice a = new();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(a.Roll());
            }

            a.PrintFrequency();
        }
    }
}
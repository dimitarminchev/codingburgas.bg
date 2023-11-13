namespace Dice;

class Program
{
    static void Main(string[] args)
    {
        Dice d6 = new();
        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine(d6.Roll());
        }

        d6.PrintFrequency();
    }
}

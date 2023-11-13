namespace Dice
{
    /// <summary>
    /// Главна програма
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Dice dice = new Dice();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(dice.Roll());
            }
            dice.PrintFrequency();
        }
    }
}
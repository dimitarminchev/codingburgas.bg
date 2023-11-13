using System.Runtime.CompilerServices;

namespace Dice
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            int sides = int.Parse(Console.ReadLine());
            Console.WriteLine(dice.Roll(sides));
            Console.WriteLine();
            dice.Roll10(sides);
        }
    }
}
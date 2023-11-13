namespace Dice;

public class Dice
{
    public int sides;
    private Random rnd = new();
    private int[] rollFrequency;

    public Dice(int sides = 6)
    {
        this.sides = sides;
    }

    public int Roll()
    {
        int rollResult = rnd.Next(1, sides + 1);
        this.rollFrequency[rollResult]++;
        return rollResult;
    }

    public void PrintFrequency()
    {
        for (int i = 0; i < rollFrequency.Length; i++)
        {
            Console.WriteLine($"{i} => {rollFrequency[i]}");
        }
    }
}

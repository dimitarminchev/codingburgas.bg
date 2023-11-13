namespace Dice
{
    public class Dice
    {
        private int[] rollFrequency;

        private Random rnd = new Random();

        public int sides;

        public Dice(int sides = 6)
        {
            this.sides = sides;
            this.rollFrequency = new int[sides + 1];
        }

        public int Roll()
        {
            int rollResult = rnd.Next(1, this.sides + 1);
            this.rollFrequency[rollResult]++;
            return rollResult;
        }

        public void PrintFrequency()
        {
            for(int i = 1; i <= this.sides; i++)
            {
                Console.WriteLine($"{i} => {this.rollFrequency[i]}");
            }
        }
    }
}
namespace Dice
{
    public partial class Program
    {
        public class Dice
        {
            private int sides;

            private int[] rollFrequency;

            private Random random = new Random();
            public Dice(int sides = 6)
            {
                this.sides = sides;
                this.rollFrequency = new int[sides+1];
            }
            public int Roll(int sides)
            {
                int randomResult = random.Next(1, sides + 1);
                this.rollFrequency[randomResult]++;
                return randomResult;
            }
            public void RollFrequency() 
            {
                for (int i = 10; i <= this.sides; i++) 
                {
                    Console.WriteLine($"{i} => {this.rollFrequency[i]}");
                }
            }
            public void Roll10(int sides)
            {
                for (int i = 0; i < 10; i++) 
                {
                    Console.WriteLine(random.Next(1, sides + 1));
                }
            }
        }
    }
}
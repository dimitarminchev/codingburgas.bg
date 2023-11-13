namespace GAIvanova20
{
    public partial class Program
    {
        public class Dice 
        {
            private int sides;
            
            private int[] rollFrequency;

            private Random rnd = new Random();

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
                for (int i = 0; i < rollFrequency.Length; i++)
                {
                    Console.WriteLine($"{i} => {rollFrequency[i]}");
                }
            }
        }
    }
}
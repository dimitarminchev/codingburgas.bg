namespace Dice
{
    /// <summary>
    /// Зарче
    /// </summary>
    public class Dice
    {
        /// <summary>
        /// Страни
        /// </summary>
        public int sides;

        private int[] rollFrequency;

        private Random rnd = new Random();

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sides">Брой страни</param>
        public Dice(int sides = 6)
        {
            this.sides = sides;
            this.rollFrequency = new int[sides + 1];
        }

        /// <summary>
        /// Хвърляне на зара
        /// </summary>
        /// <returns>Случайно число от 1 до броя страни</returns>
        public int Roll()
        {
            int rollResult = rnd.Next(1, this.sides + 1);
            this.rollFrequency[rollResult]++;
            return rollResult;
        }

        /// <summary>
        /// Отпечатваме брой пъти, които е паднало всяко число
        /// </summary>
        public void PrintFrequency()
        {
            for (int i = 1; i <= this.sides; i++)
            {
                Console.WriteLine($"{i} => {this.rollFrequency[i]}");
            }
        }
    }
}
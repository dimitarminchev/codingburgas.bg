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

        private Random rnd = new Random();

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sides">Брой страни</param>
        public Dice(int sides = 6)
        {
            this.sides = sides;
        }

        /// <summary>
        /// Хвърляне на зара
        /// </summary>
        /// <returns>Случайно число от 1 до броя страни</returns>
        public int Roll()
        {
            int rollResult = rnd.Next(1, this.sides + 1);
            return rollResult;
        }
    }
}
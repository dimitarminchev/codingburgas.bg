namespace SquareRootPrecalculator
{
    /// <summary>
    /// Клас за пресмятане на корени
    /// </summary>
    public static class SquareRootPrecalculator
    {
        // Максимална стойност, за която ще пресмятаме корените
        public const int MaxValue = 100000;

        // Масив, в който ще пазим пресметнатите стойности
        private static double[] sqrtValues;

        /// <summary>
        /// Статичен конструктор, в който ще пресметнем корените
        /// </summary>
        static SquareRootPrecalculator()
        {
            sqrtValues = new double[MaxValue + 1];
            for (int i = 1; i <= MaxValue; i++)
            {
                sqrtValues[i] = Math.Sqrt(i);
            }
        }

        /// <summary>
        /// Връща корен квадратен корен от дадено число
        /// </summary>
        /// <param name="value">Числото</param>
        /// <returns>Корен квадратен на числото</returns>
        public static double GetSqrt(int value)
        {
            return sqrtValues[value];
        }
    }
}

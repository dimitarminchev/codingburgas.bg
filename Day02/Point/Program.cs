namespace Point
{
    /// <summary>
    /// Главна програма
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Изчисляване на разстоянията между две точки
        /// </summary>
        private static double R(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
        }

        /// <summary>
        /// Главен метод
        /// </summary>
        public static void Main(string[] args)
        {
            Point a = new Point(0,0);
            Point b = new Point(2,2);

            Console.WriteLine("R = {0}", R(a,b));
        }    
    }
}
namespace Figures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Кръг
            Console.Write("R=");
            int radius = int.Parse(Console.ReadLine());

            IDrawable circle = new Circle(radius);

            circle.Draw();

            // Правоъгълник
            Console.Write("W=");
            int width = int.Parse(Console.ReadLine());
            Console.Write("H=");
            int height = int.Parse(Console.ReadLine());

            IDrawable rect = new Rectangle(width, height);

            rect.Draw();
        }
    }
}

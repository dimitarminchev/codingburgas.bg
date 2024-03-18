namespace Figures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Rectangle
            Rectangle rectangle = new Rectangle(4,5);
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine("Perimeter = {0}", rectangle.calculatePerimeter());
            Console.WriteLine("Area = {0}", rectangle.calculateArea());

            // Circle
            Circle circle = new Circle(2.5);
            Console.WriteLine(circle.Draw());
            Console.WriteLine("Perimeter = {0}", circle.calculatePerimeter());
            Console.WriteLine("Area = {0}", circle.calculateArea());
        }
    }
}

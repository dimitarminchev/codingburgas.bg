namespace GAIvanova20
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 4);
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine("P = " + rectangle.calculatePerimeter());
            Console.WriteLine("S = " + rectangle.calculateArea());

            Circle circle = new Circle(3);
            Console.WriteLine(circle.Draw());
            Console.WriteLine("C = " + circle.calculatePerimeter());
            Console.WriteLine("S = " + circle.calculateArea());
        }
    }
}
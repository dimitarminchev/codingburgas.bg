namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(';').ToArray();
            switch (line[0]) 
            {
                case "Square perimeter":
                    Console.WriteLine(Geometry.SquarePerimeter(double.Parse(line[1])));
                    break;
                case "Square area":
                    Console.WriteLine(Geometry.SquareArea(double.Parse(line[1])));
                    break;
                case "Rectangle perimeter":
                    Console.WriteLine(Geometry.RectanglePerimeter(double.Parse(line[1]), double.Parse(line[2])));
                    break;
                case "Rectangle area":
                    Console.WriteLine(Geometry.RectangleArea(double.Parse(line[1]), double.Parse(line[2])));
                    break;
                case "Circle area":
                    Console.WriteLine(Geometry.CircleArea(double.Parse(line[1])));
                    break;
                default:
                    Console.WriteLine("Incorrect input!");
                    break;
            }
        }
    }
}
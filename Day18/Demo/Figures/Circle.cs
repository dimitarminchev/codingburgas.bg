namespace Figures
{
    public class Circle : Shape
    {
        public double radius { get; set; }

        public Circle(double r = 0)
        {
            radius = r;
        }

        public override double calculatePerimeter() => 2 * Math.PI * radius;

        public override double calculateArea() => Math.PI * radius * radius;

        public override string Draw()
        {
            return string.Format("{0} -> Circle: Radius = {1}", base.Draw(), radius);
        }
    }
}

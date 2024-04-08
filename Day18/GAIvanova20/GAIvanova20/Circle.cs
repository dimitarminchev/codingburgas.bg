namespace GAIvanova20
{
    public partial class Program
    {
        public class Circle : Shape
        {
            public double radius { get; set; }

            public Circle(double radius = 1)
            {
                this.radius = radius;
            }

            public override double calculatePerimeter()
            {
                return 2 * Math.PI * radius;
            }
            public override double calculateArea()
            {
                return radius * radius;
            }

            public override string Draw()
            {
                return base.Draw() + " -> Circle: r = " + radius;
            }

        }
    }
}
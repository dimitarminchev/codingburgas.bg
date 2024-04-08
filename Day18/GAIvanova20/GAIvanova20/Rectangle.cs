namespace GAIvanova20
{
    public partial class Program
    {
        public class Rectangle : Shape 
        {
            public double height { get; set; }
            public double width { get; set; }

            public Rectangle(double height = 1, double width = 1)
            {
                this.height = height;
                this.width = width;
            }

            public override double calculatePerimeter() 
            {
                return 2 * (height + width);
            }
            public override double calculateArea()
            { 
                return height * width;
            }

            public override string Draw() 
            {
                return base.Draw() + " -> Rectangle: a = " + height + " b = " + width;
            }

        }
    }
}
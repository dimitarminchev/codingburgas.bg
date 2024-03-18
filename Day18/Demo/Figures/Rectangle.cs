namespace Figures
{
    public class Rectangle : Shape
    {
        public int height { get; set; }

        public int width { get; set; }

        public Rectangle(int h = 0, int w = 0)
        {
            height = h;
            width = w;
        }

        public override double calculatePerimeter() => 2 * (height + width);

        public override double calculateArea() => height * width;

        public override string Draw()
        {
            return string.Format("{0} -> Rectangle: Height = {1}, Width = {2}", base.Draw(), height, width);
        }
    }
}

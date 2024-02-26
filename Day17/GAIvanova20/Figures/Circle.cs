namespace Figures
{
    public partial class Program
    {
        public class Circle : IDrawable
        {
            private int radius;

            public Circle(int radius = 0)
            {
                this.radius = radius;
            }

            public void Draw()
            {
                double rIn = this.radius - 0.4;
                double rOut = this.radius + 0.4;

                for (double y = this.radius; y >= -this.radius; --y) 
                {
                    for (double x = -this.radius; x < rOut; x += 0.5) 
                    {
                        double val = x * x + y * y;

                        if (val >= rIn * rIn && val <= rOut * rOut)
                        {
                            Console.Write("*");
                        }
                        else 
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                }

            }
        }
    }
}
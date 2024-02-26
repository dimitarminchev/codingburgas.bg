namespace Figures
{
    public partial class Program
    {
        public class Rectangle : IDrawable
        {
            private int width;
            private int height;

            public Rectangle(int width = 0, int height = 0)
            {
                this.width = width;
                this.height = height;
            }

            private void DrawLine(int width, char end, char mid) 
            {
                Console.Write(end);
                for (int i = 1; i < width - 1; ++i) 
                {
                    Console.Write(mid);
                }
                Console.Write(end);
            }

            public void Draw() 
            {
                DrawLine(this.width, '*', '*');
                Console.WriteLine();

                for (int i = 1; i < this.height - 1; ++i) 
                {
                    DrawLine(this.width, '*', ' ');
                    Console.WriteLine();
                }
                DrawLine(this.width, '*', '*');
            }
        }
    }
}
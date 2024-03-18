namespace Figures
{
    public class Rectangle : IDrawable
    {
        private int Width, Height;

        public Rectangle(int wid, int hei)
        {
            Width = wid;
            Height = hei;
        }

        public void Draw()
        {
            DrawLine(this.Width, '*', '*');
            for (int i = 1; i < this.Height - 1; ++i)
                DrawLine(this.Width, '*', ' ');
            DrawLine(this.Width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
                Console.Write(mid);
            Console.WriteLine(end);
        }

    }
}

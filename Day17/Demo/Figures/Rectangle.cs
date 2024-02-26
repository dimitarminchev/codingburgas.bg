namespace Figures
{
    /// <summary>
    /// Правоъгълник
    /// </summary>
    public class Rectangle : IDrawable
    {
        private int Width, Height;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="w">Широчина</param>
        /// <param name="h">Височина</param>
        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }

        /// <summary>
        /// Рисувай
        /// </summary>
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

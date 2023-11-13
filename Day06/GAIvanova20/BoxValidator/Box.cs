using System.Text;

namespace BoxValidator
{
    public partial class Program
    {
        public class Box 
        {
            private double width;

            public double Width
            {
                get { return width; }
                set 
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Width cannot be zero or negative.");
                    }
                    width = value; 
                }
            }

            private double lenght;

            public double Lenght
            {
                get { return lenght; }
                set 
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Lenght cannot be zero or negative.");
                    }
                    lenght = value; 
                }
            }

            private double height;

            public double Height
            {
                get { return height; }
                set 
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Height cannot be zero or negative.");
                    }
                    height = value; 
                }
            }

            public Box(double width = 1, double height = 1, double lenght = 1)
            {
                this.Width = width;
                this.Height = height;
                this.Lenght = lenght;
            }

            public override string ToString()
            {
                StringBuilder strBuild = new StringBuilder();
                strBuild.Append($"S1 = {2 * lenght * width + 2 * lenght * height + 2 * width * height}" + Environment.NewLine);
                strBuild.Append($"S = {2 * lenght * height + 2 * width * height}" + Environment.NewLine);
                strBuild.Append($"V = {lenght * width * height}" + Environment.NewLine);
                return strBuild.ToString();
            }
        }
    }
}
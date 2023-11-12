 using System.Text;

namespace BoxValidator
{
    public class Box
    {
        private decimal l;

        public decimal L
        {
            get { return l; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }
                l = value; 
            }
        }

        private decimal h;

        public decimal H
        {
            get { return h; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                h = value; 
            }
        }

        private decimal w;

        public decimal W
        {
            get { return w; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                w = value; 
            }
        }

        public Box(decimal l, decimal h, decimal w)
        {
            this.L = l;
            this.H = h;
            this.W = w;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Surface Area – {2 * l * w + 2 * l * h + 2 * w * h}" + Environment.NewLine);
            sb.Append($"Lateral Surface Area – {2 * l * h + 2 * w * h}" + Environment.NewLine);
            sb.Append($"Volume – {l * w * h}" + Environment.NewLine);
            return sb.ToString();
        }
    }
}

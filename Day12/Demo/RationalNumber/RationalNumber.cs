namespace RationalNumbers
{
    public class RationalNumber 
    {
        private int numerator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        private int denumerator;

        public int Denumerator
        {
            get { return denumerator; }
            set { denumerator = value; }
        }

        public RationalNumber(int n = 0, int d = 1)
        {
            int gcd = GCD(n, d);

            this.numerator = n / gcd;
            this.denumerator = d / gcd;
        }

        public override string ToString()
        {
            return numerator + "/" + denumerator;
        }

        public int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
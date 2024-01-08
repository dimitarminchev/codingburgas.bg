namespace RacionalNumber
{
    class RacionalNumber
    {
        private double numerator;

        public double Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        private double denuminator;

        public double Denuminator
        {
            get { return denuminator; }
            set { denuminator = value; }
        }

        public RacionalNumber(double numerator, double denumerator)
        {
            this.Numerator = numerator;
            this.Denuminator = denumerator;
        }
    }
}
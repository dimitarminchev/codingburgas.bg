namespace NumberK
{
    class EvenNumber
    {
        private double num;

        public double Num
        {
            get { return num; }
            set { 
                num = value; }
        }

        public EvenNumber(double num)
        {
            this.Num = num;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<EvenNumber> nums = new List<EvenNumber>();

            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            foreach (int i in input)
            {
                nums.Add(new EvenNumber(i));
            }

            int k = int.Parse(Console.ReadLine());
            foreach (var i in nums)
            {
                if (i.Num % k == 0)
                {
                    Console.Write(i.Num + " ");
                }
            }
        }
    }
}
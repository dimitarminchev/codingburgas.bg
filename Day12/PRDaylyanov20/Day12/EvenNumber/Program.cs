using System.Drawing;

namespace EvenNumber
{
    class EvenNumber
    {
        private double num;

        public double Num
        {
            get { return num; }
            set
            {
                if (value % 2 == 0)
                    num = value;
            }
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
                if (nums.Last().Num == 0)
                {
                    nums.RemoveAt(nums.Count - 1);
                }
            }

            foreach (var i in nums)
            {
                Console.Write(i.Num + " ");
            }
        }
    }
}
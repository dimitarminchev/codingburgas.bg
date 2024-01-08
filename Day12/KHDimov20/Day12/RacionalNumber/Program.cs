namespace RacionalNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exr 1
            /*List<RacionalNumber> numbers = new List<RacionalNumber>();
            for (int i = 0; i < 3; i++)
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                numbers.Add(new RacionalNumber(a,b));
            }

            foreach(var item in numbers)
            {
                Console.WriteLine(item.Numerator + "/" + item.Denuminator);
            }*/


            // Exr 2
            List<RacionalNumber> numbers = new List<RacionalNumber>();

            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < 6; i++)
            {
                numbers.Add(new RacionalNumber(input[i], input[i+1]));
                i++;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item.Numerator + "/" + item.Denuminator);
            }
        }
    }
}
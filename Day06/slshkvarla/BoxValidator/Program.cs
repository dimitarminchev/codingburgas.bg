namespace BoxValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input: 2 -3 4
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(lenght, height, width);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
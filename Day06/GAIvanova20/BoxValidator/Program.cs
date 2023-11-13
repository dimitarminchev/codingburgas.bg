namespace BoxValidator
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(width, height, lenght);
                Console.WriteLine(box);
            }
            catch(Exception error) 
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
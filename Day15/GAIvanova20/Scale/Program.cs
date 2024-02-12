namespace Scale
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            Scale<int> scale = new Scale<int>(2, 1);

            Console.WriteLine(scale.getHeavier());
        }
    }
}
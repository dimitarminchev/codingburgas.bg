namespace ArrayCreator
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            int []intItems = ArrayCreator.addItems(5, 2);
            foreach (int item in intItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            int counter;

            for (counter = 1; counter < 10; counter++) 
            {
                result *= counter;
            }
            Console.WriteLine(result);
        }
    }
}
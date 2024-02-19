namespace StackOfStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings som = new StackOfStrings();


            som.Push("1");
            som.Push("2");
            som.Push("3");

            Console.WriteLine(som.Pop());
        }
    }
}

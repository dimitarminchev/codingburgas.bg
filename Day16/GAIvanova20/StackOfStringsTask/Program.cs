namespace StackOfStringsTask
{
    public partial class Program
    {
        static void Main(string[] args)
        {
          StackOfStrings stackOfStrings = new StackOfStrings();

            stackOfStrings.Push("hello");
            stackOfStrings.Push("a");
            stackOfStrings.Push("b");

            Console.WriteLine(stackOfStrings.Pop());
        }
    }
}
namespace StackOfStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            // Добавяме 5 елемета към колекцията
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            stack.Push("four");

            // Извеждаме 3 елементи от колекцията
            Console.WriteLine(stack.Pop()); // four
            Console.WriteLine(stack.Pop()); // three
            Console.WriteLine(stack.Pop()); // two
        }
    }
}

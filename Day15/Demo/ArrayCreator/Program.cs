namespace ArrayCreator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Array of strings
            var words = ArrayCreator.Create(5, "Hello");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            // Array of integeres
            var numbers = ArrayCreator.Create(5, 12345);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

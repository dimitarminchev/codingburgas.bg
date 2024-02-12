namespace ArrayCreator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Array of strings
            var items = ArrayCreator.Create(5, "Hello");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            // Array of integeres
            var nums = ArrayCreator.Create(5, 12345);
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}

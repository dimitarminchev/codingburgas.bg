namespace MathOperation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Demonstrates methods overloading
            MathOperations mo = new MathOperations();

            Console.WriteLine(mo.Add(2, 3)); // 5
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5)); // 11
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m)); // 9.9
        }
    }
}

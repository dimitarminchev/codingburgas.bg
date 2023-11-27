namespace Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ').ToArray();
            int a = int.Parse(line[0]), b = int.Parse(line[1]);
            Console.WriteLine($"{a} + {b} = {Arithmetics.Add(a, b)}");
            Console.WriteLine($"{a} * {b} = {Arithmetics.Multiply(a, b)}");
            Console.WriteLine($"{a} - {b} = {Arithmetics.Subtract(a, b)}");
            Console.WriteLine($"{a} / {b} = {Arithmetics.Divide(a, b)}");
        }
    }
}
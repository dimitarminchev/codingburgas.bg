using System.Diagnostics;

namespace SquareRootPrecalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw1 = Stopwatch.StartNew();
            sw1.Start();
            Console.WriteLine($"Square root of 2 = {SquareRootPrecalculator.GetSqrt(2)}");
            sw1.Stop();
            Console.WriteLine($"Time taken: {sw1.ElapsedTicks}");
            Stopwatch sw2 = Stopwatch.StartNew();
            sw2.Start();
            Console.WriteLine($"Square root of 100 = {SquareRootPrecalculator.GetSqrt(100)}");
            sw2.Stop();
            Console.WriteLine($"Time taken: {sw2.ElapsedTicks}");
            Stopwatch sw3 = Stopwatch.StartNew();
            sw3.Start();
            Console.WriteLine($"Square root of 120 = {SquareRootPrecalculator.GetSqrt(120)}");
            sw3.Stop();
            Console.WriteLine($"Time taken: {sw3.ElapsedTicks}");
            Stopwatch sw4 = Stopwatch.StartNew();
            sw4.Start();
            Console.WriteLine($"Square root of 200 = {SquareRootPrecalculator.GetSqrt(200)}");
            sw4.Stop();
            Console.WriteLine($"Time taken: {sw4.ElapsedTicks}");
        }
    }
}
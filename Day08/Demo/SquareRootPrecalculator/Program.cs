using System.Diagnostics;

namespace SquareRootPrecalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch t1 = new Stopwatch();
            Stopwatch t2 = new Stopwatch();

            // Test 1
            t1.Start();
            Console.WriteLine($"Square Root of 2 = {SquareRootPrecalculator.GetSqrt(2)}");
            t1.Stop();
            Console.WriteLine($"CPU Ticks = {t1.ElapsedTicks}");

            // Test 2
            t2.Start();
            Console.WriteLine($"Square Root of 102 = {SquareRootPrecalculator.GetSqrt(102)}");
            t2.Stop();
            Console.WriteLine($"CPU Ticks = {t2.ElapsedTicks}");
        }
    }
}

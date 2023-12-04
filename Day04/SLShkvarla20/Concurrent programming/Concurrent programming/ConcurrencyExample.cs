using System;
using System.Threading.Tasks;

public class ConcurrencyExample
{
    public static async Task Main()
    {
        Console.WriteLine("Main Thread: Start");
        // Start a new task using Task.Run
        Task task1 = Task.Run(() => PrintNumbers());

        // Continue executing other tasks concurrently
        Console.WriteLine("Main Thread: Continuing");

        // Wait for the task to complete
        await task1;

        Console.WriteLine("Main Thread: End");
    }

    public static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Task Thread: Number {i}");
            Task.Delay(1000).Wait(); // Simulating some work
        }
    }
}
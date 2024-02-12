using System;

namespace AdvancedList
{
    public partial class Program
    {

        static void Main(string[] args)
        {
            AdvancedList<int> advanced = new AdvancedList<int>();

            for (int i = 0; i < 5; i++) 
            {
                advanced.Add(i);
            }

            Console.WriteLine("Removed: " + advanced.Remove(2));
            Console.WriteLine("Contains: " + advanced.Contains(1));
            advanced.Swap(0, 1);

            Console.WriteLine("CountGreaterThan: " + advanced.CountGreaterThan(2));
            Console.WriteLine("Min: " + advanced.Min());
            Console.WriteLine("Max: " + advanced.Max());
        }
    }
}
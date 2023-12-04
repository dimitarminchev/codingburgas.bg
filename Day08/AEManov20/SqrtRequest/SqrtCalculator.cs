using System.Collections.Generic;

namespace SqrtRequest;

public static class SqrtCalculator
{
    private const int maxValues = 1000;

    private static Dictionary<double, double> cache = new();

    static SqrtCalculator()
    {
        for (int i = 0; i < maxValues; i++)
        {
            cache.Add(i, Math.Sqrt(i));
        }
    }
    
    public static double Calculate(double number)
    {
        // if (!cache.ContainsKey(number))
        // {
        //     double result = Math.Sqrt(number);
        //     cache[number] = result;
        // }
        return cache[number];
    }
}
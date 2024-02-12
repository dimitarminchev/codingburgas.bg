using System;

namespace BetterList
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Създаване на списък
            BetterList<int> list = new BetterList<int>();

            // Добавли сме 10 случайни числа
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(1,100));
            }

            // Извеждане на всички елементи
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", list.Get(i));
            }
            Console.WriteLine();

            // Извеждане на минималния и максималния елемент
            Console.WriteLine("Min = {0}", list.Min());
            Console.WriteLine("Max = {0}", list.Max());
        }
    }
}

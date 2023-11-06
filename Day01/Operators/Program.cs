﻿namespace Operators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Числата от 1 до 100
            Console.WriteLine("Numbers from 1 to 100:");
            for (int i = 1; i <= 100; i++) // i = i + 1
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine(Environment.NewLine); // Оставя два празни реда

            // Четните числа от 1 до 100
            Console.WriteLine("Even numbers from 1 to 100:");
            int a = 1;
            while (a <= 100)
            {
                if (a % 2 == 0)
                {
                    Console.Write($"{a} ");
                }
                a = a + 1; // a=a+1, a++, a+=1
            }
            Console.WriteLine(Environment.NewLine); // Оставя два празни реда

            // Числата кратни на 7 в интервалът от 1 до 100
            Console.WriteLine("Numbers multiples of 7 in the range 1 to 100:");
            int b = 1;
            do
            {
                if (b % 7 == 0)
                {
                    Console.Write($"{b} ");
                }
                b = b + 1; // b++
            }
            while (b <= 100);
            Console.WriteLine(Environment.NewLine); // Оставя два празни реда

            // Безкраен цикъл
            Console.WriteLine("Forever Loop:");
            while (true)
            {
                // continue; // Продължава следваща итерация
                Console.WriteLine("1011");
                break; // Прекъсване на цикъла
            };
        }
    }
}
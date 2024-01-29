namespace BoxForEverything
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 2. Кутия за всичко
            var integerBox = new Box<int>(123123);
            Console.WriteLine(integerBox.ToString());

            var stringBox = new Box<string>("life in a box");
            Console.WriteLine(stringBox.ToString());
            */

            /*
            // 3. Универсална кутия за низове
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var box3 = new Box<string>(Console.ReadLine());
                Console.WriteLine(box3.ToString());
            }
            */

            // 4. Универсална кутия за цели числа
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                var box4 = new Box<int>(number);
                Console.WriteLine(box4.ToString());
            }
        }
    }
}

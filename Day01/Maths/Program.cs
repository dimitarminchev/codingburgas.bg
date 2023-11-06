namespace Maths
{
    public class Program
    {
        /// <summary>
        /// Математически операции: + - * / %
        /// </summary>
        public static void Main(string[] args)
        {
            try
            {
                // v1
                // Console.WriteLine("Sample:\n2\n2");
                // int a = int.Parse(Console.ReadLine()); // 2
                // int b = int.Parse(Console.ReadLine()); // 2
                // int c = a + b;
                // Console.WriteLine("{0} + {1} = {2}", a, b, c); // 2 + 2 = 4

                // v2
                Console.WriteLine("Sample:\n2 2");
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int c = line[0] + line[1];
                Console.WriteLine("{0} + {1} = {2}", line[0], line[1], c);

            }
            catch (Exception error)
            {
                Console.WriteLine("Exception: {0}", error.Message);
            }
        }
    }
}
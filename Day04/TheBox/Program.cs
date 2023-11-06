using System.Reflection;

namespace TheBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            decimal l = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());
            decimal w = decimal.Parse(Console.ReadLine());

            Box box = new Box(l, h, w);

            Console.WriteLine(box.ToString());
        }
    }
}
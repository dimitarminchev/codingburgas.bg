namespace Box
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<int> b = new Box<int>();

            b.Add(1);
            b.Add(2);
            b.Add(3);

            Console.WriteLine(b.Remove());
        }
    }
}
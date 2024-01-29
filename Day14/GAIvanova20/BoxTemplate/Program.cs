namespace BoxTemplate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxTemplate<int> box = new BoxTemplate<int>();
            
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());
        }
    }
}
namespace RandomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            RandomList ran = new RandomList();

            ran.Add("1");
            ran.Add("2");
            ran.Add("3");
            ran.Add("4");

            Console.WriteLine(ran.RandString());
        }
    }
}

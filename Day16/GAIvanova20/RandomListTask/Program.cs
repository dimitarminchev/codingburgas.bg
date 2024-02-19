namespace RandomListTask
{
    public partial class Program
    {
        static void Main(string[] args)
        {
           RandomList list = new RandomList();

            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");

            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
        }
    }
}